# ClinicaGestion

Sistema web de gestión de pacientes desarrollado con **ASP.NET Core MVC**, **C#** y **Entity Framework Core**.

El proyecto permite administrar la información de pacientes mediante una aplicación web con operaciones CRUD (Crear, Consultar, Actualizar y Eliminar).

## Tecnologías utilizadas

- C#
- ASP.NET Core MVC
- Entity Framework Core
- SQLite
- HTML5
- CSS3
- JavaScript
- Bootstrap

## Funcionalidades

- Registro de pacientes.
- Consulta y listado de pacientes.
- Visualización de detalles de cada paciente.
- Edición de información.
- Eliminación de registros.
- Persistencia de datos mediante SQLite.

## Requisitos

- .NET 10 SDK
- Visual Studio 2022 o Visual Studio Code (opcional).
- Git (opcional).

## Instalación y ejecución

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/Farma23/ClinicaGestion.git
   ```

2. Entrar en la carpeta:

   ```bash
   cd ClinicaGestion
   ```

3. Restaurar las dependencias:

   ```bash
   dotnet restore
   ```

4. Ejecutar la aplicación:

   ```bash
   dotnet run
   ```

5. Abrir en el navegador la dirección local indicada por la terminal.

## Base de datos

El proyecto utiliza SQLite con Entity Framework Core para gestionar la información.

La base de datos local se genera mediante la configuración de la aplicación. Los archivos de base de datos locales están excluidos del repositorio mediante `.gitignore`.

## Autor

**Farma23**

GitHub: [Farma23](https://github.com/Farma23)
