import React, { useState } from 'react';
import { buscarCancionPorId, eliminarCancion } from '../../services/cancionService';

const EliminarCancion = () => {
  const [id, setId] = useState('');
  const [cancion, setCancion] = useState(null);
  const [eliminado, setEliminado] = useState(false);

  // Manejador para buscar la canción por ID
  const handleBuscar = async (e) => {
    e.preventDefault();
    try {
      const resultado = await buscarCancionPorId(id);
      setCancion(resultado);
      setEliminado(false); // Reinicia el estado de eliminación
    } catch (error) {
      alert('Error al buscar canción: ' + error.message);
    }
  };

  // Manejador para eliminar la canción
  const handleEliminar = async () => {
    try {
      await eliminarCancion(cancion); // Enviar el objeto canción completo
      setEliminado(true); // Indica que la eliminación fue exitosa
      setCancion(null); // Reinicia el estado de la canción
      setId(''); // Reinicia el campo de ID
    } catch (error) {
      alert('Error al eliminar canción: ' + error.message);
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6">
          <div className="card">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Eliminar Canción</h2>
              {/* Formulario para buscar la canción por ID */}
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
                  <button type="submit" className="btn btn-primary">
                    Buscar Canción
                  </button>
                </div>
              </form>

              {/* Información de la canción si se encuentra */}
              {cancion && (
                <div className="mt-4">
                  <h5>Información de la Canción</h5>
                  <p><strong>Nombre:</strong> {cancion.nombre}</p>
                  <p><strong>Duración:</strong> {cancion.duracion} minutos</p>
                  <p><strong>Fecha de Lanzamiento:</strong> {new Date(cancion.fechaLanzamiento).toLocaleString()}</p>
                  <p><strong>Compositor:</strong> {cancion.compositor}</p>
                  <div className="d-grid">
                    <button onClick={handleEliminar} className="btn btn-danger">
                      Eliminar Canción
                    </button>
                  </div>
                </div>
              )}

              {/* Mensaje de éxito al eliminar */}
              {eliminado && (
                <div className="alert alert-success mt-3" role="alert">
                  Canción eliminada correctamente.
                </div>
              )}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default EliminarCancion;
