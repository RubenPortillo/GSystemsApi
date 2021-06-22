# GSystemsApi
Servicio Rest para la gestión de las incidencias de los empleados.

## Cofiguración
No se requiere configuración previa.

## Ejecución
Para poder ejecutar la aplicación solo será necesario descargar la solución y levantar un IISExpress desde Visual Studio.
La aplicación estará en el puerto 44393.

También se puede levantar con Docker desde el propio Visual Studio.

## API

### EmpleadoLogin

El servicio está securizado bajo el estándar JWT.
Una vez logado se permitirá el acceso al resto del Api.

- Obtención del toque JWT:

POST /api/empleadologin/authenticate

- Parámetros:
  - mail: mail del usuario registrado
  - password: contraseña del usuario registrado.
  
- Datos login test:
  - Usuario 1:
    - mail: jgonzalezp@empresa1.com
    - password: 1234
  - Usuario 2:
    - mail: jgutierrezf@empresa1.com
    - password: 1234
  - Usuario 3:
    - mail: jsanromanc@empresa1.com
    - password: 1234
    
- Peticiones a cualquier recurso

OPERACION /api/XXXXX 
  - token: Auth Bearer con el token
  
  
  Estructura del JSON:
```json
   {
      "mail":"jgutierrezf@empresa1.com",
      "password":"1234"
   }
 ``` 
  
### Empleado

Se trata de un CRUD para las operaciones de los empleados sobre el path 'api/empleados'

- POST '/api/empleados/'. Añade un nuevo Usuario
- DELETE '/api/empleados/{id}'. Elimina un usuario existente.
- PUT '/api/empleados/{id}'. Modifica un usuario existente.
- GET '/api/empleados/'. Obtiene todos los usuarios.
- GET '/api/empleados/{id}'. Obtiene el usuario filtrando por ID.

Estructura del JSON:
```json
   {
        "id": 1,
        "nombre": "Juan",
        "apellido1": "González",
        "apellido2": "Pérez",
        "mail": "jgonzalezp@empresa1.com",
        "empresaID": 1,
        "perfil": 0,
        "turno": 0
    }
 ``` 
### Empresa

Se trata de un CRUD para las operaciones de las empresas sobre el path '/api/empresa/'

- POST '/api/empresa/'. Añade una nueva empresa
- DELETE '/api/empresa/{id}'. Elimina una empresa existente.
- PUT '/api/empresa/{id}'. Modifica una empresa existente.
- GET '/api/empresa/'. Obtiene todas las empresas.
- GET '/api/empresa/{id}'. Obtiene una empresa filtrando por ID.

Estructura del JSON:
```json
    {
        "id": 1,
        "nombre": "Empresa1",
        "direccion": "Calle falsa 123",
        "activo": true,
        "fActivo": "2021-12-12T00:00:00"
    }
 ``` 

### Tareas


Se trata de un CRUD para las operaciones de las tareas sobre el path '/api/tareas/'

- POST '/api/tareas/'. Añade una nueva tarea
- DELETE '/api/tareas/{id}'. Elimina una tarea existente.
- PUT '/api/tareas/{id}'. Modifica una tarea existente.
- GET '/api/tareas/'. Obtiene todos las tareas.
- GET '/api/tareas/{id}'. Obtiene una tarea filtrando por ID.

Estructura del JSON:
```json
    {
        "id": 1,
        "descTarea": "Revisar llantas autobús 5248LMF",
        "duracion": "4h",
        "fTarea": "2021-06-20T00:00:00",
        "empleadoID": 1,
        "prioridad": 0
    }
```  
  
### Incidencias


Se trata de un CRUD para las operaciones de las empresas sobre el path '/api/incidencias/'

- POST '/api/incidencias/'. Añade una nueva incidencia
- DELETE '/api/incidencias/{id}'. Elimina una incidencia existente.
- PUT '//api/incidencias/{id}'. Modifica una incidencia existente.
- GET '/api/incidencias/'. Obtiene todos las incidencia.
- GET '/api/incidencias/{id}'. Obtiene una incidencia filtrando por ID.

Estructura del JSON:
```json
   {
        "id": 2,
        "incidenciaDesc": "No arranca el motor, fallo motor",
        "ubicacion": "Calle falsa 4556",
        "fIncidencia": "2021-06-20T00:00:00",
        "empleadoID": 2,
        "prioridad": 2
    }
  ``` 
    
## Swagger

La aplicación tiene configurado swagger, por lo que una vez levanta se abrirá la ventana que permitirá ver la estructura de la Api con todas las operaciones:


 ![alt text](https://github.com/RubenPortillo/GSystemsApi/blob/master/Properties/imgReader/swagger1.jpg)
 
 
 También se puede ver la estructura de las tablas desde Swagger:
 
 ![alt text](https://github.com/RubenPortillo/GSystemsApi/blob/master/Properties/imgReader/swagger2.jpg)
 
    
    
