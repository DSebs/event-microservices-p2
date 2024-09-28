package com.lausebscode.controladores;

import com.lausebscode.modelo.Concierto;
import com.lausebscode.modelo.Evento;
import com.lausebscode.servicio.ServicioEvento;
import org.springframework.web.bind.annotation.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.http.HttpStatus;

import java.util.List;

@RestController
@RequestMapping("/evento/concierto")
public class ControladorEvento {

    @Autowired
    private ServicioEvento servicioEvento;

    @PostMapping("/add")
    public ResponseEntity<?> adicionarConcierto(@RequestBody Concierto concierto) {
        try {
            Evento evento = servicioEvento.adicionarConcierto(concierto);
            return ResponseEntity.status(HttpStatus.CREATED).body(evento);
        } catch (IllegalArgumentException e) {
            return ResponseEntity.badRequest().body(e.getMessage());
        }
    }

    @GetMapping("/buscar/id/{id}")
    public ResponseEntity<Concierto> buscarConciertoId(@PathVariable int id) {
        try {
            Concierto concierto = (Concierto) servicioEvento.buscarConciertoId(id);
            return ResponseEntity.ok(concierto);
        } catch (IllegalArgumentException e) {
            return ResponseEntity.notFound().build();
        }
    }

    @GetMapping("/buscar/nombre/{nombre}")
    public ResponseEntity<Concierto> buscarConciertoNombre(@PathVariable String nombre) {
        try {
            Concierto concierto = (Concierto) servicioEvento.buscarConciertoNombre(nombre);
            return ResponseEntity.ok(concierto);
        } catch (IllegalArgumentException e) {
            return ResponseEntity.notFound().build();
        }
    }

    @DeleteMapping("/eliminar")
    public ResponseEntity<Void> eliminarConcierto(@RequestBody Concierto concierto) {
        try {
            servicioEvento.eliminarConcierto(concierto);
            return ResponseEntity.noContent().build();
        } catch (IllegalArgumentException e) {
            return ResponseEntity.badRequest().build();
        }
    }

    @GetMapping("/listar")
    public ResponseEntity<List<Evento>> listarConciertos() {
        List<Evento> conciertos = servicioEvento.listarConciertos();
        return ResponseEntity.ok(conciertos);
    }

    @GetMapping("/listar/precio/{precioMin}")
    public ResponseEntity<List<Concierto>> listarConciertosMin(@PathVariable double precioMin) {
        try {
            List<Concierto> conciertos = servicioEvento.listarConciertosMin(precioMin);
            return ResponseEntity.ok(conciertos);
        } catch (IllegalArgumentException e) {
            return ResponseEntity.badRequest().build();
        }
    }

    @PutMapping("/{id}")
    public ResponseEntity<Concierto> actualizarConcierto(
            @PathVariable("id") int id,
            @RequestBody Concierto nuevoConcierto) {
        try {
            Concierto conciertoActualizado = servicioEvento.actualizarConcierto(id, nuevoConcierto);
            return ResponseEntity.ok(conciertoActualizado);
        } catch (IllegalArgumentException e) {
            return ResponseEntity.notFound().build();
        }
    }
}