package com.lausebscode.modelo;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import lombok.experimental.SuperBuilder;

import java.time.LocalDateTime;

@Data
@NoArgsConstructor
@AllArgsConstructor
@SuperBuilder
public class Cancion {

    private int id;
    private String nombre;
    private double duracion;
    private LocalDateTime fechaLanzamiento;
    private String compositor;


}
