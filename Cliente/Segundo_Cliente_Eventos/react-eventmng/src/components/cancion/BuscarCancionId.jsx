import React, { useState } from 'react';
import { buscarCancionPorId } from '../../services/cancionService';

const BuscarCancionID = () => {
  const [id, setId] = useState('');
  const [cancion, setCancion] = useState(null);

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const resultado = await buscarCancionPorId(id);
      setCancion(resultado);
    } catch (error) {
      alert('Error al buscar canción: ' + error.message);
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6">
          <div className="card">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Buscar Canción por ID</h2>
              <form onSubmit={handleSubmit}>
                <div className="mb-3">
                  <input
                    type="number"
                    className="form-control"
                    value={id}
                    onChange={(e) => setId(e.target.value)}
                    placeholder="Digite el ID"
                    required
                  />
                </div>
                <div className="d-grid">
                  <button type="submit" className="btn btn-primary">Buscar</button>
                </div>
              </form>
              {cancion && (
                <div className="mt-4">
                  <h3>Resultado:</h3>
                  <p>ID: {cancion.id}</p>
                  <p>Nombre: {cancion.nombre}</p>
                  <p>Duración: {cancion.duracion} minutos</p>
                  <p>Fecha de Lanzamiento: {new Date(cancion.fechaLanzamiento).toLocaleDateString()}</p>
                  <p>Compositor: {cancion.compositor}</p>
                </div>
              )}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default BuscarCancionID;
