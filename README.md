<p align="center">
  <a href="" rel="noopener">
 <img width=200px height=200px src="https://i.imgur.com/6wj0hh6.jpg" alt="Project logo"></a>
</p>

<h3 align="center">Facultad APP</h3>

<div align="center">

[![Status](https://img.shields.io/badge/status-active-success.svg)]()
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](/LICENSE)

</div>

---

<p align="center"> Solución para gestionar una facultad con sus carreras, alumnos, materias y sus respectivas inscripciones
    <br> 
</p>

## 📝 Contenidos

- [Sobre el proyecto](#about)
- [Instrucciones](#getting_started)
- [API REST](#api_rest)
- [ReactJs Front TODO](#front_end)
- [Built Using](#built_using)
- [Authors](#authors)
- [Acknowledgments](#acknowledgement)

## 🧐 Sobre el proyecto <a name = "about"></a>

Solución para gestionar gestionar una facultad con sus carreras, alumnos, materias y sus respectivas inscripciones. La solución está compuesta por un proyecto ( para el back-end):
+ FacultadAppSvc: El back-end es una API REST web service creada usando .NET Core 2.1 que tiene a disponibilidad los distintos verbos que va a consumir el front-end. 


## 🏁 Instrucciones <a name = "getting_started"></a>

Estas instrucciones le proporcionarán una copia del proyecto en funcionamiento en su máquina local para fines de desarrollo y prueba. En el README.md no se abarca el deploy.

### Requisitos

Requesitos para instalar el software y cómo instalarlas.

```
+ Microsoft Visual Studio Community 2017 o superior
+ Microsoft SQL Server 2008 o superior
+ .NET Core 2.1
```

### Instalación

Pasos a seguir para ejecutar la solución:
1. Obtener el proyecto de git:

```
git clone https://github.com/paulofer85/FacultadApp.git
```
2. Abrir proyecto en VS2017 (o superior).
3. Setear como proyecto por default a FacultadAppSvc.
4. Ejecutar la solución y dejar ejecutandola.

Opcional: En el caso que quiera crear la base de datos sin utlizar code firts puede abrir ´MS SQL Server Management Studio´ y ejecutar el archivo 'FacultadAPP-Create.sql'



<!-- 6. Abrir una consola de comandos (cmd o pm) y ejecutar la solución de front-end:

```
C:\>cd \FacultadApp\FacultadApp\FacultadAppWeb\ClientApp
C:\FacultadApp\FacultadApp\FacultadAppWeb\ClientApp>npm start
``` -->

# API REST <a name = "api_rest"></a>

Los verbos disponibles son:
  - http://localhost:49791/api/alumnos : devuelve todos los TODO
  - http://localhost:49791/api/inscripciones (POST): crea un nuevo TODO
  - http://localhost:49791/api/materias
  - http://localhost:49791/api/carreras
  - http://localhost:49791/api/materiascarreras


## 🔧 Running the tests <a name = "tests"></a>

El proyecto FacultadAppSvcTest dentro de la solución realiza los siguientes test unitarios sobre la REST API:



## Test de la API REST via Postman

Se adjunta dentro de la solución un set de pruebas (FacultadApp.postman_collection.json) que pueden ser importados a Postman y ejecutados para probar cada uno de los verbos.


# ReactJs Front-end (TODO) <a name = "front_end"></a>

Para mas información por favor ver el README.md que se encuentra presente dentro de la carpeta del proyecto front-end \FacultadAppWeb\ClientApp.

## 🚀 Deployment <a name = "deployment"></a>

TODO

## ⛏️ Built Using <a name = "built_using"></a>

<!-- - [ReactJs](https://www.reactjs.org/) - Front-end -->
- [.NET Core](https://docs.microsoft.com/en-us/aspnet/core/) - Server API WEB Framework
<!-- - [NodeJs](https://nodejs.org/en/) - Server Environment -->

## ✍️ Authors <a name = "authors"></a>

- [@paulofer85](https://github.com/paulofer85) - Initial work
- [@Edrans] - Requerimientos

