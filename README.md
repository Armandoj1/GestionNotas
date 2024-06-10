José Armando Rodríguez Tapia. Gestión de notas 

Cambios: 25/05/2024

-Conexión entre capas BLL, Entity, DAL y presentación. Ajuste de conexión de las tablas usando una tabla de insercción para los Estudiantes y Grados para facilitar la gestión, métodos de agregado, modificación 
y eliminación de un estudiantes y su debida asociación a un grado.

Cambios: 28/05/2024 
-Ajustes visuales y re ajuste de métodos papra la funcinalidad del entorno, ajuste de procedimientos en la base de datos y demás.

Cambios: 30/05/2024
-Creación de docentes, asignación de materias y creación de materias, re organización de las tablas para mejorar la organización, mejora en procedimientos y soluciones de bugs, casi terminado.

Cambios 3/05/2024 
Gestión de Estudiantes: 
 RF1: Registro de estudiantes con los siguientes datos: 
o Nombre completo 
o Identificación (ID) 
o Fecha de nacimiento 
o Dirección 
o Teléfono de contacto 
 RF2: Modificación de los datos de estudiantes. 
 RF3: Eliminación de estudiantes del sistema. 
 RF4: Búsqueda de estudiantes por nombre y/o ID. 
Gestión de Grados: 
 RF5: Registro de grados escolares (Sexto, Séptimo, Octavo, Noveno, 
Décimo, Once). 
 RF6: Asignación de estudiantes a grados específicos. 
 RF7: Visualización de la lista de estudiantes por grado. 
Gestión de Materias y Docentes: 
 RF8: Registro de materias con los siguientes datos: 
o Nombre de la materia 
o Docente encargado [Filtrar por el tipo de materia y su 
especialidad] 
 RF9: Asociación de materias a un grado específico. 
 RF10: Modificación y eliminación de materias. 

 RF22: Registro de estudiantes con los siguientes datos: 
o Nombre completo 
o Identificación (ID) 
o Fecha de nacimiento 
o Dirección 
o Especialidad [Si es de naturales, física, matemáticas]. 
o Teléfono de contacto 
 RF23: Modificación de los datos de docente. 
 RF24: Eliminación de docente del sistema [NO SE PUEDE 
ELIMINAR SI TIENE UNA MATERIA ASIGNADA]. 
 RF25: Búsqueda de DOCENTE por nombre y/o ID. 

-Todos los requerimientos anteriores terminados.

----------------Comenzado los requermientos faltantes 
Registro de Notas: 
 RF11: Ingreso de notas por materia para cada estudiante (Cada nota debe 
obtener una observación para el estudiante, esta debe ser tenida en cuenta 
la momento de imprimir el boletin). 
 RF12: Modificación y eliminación de notas (Solo aplica si NO se registro 
un periodo después, es decir si no se ha registrado nota del PERIDO 2 se 
puede modificar el PERIODO 1, una vez se registre nota en el PERIODO 
2 ya no se puede modificar la nota del PERIODO 1, si quiere hacerlo solo 
lo puede hacer el superusuario). 
 RF13: Consulta de notas por estudiante y materia. 
Reportes: 
 RF14: Generación de reportes de notas por estudiante, materia y grado. 
 RF15: Reportes de rendimiento por grado y materia [En Graficas y en 
PDF debe decir el mejor estudiante por salón y ordenarlos del mejor 
promedio al peor para seleccionar los puestos]. 
Gestión de Usuarios: 
 RF16: Registro de usuarios para docentes con capacidad de ingresar y 
modificar notas de las materias que imparten. 
 RF17: Registro de un superusuario (directivos) con permisos para 
administrar todo el sistema y acceso a todos los reportes y 
funcionalidades. 
 RF18: Login seguro para docentes y directivos (Deseable utilizar JWT 
para encriptar el inicio, si no es posible hacerlo normal). 
Generación de Boletines: 
 RF19: Los estudiantes pueden ingresar al sistema utilizando su cédula 
para generar un PDF de su boletín académico, el pdf debe ser envía via 
CORREO ELECTRONICO. 
 RF20: Los boletines incluirán la lista de materias, las notas obtenidas en 
cada periodo académico (Periodo 1, Periodo 2, Periodo 3, Periodo 4) y 
un promedio final, es decir el estudiante puede seleccionar entre imprimir 
el Primer, segundo, tercer o cuarto OJO: ESTO DEPENDE DEL 
PERIODO EL CUAL TENGA REGISTRADO NOTAS, SI NO SE HA 
REGISTRADO NOTAS PARA EL PERIODO X EN SU TOTALIDAD 
NO SE PUEDE IMPRIMIR, TODAS LAS MATERIAS DEBEN 
TENER SU NOTA PARA PODER IMPRIMIR. 
 RF21: Funcionalidad para imprimir, descargar y enviar el boletín en 
formato PDF. 

Fecha 10/06/2024------------------------------
Agregación de boletines e impresión, faltan validaciones pero está en fase final 

