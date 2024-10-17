import React, { useState } from 'react';
import { listarCanciones, listarCancionesMin } from '../../services/cancionService';

const ListarCanciones = () => {
  const [canciones, setCanciones] = useState([]);
  const [duracionMin, setDuracionMin] = useState('');
  const [error, setError] = useState('');

  // Manejador para listar todas las canciones
  const handleListar = async () => {
    try {
      const resultado = await listarCanciones();
      setCanciones(resultado);
      setError(''); // Reinicia el estado de error
    } catch (error) {
      setError('Error al listar canciones: ' + error.message);
    }
  };

  // Manejador para filtrar canciones por duración mínima
  const handleFiltrar = async (e) => {
    e.preventDefault();
    try {
      const resultado = await listarCancionesMin(duracionMin);
      setCanciones(resultado);
      setError(''); // Reinicia el estado de error
    } catch (error) {
      setError('Error al filtrar canciones: ' + error.message);
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-8">
          <div className="card">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Listar Canciones</h2>

              {/* Botón para listar todas las canciones */}
              <div className="d-grid mb-3">
                <button onClick={handleListar} className="btn btn-primary">
                  Listar Todas las Canciones
                </button>
              </div>

              {/* Sección para filtrar por duración mínima */}
              <form onSubmit={handleFiltrar} className="mb-4">
                <div className="input-group">
                  <input
                    type="number"
                    className="form-control"
                    value={duracionMin}
                    onChange={(e) => setDuracionMin(e.target.value)}
                    placeholder="Duración mínima (minutos)"
                    required
                  />
                  <button type="submit" className="btn btn-secondary">
                    Filtrar
                  </button>
                </div>
              </form>

              {/* Mensaje de error si ocurre algún problema */}
              {error && (
                <div className="alert alert-danger" role="alert">
                  {error}
                </div>
              )}

              {/* Tabla para mostrar las canciones */}
              {canciones.length > 0 && (
                <table className="table table-striped mt-4">
                  <thead>
                    <tr>
                      <th>ID</th>
                      <th>Nombre</th>
                      <th>Duración (minutos)</th>
                      <th>Fecha de Lanzamiento</th>
                      <th>Compositor</th>
                    </tr>
                  </thead>
                  <tbody>
                    {canciones.map((cancion) => (
                      <tr key={cancion.id}>
                        <td>{cancion.id}</td>
                        <td>{cancion.nombre}</td>
                        <td>{cancion.duracion}</td>
                        <td>{new Date(cancion.fechaLanzamiento).toLocaleDateString()}</td>
                        <td>{cancion.compositor}</td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              )}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ListarCanciones;
