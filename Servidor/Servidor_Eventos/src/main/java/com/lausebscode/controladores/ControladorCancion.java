package com.lausebscode.controladores;

import com.lausebscode.modelo.Cancion;
import com.lausebscode.modelo.Concierto;
import com.lausebscode.modelo.Evento;
import com.lausebscode.servicio.ServicioCancion;
import com.lausebscode.servicio.ServicioEvento;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/cancion")
public class ControladorCancion {
    @Autowired
    private ServicioCancion servicioCancion;

    @PostMapping("/add")
    public ResponseEntity<Cancion> adicionarCancion(@RequestBody Cancion cancion) {
        try {
           servicioCancion.adicionarCancion(cancion);

        } catch (IllegalArgumentException e) {
            return ResponseEntity.badRequest().build();
        }
        return ResponseEntity.status(HttpStatus.CREATED).body(cancion);
    }

    @GetMapping("/buscar/id/{id}")
    public ResponseEntity<Cancion> buscarCancionId(@PathVariable int id) {
        try {
            Cancion cancion = (Cancion) servicioCancion.buscarCancionId(id);
            return ResponseEntity.ok(cancion);
        } catch (IllegalArgumentException e) {
            return ResponseEntity.notFound().build();
        }
    }

    @GetMapping("/buscar/nombre/{nombre}")
    public ResponseEntity<Cancion> buscarCancionNombre(@PathVariable String nombre) {
        try {
            Cancion cancion = (Cancion) servicioCancion.buscarCancionNombre(nombre);
            return ResponseEntity.ok(cancion);
        } catch (IllegalArgumentException e) {
            return ResponseEntity.notFound().build();
        }
    }

    @DeleteMapping("/eliminar")
    public ResponseEntity<Void> eliminarCancion(@RequestBody Cancion cancion) {
        try {
            servicioCancion.eliminarCancion(cancion);
            return ResponseEntity.noContent().build();
        } catch (IllegalArgumentException e) {
            return ResponseEntity.badRequest().build();
        }
    }

    @GetMapping("/listar")
    public ResponseEntity<List<Cancion>> listarCancion() {
        List<Cancion> canciones = servicioCancion.listarCanciones();
        return ResponseEntity.ok(canciones);
    }

    @GetMapping("/listar/duracion/{duracionMin}")
    public ResponseEntity<List<Cancion>> listarCancionesMin(@PathVariable String duracionMin) {
        try {
            double duracionMinD = Double.parseDouble(duracionMin.replace(',', '.'));
            List<Cancion> canciones = servicioCancion.listarCancionesMin(duracionMinD);
            return ResponseEntity.ok(canciones);
        } catch (IllegalArgumentException e) {
            return ResponseEntity.badRequest().build();
        }
    }

    @PutMapping("/{id}")
    public ResponseEntity<Cancion> actualizarCancion(
            @PathVariable("id") int id,
            @RequestBody Cancion nuevaCancion) {
        try {
            Cancion cancionActualizado = servicioCancion.actualizarCancion(id, nuevaCancion);
            return ResponseEntity.ok(cancionActualizado);
        } catch (IllegalArgumentException e) {
            return ResponseEntity.notFound().build();
        }
    }




}
