import React, { useState } from 'react';
import { buscarConciertoPorNombre } from '../../services/conciertoService';


const BuscarConciertoNombre = () => {
  const [nombre, setNombre] = useState('');
  const [concierto, setConcierto] = useState(null);

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const resultado = await buscarConciertoPorNombre(nombre);
      setConcierto(resultado);
    } catch (error) {
      alert('Error al buscar concierto: ' + error.message);
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6">
          <div className="card">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Buscar Concierto por Nombre</h2>
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
              {concierto && (
                <div className="mt-4">
                  <h3>Resultado:</h3>
                  <p>ID: {concierto.id}</p>
                  <p>Nombre: {concierto.nombre}</p>
                  <p>Precio: {concierto.precio}</p>
                  <p>Fecha: {new Date(concierto.fecha).toLocaleString()}</p>
                  <p>Artista: {concierto.artista}</p>
                  <p>Canciones: {concierto.cancionesIds.join(', ')}</p>
                </div>
              )}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default BuscarConciertoNombre;
