import React, { useState } from 'react';
import { buscarConciertoPorId, eliminarConcierto } from '../../services/conciertoService';

const EliminarConcierto = () => {
  const [id, setId] = useState('');
  const [concierto, setConcierto] = useState(null);
  const [eliminado, setEliminado] = useState(false);

  // Manejador para buscar el concierto por ID
  const handleBuscar = async (e) => {
    e.preventDefault();
    try {
      const resultado = await buscarConciertoPorId(id);
      setConcierto(resultado);
      setEliminado(false); // Reinicia el estado de eliminación
    } catch (error) {
      alert('Error al buscar concierto: ' + error.message);
    }
  };

  // Manejador para eliminar el concierto
  const handleEliminar = async () => {
    try {
      await eliminarConcierto(id);
      setEliminado(true); // Indica que la eliminación fue exitosa
      setConcierto(null); // Reinicia el estado del concierto
      setId(''); // Reinicia el campo de ID
    } catch (error) {
      alert('Error al eliminar concierto: ' + error.message);
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6">
          <div className="card">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Eliminar Concierto</h2>
              {/* Formulario para buscar el concierto por ID */}
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
                  <button type="submit" className="btn btn-primary">
                    Buscar Concierto
                  </button>
                </div>
              </form>

              {/* Información del concierto si se encuentra */}
              {concierto && (
                <div className="mt-4">
                  <h5>Información del Concierto</h5>
                  <p><strong>Nombre:</strong> {concierto.nombre}</p>
                  <p><strong>Precio:</strong> {concierto.precio}</p>
                  <p><strong>Fecha:</strong> {new Date(concierto.fecha).toLocaleString()}</p>
                  <p><strong>Artista:</strong> {concierto.artista}</p>
                  <p><strong>IDs de Canciones:</strong> {concierto.cancionesIds.join(', ')}</p>
                  <div className="d-grid">
                    <button onClick={handleEliminar} className="btn btn-danger">
                      Eliminar Concierto
                    </button>
                  </div>
                </div>
              )}

              {/* Mensaje de éxito al eliminar */}
              {eliminado && (
                <div className="alert alert-success mt-3" role="alert">
                  Concierto eliminado correctamente.
                </div>
              )}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default EliminarConcierto;
