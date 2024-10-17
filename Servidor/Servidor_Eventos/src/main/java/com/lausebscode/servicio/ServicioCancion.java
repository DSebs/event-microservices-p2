package com.lausebscode.servicio;

import com.lausebscode.modelo.Cancion;
import com.lausebscode.modelo.Concierto;
import com.lausebscode.modelo.Evento;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class ServicioCancion {

    private static ServicioCancion servicioCancion;
    private List<Cancion> canciones;
    @Autowired
    private ServicioEvento servicioEvento;

    private ServicioCancion(){
        canciones= new ArrayList<>();
    }

    public static ServicioCancion getServicioCancion(){
        if (servicioCancion == null){
            servicioCancion= new ServicioCancion();
        }
        return servicioCancion;
    }

    public Cancion adicionarCancion(Cancion cancion) {
        validarCancion(cancion);
        validarUnicidad(cancion);
       canciones.add(cancion);
        return cancion;
    }

    public Cancion buscarCancionId (int id){
        return canciones.stream()
                .filter(cancion -> cancion.getId() == id)
                .findFirst()
                .map(cancion -> (Cancion) cancion)
                .orElseThrow(() -> new IllegalArgumentException("No se encontró el concierto con ID: " + id));
    }

    public Cancion buscarCancionNombre (String nombre){
        if (nombre == null || nombre.trim().isEmpty()) {
            throw new IllegalArgumentException("El nombre del cancion no puede estar vacío");
        }
        return canciones.stream()
                .filter(cancion -> cancion .getNombre().equalsIgnoreCase(nombre))
                .findFirst()
                .map(cancion -> (Cancion) cancion)
                .orElseThrow(() -> new IllegalArgumentException("No se encontró el cancion con nombre: " + nombre));
    }


    public void eliminarCancion(Cancion cancion){
        if (cancion == null) {
            throw new IllegalArgumentException("La canción a eliminar no puede ser null");
        }
        if (canciones.remove(cancion)) {
            servicioEvento.eliminarCancionDeConciertos(cancion.getId());
        } else {
            throw new IllegalArgumentException("No se encontró la canción a eliminar");
        }
    }

    public List<Cancion> listarCanciones(){
        return new ArrayList<>(canciones);
    }

    public List<Cancion> listarCancionesMin(double duracionMin){
        if (duracionMin < 0) {
            throw new IllegalArgumentException("La duracion minima de la cancion no puede ser negativa");
        }
        return canciones.stream()
                .filter(cancion -> cancion.getDuracion() >= duracionMin)
                .map(cancion -> (Cancion) cancion)
                .collect(Collectors.toList());
    }

    public Cancion actualizarCancion(int id, Cancion nuevoCancion) {

        // Validaciones para evitar duplicidad de atributos clave
        validarCancion(nuevoCancion);

        Cancion cancionExistente = (Cancion) canciones.stream()
                .filter(c -> c.getId() == id)
                .findFirst()
                .orElseThrow(() -> new IllegalArgumentException("Cancion no encontrada con ID: " + id));

        if (!cancionExistente.getNombre().equalsIgnoreCase(nuevoCancion.getNombre())) {
            validarUnicidadNombre(nuevoCancion);
        }

        cancionExistente.setNombre(nuevoCancion.getNombre());
        cancionExistente.setId(nuevoCancion.getId());
        cancionExistente.setDuracion(nuevoCancion.getDuracion());
        cancionExistente.setFechaLanzamiento(nuevoCancion.getFechaLanzamiento());
        cancionExistente.setCompositor(nuevoCancion.getCompositor());

        return cancionExistente;
    }

    private void validarCancion(Cancion cancion) {
        if (cancion == null) {
            throw new IllegalArgumentException("La cancion no puede ser null");
        }
        if (cancion.getNombre() == null || cancion.getNombre().trim().isEmpty()) {
            throw new IllegalArgumentException("El nombre de la cancion no puede estar vacío");
        }
        if (cancion.getId() <= 0) {
            throw new IllegalArgumentException("El id de la cancion no puede ser null");
        }
        if (cancion.getDuracion() < 0) {
            throw new IllegalArgumentException("La duracion de la cancion no puede ser negativo");
        }
        if (cancion.getFechaLanzamiento() == null ) {
            throw new IllegalArgumentException("La fecha de la cancion no puede estar vacío");
        }
        if (cancion.getCompositor() == null || cancion.getCompositor().trim().isEmpty()) {
            throw new IllegalArgumentException("El compositor de la cancion no puede estar vacío");
        }
    }

    private void validarUnicidad(Cancion cancion) {
        if (canciones.stream().anyMatch(e -> e.getId() == cancion.getId())) {
            throw new IllegalArgumentException("Ya existe una cancion con el ID: " + cancion.getId());
        }
        if (canciones.stream().anyMatch(e -> e.getNombre().equalsIgnoreCase(cancion.getNombre()))) {
            throw new IllegalArgumentException("Ya existe un evento con el nombre: " + cancion.getNombre());
        }
    }

    private void validarUnicidadNombre(Cancion cancion){
        if (canciones.stream().anyMatch(e -> e.getNombre().equalsIgnoreCase(cancion.getNombre()))) {
            throw new IllegalArgumentException("Ya existe una con el nombre: " + cancion.getNombre());
        }
    }
}
