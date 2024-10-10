package com.lausebscode.modelo;

import java.time.LocalDateTime;
import java.util.List;

public record ConciertoInfo(int id,
                            String nombre,
                            LocalDateTime fecha,
                            double precio,
                            String artista,
                            List<Integer> cancionesIds) {

}
