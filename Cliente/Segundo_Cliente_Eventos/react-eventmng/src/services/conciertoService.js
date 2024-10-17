// src/services/conciertoService.js
import axios from 'axios';

const API_URL = 'http://localhost:8090/evento/concierto';

export const agregarConcierto = async (concierto) => {
  const response = await axios.post(`${API_URL}/add`, concierto);
  return response.data;
};

export const buscarConciertoPorId = async (id) => {
  const response = await axios.get(`${API_URL}/buscar/id/${id}`);
  return response.data;
};

export const buscarConciertoPorNombre = async (nombre) => {
  const response = await axios.get(`${API_URL}/buscar/nombre/${nombre}`);
  return response.data;
};

export const actualizarConcierto = async (id, concierto) => {
  const response = await axios.put(`${API_URL}/${id}`, concierto);
  return response.data;
};

export const eliminarConcierto = async (id) => {
  await axios.delete(`${API_URL}/eliminar/${id}`);
};

export const listarConciertos = async () => {
  const response = await axios.get(`${API_URL}/listar`);
  return response.data;
};

export const listarConciertosMin = async (precioMin) => {
  const response = await axios.get(`${API_URL}/listar/precio/${precioMin}`);
  return response.data;
};