import React, { useState } from 'react';
import { agregarConcierto } from '../../services/conciertoService';
import './AgregarConcierto.css'; 

const AgregarConcierto = () => {
  const [concierto, setConcierto] = useState({
    id: '',
    nombre: '',
    precio: '',
    fecha: '',
    artista: '',
    cancionesIds: []
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setConcierto(prev => ({ ...prev, [name]: value }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    const fechaAjustada = concierto.fecha.includes(":") ? concierto.fecha + ":00" : concierto.fecha;
    const conciertoAjustado = { ...concierto, fecha: fechaAjustada };
  
    try {
      await agregarConcierto(conciertoAjustado);
      alert('Concierto agregado exitosamente');
    } catch (error) {
      alert('Error al agregar concierto: ' + error.message);
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6">
          <div className="card">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Agregar Concierto</h2>
              <form onSubmit={handleSubmit}>
                <div className="mb-3">
                  <input
                    type="number"
                    className="form-control"
                    name="id"
                    value={concierto.id}
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
                    value={concierto.nombre}
                    onChange={handleChange}
                    placeholder="Nombre"
                    required
                  />
                </div>
                <div className="mb-3">
                  <input
                    type="number"
                    className="form-control"
                    name="precio"
                    value={concierto.precio}
                    onChange={handleChange}
                    placeholder="Precio"
                    required
                  />
                </div>
                <div className="mb-3">
                  <input
                    type="datetime-local"
                    className="form-control"
                    name="fecha"
                    value={concierto.fecha}
                    onChange={handleChange}
                    required
                  />
                </div>
                <div className="mb-3">
                  <input
                    type="text"
                    className="form-control"
                    name="artista"
                    value={concierto.artista}
                    onChange={handleChange}
                    placeholder="Artista"
                    required
                  />
                </div>
                <div className="mb-3">
                  <input
                    type="text"
                    className="form-control"
                    name="cancionesIds"
                    value={concierto.cancionesIds}
                    onChange={(e) => setConcierto(prev => ({ ...prev, cancionesIds: e.target.value.split(',').map(Number) }))}
                    placeholder="IDs de canciones (separados por coma)"
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

export default AgregarConcierto;