package com.lausebscode.modelo;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.RequiredArgsConstructor;

import java.time.LocalDateTime;

@Data
@RequiredArgsConstructor
@AllArgsConstructor
@Builder

public class Evento {
    private int id;
    private String nombre;
    private double precio;
    private LocalDateTime fecha;



}
