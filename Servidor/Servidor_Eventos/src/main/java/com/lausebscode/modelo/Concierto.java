package com.lausebscode.modelo;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import lombok.experimental.SuperBuilder;

import java.util.List;

@Data
@NoArgsConstructor
@AllArgsConstructor
@SuperBuilder
public class Concierto extends Evento {
    private String artista;

    private List<Cancion> canciones;

    public Boolean tengoCancion(int idsillo)
    {
        for(Cancion i : canciones){
            if( i.getId() == idsillo){
                return true;
            }
        }
        return false;
    }
}