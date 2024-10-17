import React, { useState } from 'react';
import { listarConciertos, listarConciertosMin } from '../../services/conciertoService';

const ListarConciertos = () => {
  const [conciertos, setConciertos] = useState([]);
  const [precioMin, setPrecioMin] = useState('');
  const [error, setError] = useState('');

  // Manejador para listar todos los conciertos
  const handleListar = async () => {
    try {
      const resultado = await listarConciertos();
      setConciertos(resultado);
      setError(''); // Reinicia el estado de error
    } catch (error) {
      setError('Error al listar conciertos: ' + error.message);
    }
  };

  // Manejador para filtrar conciertos por precio mínimo
  const handleFiltrar = async (e) => {
    e.preventDefault();
    try {
      const resultado = await listarConciertosMin(precioMin);
      setConciertos(resultado);
      setError(''); // Reinicia el estado de error
    } catch (error) {
      setError('Error al filtrar conciertos: ' + error.message);
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-8">
          <div className="card">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Listar Conciertos</h2>

              {/* Botón para listar todos los conciertos */}
              <div className="d-grid mb-3">
                <button onClick={handleListar} className="btn btn-primary">
                  Listar Todos los Conciertos
                </button>
              </div>

              {/* Sección para filtrar por precio mínimo */}
              <form onSubmit={handleFiltrar} className="mb-4">
                <div className="input-group">
                  <input
                    type="number"
                    className="form-control"
                    value={precioMin}
                    onChange={(e) => setPrecioMin(e.target.value)}
                    placeholder="Precio mínimo"
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

              {/* Tabla para mostrar los conciertos */}
              {conciertos.length > 0 && (
                <table className="table table-striped mt-4">
                  <thead>
                    <tr>
                      <th>ID</th>
                      <th>Nombre</th>
                      <th>Precio</th>
                      <th>Fecha</th>
                      <th>Artista</th>
                      <th>IDs de Canciones</th> {/* Nueva columna para los IDs de las canciones */}
                    </tr>
                  </thead>
                  <tbody>
                    {conciertos.map((concierto) => (
                      <tr key={concierto.id}>
                        <td>{concierto.id}</td>
                        <td>{concierto.nombre}</td>
                        <td>{concierto.precio}</td>
                        <td>{new Date(concierto.fecha).toLocaleString()}</td>
                        <td>{concierto.artista}</td>
                        <td>{concierto.cancionesIds ? concierto.cancionesIds.join(', ') : 'Sin IDs de Canciones'}</td>
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

export default ListarConciertos;
