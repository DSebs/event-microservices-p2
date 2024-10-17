import React, { useState } from 'react';
import { agregarCancion } from '../../services/cancionService';

const AgregarCancion = () => {
  const [cancion, setCancion] = useState({
    id: '',
    nombre: '',
    duracion: '',
    fechaLanzamiento: '',
    compositor: ''
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setCancion(prev => ({ ...prev, [name]: value }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    // Aseguramos que la fecha tiene el formato correcto (YYYY-MM-DDTHH:mm:ss)
    const fechaAjustada = cancion.fechaLanzamiento.includes(":") ? cancion.fechaLanzamiento + ":00" : cancion.fechaLanzamiento;
    const cancionAjustada = { ...cancion, fechaLanzamiento: fechaAjustada };
  
    try {
      await agregarCancion(cancionAjustada);
      alert('Canción agregada exitosamente');
    } catch (error) {
      alert('Error al agregar canción: ' + error.message);
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6">
          <div className="card">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Agregar Canción</h2>
              <form onSubmit={handleSubmit}>
                <div className="mb-3">
                  <input
                    type="number"
                    className="form-control"
                    name="id"
                    value={cancion.id}
                    onChange={handleChange}
                    placeholder="ID"
                    required
                  />
                </div>
                <div className="mb-3">
                  <input
                    type="text"
                    className="form-control"
                    name="nombre"
                    value={cancion.nombre}
                    onChange={handleChange}
                    placeholder="Nombre"
                    required
                  />
                </div>
                <div className="mb-3">
                  <input
                    type="number"
                    className="form-control"
                    name="duracion"
                    value={cancion.duracion}
                    onChange={handleChange}
                    placeholder="Duración (minutos)"
                    required
                  />
                </div>
                <div className="mb-3">
                  <input
                    type="datetime-local"
                    className="form-control"
                    name="fechaLanzamiento"
                    value={cancion.fechaLanzamiento}
                    onChange={handleChange}
                    required
                  />
                </div>
                <div className="mb-3">
                  <input
                    type="text"
                    className="form-control"
                    name="compositor"
                    value={cancion.compositor}
                    onChange={handleChange}
                    placeholder="Compositor"
                    required
                  />
                </div>
                <div className="d-grid">
                  <button type="submit" className="btn btn-primary">Agregar</button>
                </div>
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default AgregarCancion;
