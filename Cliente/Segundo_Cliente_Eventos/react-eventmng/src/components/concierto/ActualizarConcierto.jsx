import React, { useState } from 'react';
import { actualizarConcierto, buscarConciertoPorId } from '../../services/conciertoService';

const ActualizarConcierto = () => {
  const [id, setId] = useState('');
  const [concierto, setConcierto] = useState({
    nombre: '',
    precio: '',
    fecha: '',
    artista: '',
    cancionesIds: ''
  });

  const buscarConcierto = async () => {
    try {
      const conciertoEncontrado = await buscarConciertoPorId(id);
      setConcierto({
        ...conciertoEncontrado,
        cancionesIds: conciertoEncontrado.cancionesIds.join(',') || ''
      });
    } catch (error) {
      console.error('Error al buscar el concierto:', error);
      alert('Error al buscar el concierto');
    }
  };

  const handleChange = (e) => {
    const { name, value } = e.target;
    setConcierto(prev => ({ ...prev, [name]: value }));
  };

  const handleCancionesIdsChange = (e) => {
    const { value } = e.target;
    setConcierto(prev => ({ ...prev, cancionesIds: value }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    const tieneSegundos = concierto.fecha.split(":").length === 3;
    const fechaAjustada = tieneSegundos ? concierto.fecha : concierto.fecha + ":00";
    
    // Convertir cancionesIds a array de números, permitiendo array vacío
    const cancionesIdsArray = concierto.cancionesIds.trim() !== '' 
      ? concierto.cancionesIds.split(',')
          .map(id => id.trim())
          .filter(id => id !== '')
          .map(Number)
          .filter(id => !isNaN(id))
      : [];

    const conciertoAjustado = { 
      ...concierto, 
      fecha: fechaAjustada,
      cancionesIds: cancionesIdsArray
    };

    try {
      await actualizarConcierto(id, conciertoAjustado);
      alert('Concierto actualizado exitosamente');
    } catch (error) {
      alert('Error al actualizar concierto: ' + error.message);
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6">
          <div className="card">
            <div className="card-body">
              <h2 className="card-title text-center mb-4">Actualizar Concierto</h2>
              <div className="mb-3">
                <input
                  type="number"
                  className="form-control"
                  value={id}
                  onChange={(e) => setId(e.target.value)}
                  placeholder="ID del concierto"
                />
                <button className="btn btn-secondary mt-2" onClick={buscarConcierto}>Buscar Concierto</button>
              </div>
              <form onSubmit={handleSubmit}>
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
                    onChange={handleCancionesIdsChange}
                    placeholder="IDs de canciones (separados por coma)"
                  />
                </div>
                <div className="d-grid">
                  <button type="submit" className="btn btn-primary">Actualizar</button>
                </div>
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ActualizarConcierto;
