package com.lausebscode.controladores;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.lausebscode.modelo.Cancion;
import com.lausebscode.modelo.Concierto;
import com.lausebscode.modelo.ConciertoInfo;
import com.lausebscode.modelo.Evento;
import com.lausebscode.servicio.ServicioCancion;
import com.lausebscode.servicio.ServicioEvento;
import org.springframework.web.bind.annotation.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.http.HttpStatus;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@RestController
@RequestMapping("/evento/concierto")
public class ControladorEvento {

    @Autowired
    private ServicioEvento servicioEvento;
    @Autowired
    private ServicioCancion servicioCancion;

    @PostMapping("/add")
    public ResponseEntity<?> adicionarConcierto(@RequestBody String jsonConcierto) {
        try {
            ObjectMapper objectMapper = new ObjectMapper();
            JsonNode rootNode = objectMapper.readTree(jsonConcierto);

            // Extraer todos los campos necesarios del JSON
            Integer id = rootNode.get("id").asInt();
            String nombre = rootNode.get("nombre").asText();
            List<Integer> cancionesIds = objectMapper.convertValue(rootNode.get("cancionesIds"), List.class);
            double precio = rootNode.get("precio").asDouble();
            String artista = rootNode.get("artista").asText();

            // Parseo de fecha con LocalDateTime
            String fechaString = rootNode.get("fecha").asText();
            DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd'T'HH:mm:ss");
            LocalDateTime fecha = LocalDateTime.parse(fechaString, formatter);

            // Obtener las canciones a partir de los IDs
            List<Cancion> canciones = new ArrayList<>();
            for (Integer cancionId : cancionesIds) {
                Cancion cancion = servicioCancion.buscarCancionId(cancionId);
                if (cancion == null) {
                    return ResponseEntity.badRequest().body("Canción con ID " + cancionId + " no encontrada.");
                }
                canciones.add(cancion);
            }

            // Crear y llenar el objeto Concierto
            Concierto concierto = new Concierto();
            concierto.setId(id);
            concierto.setNombre(nombre);
            concierto.setFecha(fecha);
            concierto.setPrecio(precio);
            concierto.setArtista(artista);
            concierto.setCanciones(canciones);

            // Intentar guardar el concierto
            Evento evento = servicioEvento.adicionarConcierto(concierto);

            return ResponseEntity.status(HttpStatus.CREATED).body(concierto);

        } catch (JsonProcessingException e) {
            // Error al procesar el JSON
            e.printStackTrace();
            return ResponseEntity.status(HttpStatus.BAD_REQUEST).body("Error al procesar el JSON.");
        } catch (DateTimeParseException e) {
            // Error al parsear la fecha
            e.printStackTrace();
            return ResponseEntity.status(HttpStatus.BAD_REQUEST).body("Formato de fecha inválido.");
        } catch (Exception e) {
            // Manejo de cualquier otra excepción
            e.printStackTrace();
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("Error interno del servidor: " + e.getMessage());
        }
    }
    @GetMapping("/buscar/id/{id}")
    public ResponseEntity<ConciertoInfo> buscarConciertoId(@PathVariable int id) {
        try {
            Concierto concierto = (Concierto) servicioEvento.buscarConciertoId(id);
            List<Integer> cancionesIds = concierto.getCanciones().stream()
                    .map(Cancion::getId)
                    .collect(Collectors.toList());


            ConciertoInfo conciertoInfo = new ConciertoInfo(
                    concierto.getId(),
                    concierto.getNombre(),
                    concierto.getFecha(),
                    concierto.getPrecio(),
                    concierto.getArtista(),
                    cancionesIds
            );

            return ResponseEntity.ok(conciertoInfo);
        } catch (IllegalArgumentException e) {
            return ResponseEntity.notFound().build();
        }
    }

    @GetMapping("/buscar/nombre/{nombre}")
    public ResponseEntity<ConciertoInfo> buscarConciertoNombre(@PathVariable String nombre) {
        try {
            Concierto concierto = (Concierto) servicioEvento.buscarConciertoNombre(nombre);
            List<Integer> cancionesIds = concierto.getCanciones().stream()
                    .map(Cancion::getId)
                    .collect(Collectors.toList());

            ConciertoInfo conciertoInfo = new ConciertoInfo(
                    concierto.getId(),
                    concierto.getNombre(),
                    concierto.getFecha(),
                    concierto.getPrecio(),
                    concierto.getArtista(),
                    cancionesIds
            );

            return ResponseEntity.ok(conciertoInfo);
        } catch (IllegalArgumentException e) {
            return ResponseEntity.notFound().build();
        }
    }

    @DeleteMapping("/eliminar/{id}")
    public ResponseEntity<Void> eliminarConcierto(@PathVariable int id) {
        try {
            servicioEvento.eliminarConcierto(id);
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
    public ResponseEntity<?> actualizarConcierto(
            @PathVariable("id") int id,
            @RequestBody String jsonConcierto) {

        try {
            ObjectMapper objectMapper = new ObjectMapper();
            JsonNode rootNode = objectMapper.readTree(jsonConcierto);

            // Extraer todos los campos necesarios del JSON
            String nombre = rootNode.get("nombre").asText();
            List<Integer> cancionesIds = objectMapper.convertValue(rootNode.get("cancionesIds"), List.class);
            double precio = rootNode.get("precio").asDouble();
            String artista = rootNode.get("artista").asText();

            // Parseo de fecha con LocalDateTime
            String fechaString = rootNode.get("fecha").asText();
            DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd'T'HH:mm:ss");
            LocalDateTime fecha = LocalDateTime.parse(fechaString, formatter);

            // Obtener las canciones a partir de los IDs
            List<Cancion> canciones = new ArrayList<>();
            for (Integer cancionId : cancionesIds) {
                Cancion cancion = servicioCancion.buscarCancionId(cancionId);
                if (cancion == null) {
                    return ResponseEntity.badRequest().body("Canción con ID " + cancionId + " no encontrada.");
                }
                canciones.add(cancion);
            }

            // Llenar el objeto Concierto con la información actualizada
            Concierto conciertoActualizado = new Concierto();
            conciertoActualizado.setId(id);
            conciertoActualizado.setNombre(nombre);
            conciertoActualizado.setFecha(fecha);
            conciertoActualizado.setPrecio(precio);
            conciertoActualizado.setArtista(artista);
            conciertoActualizado.setCanciones(canciones);

            // Llamar al servicio para actualizar el concierto
            Concierto concierto = servicioEvento.actualizarConcierto(id, conciertoActualizado);
            return ResponseEntity.ok(concierto);

        } catch (JsonProcessingException e) {
            // Error al procesar el JSON
            e.printStackTrace();
            return ResponseEntity.status(HttpStatus.BAD_REQUEST).body("Error al procesar el JSON.");
        } catch (DateTimeParseException e) {
            // Error al parsear la fecha
            e.printStackTrace();
            return ResponseEntity.status(HttpStatus.BAD_REQUEST).body("Formato de fecha inválido.");
        } catch (IllegalArgumentException e) {
            // Si el concierto no se encuentra, lanzar una respuesta 404
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Concierto con ID " + id + " no encontrado.");
        } catch (Exception e) {
            // Manejo de cualquier otra excepción no prevista
            e.printStackTrace();
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body("Error interno del servidor: " + e.getMessage());
        }
    }

}