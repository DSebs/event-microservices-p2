package com.lausebscode.servicio;

import com.lausebscode.modelo.Concierto;
import com.lausebscode.modelo.Evento;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class ServicioEvento {
    private static ServicioEvento servicioEvento;
    private List<Evento> eventos;

    private ServicioEvento(){
        eventos = new ArrayList<>();
    }

    public static ServicioEvento getServicioEvento(){
        if (servicioEvento == null){
            servicioEvento = new ServicioEvento();
        }
        return servicioEvento;
    }

    public Evento adicionarConcierto(Concierto concierto) {
        validarConcierto(concierto);
        validarUnicidad(concierto);
        eventos.add(concierto);
        return concierto;
    }

    public Evento buscarConciertoId (int id){
        return eventos.stream()
                .filter(evento -> evento.getId() == id)
                .findFirst()
                .map(evento -> (Concierto) evento)
                .orElseThrow(() -> new IllegalArgumentException("No se encontró el concierto con ID: " + id));
    }

    public Evento buscarConciertoNombre (String nombre){
        if (nombre == null || nombre.trim().isEmpty()) {
            throw new IllegalArgumentException("El nombre del concierto no puede estar vacío");
        }
        return eventos.stream()
                .filter(evento -> evento.getNombre().equalsIgnoreCase(nombre))
                .findFirst()
                .map(evento -> (Concierto) evento)
                .orElseThrow(() -> new IllegalArgumentException("No se encontró el concierto con nombre: " + nombre));
    }

    public void eliminarConcierto(int id) {
        try {
            Concierto concierto = (Concierto) buscarConciertoId(id);
            eventos.remove(concierto);

        } catch (Exception e) {
            System.err.println("Error inesperado al eliminar el concierto: " + e.getMessage());
        }
    }

    public ArrayList<Evento> listarConciertos(){
        return new ArrayList<>(eventos);
    }

    public List<Concierto> listarConciertosMin(double precioMin){
        if (precioMin < 0) {
            throw new IllegalArgumentException("El precio mínimo no puede ser negativo");
        }
        return eventos.stream()
                .filter(evento -> evento.getPrecio() >= precioMin)
                .map(evento -> (Concierto) evento)
                .collect(Collectors.toList());
    }

    public Concierto actualizarConcierto(int id, Concierto nuevoConcierto) {

        // Validaciones para evitar duplicidad de atributos clave
        validarConcierto(nuevoConcierto);

        Concierto conciertoExistente = (Concierto) eventos.stream()
                .filter(c -> c.getId() == id)
                .findFirst()
                .orElseThrow(() -> new IllegalArgumentException("Concierto no encontrado con ID: " + id));

        if (!conciertoExistente.getNombre().equalsIgnoreCase(nuevoConcierto.getNombre())) {
            validarUnicidadNombre(nuevoConcierto);
        }

        conciertoExistente.setNombre(nuevoConcierto.getNombre());
        conciertoExistente.setFecha(nuevoConcierto.getFecha());
        conciertoExistente.setPrecio(nuevoConcierto.getPrecio());
        conciertoExistente.setArtista(nuevoConcierto.getArtista());
        conciertoExistente.setCanciones(nuevoConcierto.getCanciones());


        return conciertoExistente;
    }

    public Boolean validarCanciones(List<Integer> ids, int conciertoIdActual) {
        for (Evento eve : eventos) {
            Concierto concierto = (Concierto) eve;

            // Saltamos la validación si es el mismo concierto
            if (concierto.getId() == conciertoIdActual) {
                continue;
            }

            boolean tenerCancion = false;
            for (int id : ids) {
                // Validamos si alguna canción ya está en otro concierto
                tenerCancion = concierto.tengoCancion(id);
                if (tenerCancion) {
                    return true; // Canción duplicada en otro concierto
                }
            }
        }
        return false; // No hay duplicados
    }
    private void validarConcierto(Concierto concierto) {
        if (concierto == null) {
            throw new IllegalArgumentException("El concierto no puede ser null");
        }
        if (concierto.getNombre() == null || concierto.getNombre().trim().isEmpty()) {
            throw new IllegalArgumentException("El nombre del concierto no puede estar vacío");
        }
        if (concierto.getFecha() == null) {
            throw new IllegalArgumentException("La fecha del concierto no puede ser null");
        }
        if (concierto.getPrecio() < 0) {
            throw new IllegalArgumentException("El precio del concierto no puede ser negativo");
        }
        if (concierto.getArtista() == null || concierto.getArtista().trim().isEmpty()) {
            throw new IllegalArgumentException("El artista del concierto no puede estar vacío");
        }

    }

    private void validarUnicidad(Concierto concierto) {
        if (eventos.stream().anyMatch(e -> e.getId() == concierto.getId())) {
            throw new IllegalArgumentException("Ya existe un evento con el ID: " + concierto.getId());
        }
        if (eventos.stream().anyMatch(e -> e.getNombre().equalsIgnoreCase(concierto.getNombre()))) {
            throw new IllegalArgumentException("Ya existe un evento con el nombre: " + concierto.getNombre());
        }
    }

    private void validarUnicidadNombre(Concierto concierto){
        if (eventos.stream().anyMatch(e -> e.getNombre().equalsIgnoreCase(concierto.getNombre()))) {
            throw new IllegalArgumentException("Ya existe un evento con el nombre: " + concierto.getNombre());
        }
    }
}