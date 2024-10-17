import axios from 'axios';

const API_URL = 'http://localhost:8090/cancion';

export const agregarCancion = async (cancion) => {
  const response = await axios.post(`${API_URL}/add`, cancion);
  return response.data;
};

export const buscarCancionPorId = async (id) => {
  const response = await axios.get(`${API_URL}/buscar/id/${id}`);
  return response.data;
};

export const buscarCancionPorNombre = async (nombre) => {
  const response = await axios.get(`${API_URL}/buscar/nombre/${nombre}`);
  return response.data;
};

export const actualizarCancion = async (id, cancion) => {
  const response = await axios.put(`${API_URL}/${id}`, cancion);
  return response.data;
};

export const eliminarCancion = async (cancion) => {
    await axios.delete(`${API_URL}/eliminar`, { data: cancion });
  };

export const listarCanciones = async () => {
  const response = await axios.get(`${API_URL}/listar`);
  return response.data;
};

export const listarCancionesMin = async (duracionMin) => {
  const response = await axios.get(`${API_URL}/listar/duracion/${duracionMin}`);
  return response.data;
};