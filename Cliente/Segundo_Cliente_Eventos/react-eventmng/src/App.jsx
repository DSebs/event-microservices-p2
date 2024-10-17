// src/App.jsx
import React from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import { Navbar, Nav, NavDropdown, Container } from 'react-bootstrap';  
import Home from './components/home/Home';
import AgregarConcierto from './components/concierto/AgregarConcierto';
import BuscarConciertoId from './components/concierto/BuscarConciertoId';
import BuscarConciertoNombre from './components/concierto/BuscarConciertoNombre';
import ActualizarConcierto from './components/concierto/ActualizarConcierto';
import EliminarConcierto from './components/concierto/EliminarConcierto';
import ListarConciertos from './components/concierto/ListarConcierto';
import AgregarCancion from './components/cancion/AgregarCancion';
import BuscarCancionID from './components/cancion/BuscarCancionId';
import BuscarCancionNombre from './components/cancion/BuscarCancionNombre';
import ActualizarCancion from './components/cancion/ActualizarCancion';
import EliminarCancion from './components/cancion/EliminarCancion';
import ListarCanciones from './components/cancion/ListaCancion';
import AcercaDe from './components/ayuda/AcercaDe';

function App() {
  return (
    <Router>
      <Navbar bg="light" expand="lg">
        <Container>
          <Navbar.Brand as={Link} to="/">EventManagement</Navbar.Brand>
          <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav">
            <Nav className="me-auto">
              <NavDropdown title="Concierto" id="concierto-dropdown">
                <NavDropdown.Item as={Link} to="/agregar-concierto">Agregar Concierto</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/buscar-concierto-id">Buscar Concierto Por ID</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/buscar-concierto-nombre">Buscar Concierto Por Nombre</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/actualizar-concierto">Actualizar Concierto</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/eliminar-concierto">Eliminar Concierto</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/listar-concierto">Listar Conciertos</NavDropdown.Item>
              </NavDropdown>
              <NavDropdown title="Canción" id="cancion-dropdown">
                <NavDropdown.Item as={Link} to="/agregar-cancion">Agregar Canción</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/buscar-cancion-id">Buscar Canción Por ID</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/buscar-cancion-nombre">Buscar Canción Por Nombre</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/actualizar-cancion">Actualizar Canción</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/eliminar-cancion">Eliminar Canción</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/listar-cancion">Listar Canciones</NavDropdown.Item>
              </NavDropdown>
              <NavDropdown title="Ayuda" id="ayuda-dropdown">
                <NavDropdown.Item as={Link} to="/acerca-de">Acerca de ...</NavDropdown.Item>
              </NavDropdown>
            </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>

      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/agregar-concierto" element={<AgregarConcierto />} />
        <Route path="/buscar-concierto-id" element={<BuscarConciertoId />} />
        <Route path="/buscar-concierto-nombre" element={<BuscarConciertoNombre />} />
        <Route path="/actualizar-concierto" element={<ActualizarConcierto />} />
        <Route path="/eliminar-concierto" element={<EliminarConcierto />} />
        <Route path="/listar-concierto" element={<ListarConciertos />} />
        <Route path="/agregar-cancion" element={<AgregarCancion />} />
        <Route path="/buscar-cancion-id" element={<BuscarCancionID />} />
        <Route path="/buscar-cancion-nombre" element={<BuscarCancionNombre />} />
        <Route path="/actualizar-cancion" element={<ActualizarCancion />} />
        <Route path="/eliminar-cancion" element={<EliminarCancion />} />
        <Route path="/listar-cancion" element={<ListarCanciones />} />
        <Route path="/acerca-de" element={<AcercaDe />} />
      </Routes>
    </Router>
  );
}

export default App;