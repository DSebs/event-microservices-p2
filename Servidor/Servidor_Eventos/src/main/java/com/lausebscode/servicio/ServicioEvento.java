package com.lausebscode.servicio;

import com.lausebscode.modelo.Evento;
import org.springframework.stereotype.Service;

import java.util.ArrayList;

@Service
public class ServicioEvento {
    private static ServicioEvento servicioEvento;
    private ArrayList<Evento> eventos;

    private ServicioEvento(){
        eventos = new ArrayList();
    }

    public static ServicioEvento getServicioEvento(){
        if (servicioEvento == null){
            servicioEvento = new ServicioEvento();
        }
        return servicioEvento;
    }

}
