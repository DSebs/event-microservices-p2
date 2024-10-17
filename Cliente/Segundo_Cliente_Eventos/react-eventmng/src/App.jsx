// src/App.jsx
import React from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import { Navbar, Nav, NavDropdown, Container } from 'react-bootstrap';  // Corrige las importaciones de React-Bootstrap
import AgregarConcierto from './components/concierto/AgregarConcierto';
import BuscarConciertoId from './components/concierto/BuscarConciertoId';
import BuscarConciertoNombre from './components/concierto/BuscarConciertoNombre';
import ActualizarConcierto from './components/concierto/ActualizarConcierto';
import EliminarConcierto from './components/concierto/EliminarConcierto';
import ListarConciertos from './components/concierto/ListarConcierto';

function App() {
  return (
    <Router>
      <Navbar bg="light" expand="lg">
        <Container>
          <Navbar.Brand as={Link} to="/">EventManagement</Navbar.Brand>
          <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav">
            <Nav className="me-auto">
              {/* Dropdown para Concierto */}
              <NavDropdown title="Concierto" id="concierto-dropdown">
                <NavDropdown.Item as={Link} to="/agregar-concierto">Agregar Concierto</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/buscar-concierto-id">Buscar Concierto Por ID</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/buscar-concierto-nombre">Buscar Concierto Por Nombre</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/actualizar-concierto">Actualizar Concierto</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/eliminar-concierto">Eliminar Concierto</NavDropdown.Item>
                <NavDropdown.Item as={Link} to="/listar-concierto">Listar Conciertos</NavDropdown.Item>
              </NavDropdown>
            </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>

      <Container className="mt-5">
        <Routes>
          {/* Rutas para Concierto */}
          <Route path="/agregar-concierto" element={<AgregarConcierto />} />
          <Route path="/buscar-concierto-id" element={<BuscarConciertoId />} />
          <Route path="/buscar-concierto-nombre" element={<BuscarConciertoNombre />} />
          <Route path="/actualizar-concierto" element={<ActualizarConcierto />} />
          <Route path="/eliminar-concierto" element={<EliminarConcierto />} />
          <Route path="/listar-concierto" element={<ListarConciertos />} />
        </Routes>
      </Container>
    </Router>
  );
}

export default App;
