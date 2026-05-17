# SakilaApp

Este proyecto es una aplicación web ASP.NET Core MVC que utiliza la base de datos de ejemplo **Sakila**.

## Estructura del Proyecto

- **Controllers**: Contiene los controladores de la aplicación (`FilmsController`, `HomeController`).
- **Models**: Contiene las clases de datos (`Actor`, `Film`, `FilmActor`).
- **Views**: Contiene las vistas de la interfaz de usuario organizadas por controlador.
- **wwwroot**: Archivos estáticos como CSS, JavaScript y librerías de terceros (Bootstrap, jQuery).

## Requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) o superior.
- Una instancia de base de datos compatible (MySQL/SQL Server según configuración).

## Configuración

Asegúrate de configurar la cadena de conexión en el archivo `appsettings.json` o `appsettings.Development.json`.

## Cómo Ejecutar

Para ejecutar la aplicación localmente, abre una terminal en la raíz del proyecto y ejecuta:

```bash
dotnet run
```

Luego, abre tu navegador en `http://localhost:5000` (o el puerto configurado).

## Características

- Gestión de películas (Listado, Creación, Detalles).
- Arquitectura MVC limpia.
- Integración con base de datos Sakila.
