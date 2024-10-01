# Sistema de Gestión de Eventos

## Descripción General
Sistema cliente-servidor para la gestión de eventos, específicamente conciertos, construido con Spring Boot (servidor) y .NET Windows Forms (cliente).

Este proyecto implementa un sistema CRUD para la gestión de eventos, con enfoque en conciertos. Sigue una arquitectura cliente-servidor:
- **Servidor**: Desarrollado con Spring Boot (Java)
- **Cliente**: Desarrollado usando .NET Windows Forms

### Características Principales
- Operaciones CRUD (Crear, Leer, Actualizar y Eliminar) para eventos tipo concierto
- Endpoints API RESTful para todas las operaciones CRUD
- Almacenamiento de datos en memoria
- Aplicación de escritorio como interfaz de usuario

## Stack Tecnológico

### Servidor
- **Framework**: Spring Boot
- **Dependencias**: 
  - Spring Web
  - Lombok

### Cliente
- **.NET Windows Forms**
- **RestSharp** para consumo de API
- **Newtonsoft.Json** para manejo de JSON

## Endpoints de la API

| Método | Endpoint | Descripción |
|--------|----------|-------------|
| POST | `/evento/concierto/add` | Agregar un nuevo concierto |
| GET | `/evento/concierto/buscar/id/{id}` | Buscar concierto por ID |
| GET | `/evento/concierto/buscar/nombre/{nombre}` | Buscar concierto por nombre |
| DELETE | `/evento/concierto/eliminar` | Eliminar un concierto |
| GET | `/evento/concierto/listar` | Listar todos los conciertos |
| GET | `/evento/concierto/listar/precio/{precioMin}` | Listar conciertos por precio minimo|
| PUT | `/evento/concierto/{id}` | Actualizar concierto por ID |

## Estructura del Proyecto

### Lado del Servidor

#### Controlador
La clase `ControladorEvento` maneja las peticiones HTTP y gestiona el enrutamiento de las operaciones relacionadas con eventos.

```java
@RestController
@RequestMapping("/evento/concierto")
public class ControladorEvento {
    @Autowired
    private ServicioEvento servicioEvento;
    
    // Implementación de endpoints...
}
```

#### Servicio
La clase `ServicioEvento` implementa la lógica de negocio para la gestión de eventos:
- Valida datos de conciertos
- Gestiona el almacenamiento en memoria de eventos
- Maneja operaciones CRUD

### Lado del Cliente

El cliente implementa una clase de servicio (`ServicioConcierto`) que:
- Se comunica con la API del servidor
- Maneja las respuestas de la API
- Gestiona actualizaciones de la UI basadas en las respuestas del servidor

## Modelo de Datos

### Concierto
La entidad principal gestionada por el sistema con atributos:
- ID
- Nombre
- Precio
- Fecha
- Artista

## Ejecutar el Proyecto

### Servidor
1. Asegúrese de tener Java 17 y Maven instalados
2. Navegue al directorio del servidor
3. Ejecute `mvn spring-boot:run`

### Cliente
1. Asegúrese de tener .NET Framework instalado
2. Abra la solución en Visual Studio
3. Compile y ejecute la aplicación Windows Forms

## Manejo de Errores

El sistema implementa un manejo de errores completo:
- Validación del lado del servidor con respuestas HTTP apropiadas
- Gestión de errores del lado del cliente con mensajes amigables para el usuario

## Autores
Laura Gomez & Sebastian Diaz
