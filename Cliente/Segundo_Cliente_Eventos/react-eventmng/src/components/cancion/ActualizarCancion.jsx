import React, { useState } from 'react';
import { buscarCancionPorId, actualizarCancion } from '../../services/cancionService';

const ActualizarCancion = () => {
  const [id, setId] = useState('');
  const [cancion, setCancion] = useState({});
  const [actualizado, setActualizado] = useState(false);

  const handleBuscar = async (e) => {
    e.preventDefault();
    try {
      const resultado = await buscarCancionPorId(id);
      setCancion(resultado);
      setActualizado(false);
    } catch (error) {
      alert('Error al buscar canción: ' + error.message);
    }
  };

  const handleActualizar = async (e) => {
    e.preventDefault();
    try {
      const tieneSegundos = cancion.fechaLanzamiento.split(":").length === 3;
      const fechaAjustada = tieneSegundos ? cancion.fechaLanzamiento : cancion.fechaLanzamiento + ":00";

      const cancionAjustada = { ...cancion, fechaLanzamiento: fechaAjustada };

      await actualizarCancion(id, cancionAjustada);
      setActualizado(true);
    } catch (error) {
      alert('Error al actualizar canción: ' + error.message);
    }
  };

  const handleChange = (e) => {
    const { name, value } = e.target;
    setCancion(prev => ({
      ...prev,
      [name]: name === 'duracion' ? parseFloat(value) : value // Convertir duración a número
    }));
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6">
          <div className="card">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Actualizar Canción</h2>
              <form onSubmit={handleBuscar}>
                <div className="mb-3">
                  <input
                    type="number"
                    className="form-control"
                    value={id}
                    onChange={(e) => setId(e.target.value)}
                    placeholder="Digite el ID de la Canción"
                    required
                  />
                </div>
                <div className="d-grid">
                  <button type="submit" className="btn btn-primary">Buscar Canción</button>
                </div>
              </form>

              {cancion && (
                <form className="mt-4" onSubmit={handleActualizar}>
                  <div className="mb-3">
                    <label htmlFor="nombre" className="form-label">Nombre</label>
                    <input
                      type="text"
                      className="form-control"
                      id="nombre"
                      name="nombre"
                      value={cancion.nombre}
                      onChange={handleChange}
                      required
                    />
                  </div>

                  <div className="mb-3">
                    <label htmlFor="duracion" className="form-label">Duración (en minutos)</label>
                    <input
                      type="number"
                      step="0.1"
                      className="form-control"
                      id="duracion"
                      name="duracion"
                      value={cancion.duracion}
                      onChange={handleChange}
                      required
                    />
                  </div>

                  <div className="mb-3">
                    <label htmlFor="fechaLanzamiento" className="form-label">Fecha de Lanzamiento</label>
                    <input
                      type="datetime-local"
                      className="form-control"
                      id="fechaLanzamiento"
                      name="fechaLanzamiento"
                      value={cancion.fechaLanzamiento}
                      onChange={handleChange}
                      required
                    />
                  </div>

                  <div className="mb-3">
                    <label htmlFor="compositor" className="form-label">Compositor</label>
                    <input
                      type="text"
                      className="form-control"
                      id="compositor"
                      name="compositor"
                      value={cancion.compositor}
                      onChange={handleChange}
                      required
                    />
                  </div>

                  <div className="d-grid">
                    <button type="submit" className="btn btn-success">Actualizar Canción</button>
                  </div>

                  {actualizado && (
                    <div className="alert alert-success mt-3" role="alert">
                      Canción actualizada correctamente.
                    </div>
                  )}
                </form>
              )}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ActualizarCancion;
