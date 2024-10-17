import React, { useState } from 'react';
import { buscarConciertoPorId, actualizarConcierto } from '../../services/conciertoService';

const ActualizarConcierto = () => {
  const [id, setId] = useState('');
  const [concierto, setConcierto] = useState({ cancionesIds: [] }); // Inicializar como objeto con cancionesIds como array
  const [actualizado, setActualizado] = useState(false);

  const handleBuscar = async (e) => {
    e.preventDefault();
    try {
      const resultado = await buscarConciertoPorId(id);
      // Asegurarse de que cancionesIds sea un array
      setConcierto({
        ...resultado,
        cancionesIds: Array.isArray(resultado.cancionesIds) ? resultado.cancionesIds : []
      });
      setActualizado(false);
    } catch (error) {
      alert('Error al buscar concierto: ' + error.message);
    }
  };

  const handleActualizar = async (e) => {
    e.preventDefault();
    try {
      // Verificar si la fecha tiene exactamente el formato 'yyyy-MM-ddTHH:mm:ss'
      const tieneSegundos = concierto.fecha.split(":").length === 3;
      const fechaAjustada = tieneSegundos ? concierto.fecha : concierto.fecha + ":00";

      const conciertoAjustado = { ...concierto, fecha: fechaAjustada };

      await actualizarConcierto(id, conciertoAjustado);
      setActualizado(true);
    } catch (error) {
      alert('Error al actualizar concierto: ' + error.message);
    }
  };


  const handleChange = (e) => {
    const { name, value } = e.target;
    
    // Manejo específico del campo cancionesIds
    if (name === 'cancionesIds') {
      setConcierto(prev => ({
        ...prev,
        [name]: value.split(',').map(Number) // Convertir el input en array de números
      }));
    } else {
      setConcierto(prev => ({ ...prev, [name]: value }));
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6">
          <div className="card">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Actualizar Concierto</h2>
              <form onSubmit={handleBuscar}>
                <div className="mb-3">
                  <input
                    type="number"
                    className="form-control"
                    value={id}
                    onChange={(e) => setId(e.target.value)}
                    placeholder="Digite el ID del Concierto"
                    required
                  />
                </div>
                <div className="d-grid">
                  <button type="submit" className="btn btn-primary">Buscar Concierto</button>
                </div>
              </form>

              {concierto && (
                <form className="mt-4" onSubmit={handleActualizar}>
                  <div className="mb-3">
                    <label htmlFor="nombre" className="form-label">Nombre</label>
                    <input
                      type="text"
                      className="form-control"
                      id="nombre"
                      name="nombre"
                      value={concierto.nombre}
                      onChange={handleChange}
                      required
                    />
                  </div>

                  <div className="mb-3">
                    <label htmlFor="precio" className="form-label">Precio</label>
                    <input
                      type="number"
                      className="form-control"
                      id="precio"
                      name="precio"
                      value={concierto.precio}
                      onChange={handleChange}
                      required
                    />
                  </div>

                  <div className="mb-3">
                    <label htmlFor="fecha" className="form-label">Fecha</label>
                    <input
                      type="datetime-local"
                      className="form-control"
                      id="fecha"
                      name="fecha"
                      value={concierto.fecha}
                      onChange={handleChange}
                      required
                    />
                  </div>

                  <div className="mb-3">
                    <label htmlFor="artista" className="form-label">Artista</label>
                    <input
                      type="text"
                      className="form-control"
                      id="artista"
                      name="artista"
                      value={concierto.artista}
                      onChange={handleChange}
                      required
                    />
                  </div>

                  <div className="mb-3">
                    <label htmlFor="cancionesIds" className="form-label">IDs de Canciones (separados por comas)</label>
                    <input
                      type="text"
                      className="form-control"
                      id="cancionesIds"
                      name="cancionesIds"
                      value={concierto.cancionesIds.join(', ') || ''}
                      onChange={handleChange}
                      placeholder="Ej: 1, 2, 3"
                    />
                  </div>

                  <div className="d-grid">
                    <button type="submit" className="btn btn-success">Actualizar Concierto</button>
                  </div>

                  {actualizado && (
                    <div className="alert alert-success mt-3" role="alert">
                      Concierto actualizado correctamente.
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

export default ActualizarConcierto;
