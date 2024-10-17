import React, { useState } from 'react';
import { buscarCancionPorNombre } from '../../services/cancionService';

const BuscarCancionNombre = () => {
  const [nombre, setNombre] = useState('');
  const [cancion, setCancion] = useState(null);

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const resultado = await buscarCancionPorNombre(nombre);
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
              <h2 className="card-title text-center mb-4">Buscar Canción por Nombre</h2>
              <form onSubmit={handleSubmit}>
                <div className="mb-3">
                  <input
                    type="text"
                    className="form-control"
                    value={nombre}
                    onChange={(e) => setNombre(e.target.value)}
                    placeholder="Digite el Nombre"
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

export default BuscarCancionNombre;
