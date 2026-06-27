# App_Citas
##Repositorio del proyecto:https://github.com/Crisdan1505/Arq-Soft05-Cristopher.git

#### Cómo ejecutar el proyecto

1. Clonar el repositorio:

```bash
git clone https://github.com/usuario/App_Citas.git
```

2. Abrir la solución `App_Citas.sln` en Visual Studio.

3. Restaurar los paquetes NuGet.

4. Ejecutar el proyecto `App_Citas.Web`.

## Arquitectura del proyecto

El proyecto **App_Citas** fue reorganizado utilizando una estructura basada en arquitectura hexagonal, con el objetivo de separar responsabilidades y mantener un código más limpio, ordenado y fácil de mantener.

La estructura principal del proyecto se divide en las siguientes capas:

* **Domain**: contiene las entidades principales del sistema, como `Paciente`, `Medico` y `Cita`, además de los puertos o interfaces que definen las operaciones necesarias.
* **Application**: contiene los servicios de aplicación, encargados de manejar la lógica principal entre los controladores y los repositorios.
* **Infrastructure**: contiene la implementación de los repositorios y la gestión de los datos.
* **Presentation**: contiene los controladores y las vistas que permiten la interacción con el usuario.
* **wwwroot**: contiene los archivos estáticos del proyecto, como CSS, JavaScript e imágenes.

## Funcionalidades principales

La aplicación permite administrar información básica de una clínica mediante las siguientes secciones:

* Registro, consulta, edición y eliminación de pacientes.
* Registro, consulta, edición y eliminación de médicos.
* Gestión de citas médicas.
* Consulta de citas por paciente.
* Navegación mediante un menú desplegable.
* Interfaz personalizada con estilos, colores y animaciones.

## Tecnologías utilizadas

* ASP.NET Core MVC
* C#
* Razor Views
* Bootstrap
* CSS personalizado
* Arquitectura hexagonal
* Inyección de dependencias

## Información académica

Este proyecto fue desarrollado por **Cristopher Maximiliano Euan Pool**, estudiante de tercer cuatrimestre en el **Tecnológico De Software**, como parte de una práctica académica guiada por el profesor **Javier Pedrozo Romero**.

## Objetivo del proyecto

El objetivo principal de esta aplicación es demostrar la creación de un sistema web funcional para la gestión de citas médicas, aplicando buenas prácticas de organización de código, separación de capas, uso de controladores, vistas, servicios, repositorios e interfaces.

## Capturas de la app funcionando
1.<img width="1915" height="1017" alt="image" src="https://github.com/user-attachments/assets/c9e7734c-ad78-4339-bb08-45ba748818e1" />
2.<img width="1901" height="1018" alt="image" src="https://github.com/user-attachments/assets/f284307b-403f-48f2-8239-f0d5cf7b8edd" />
3.<img width="1893" height="1013" alt="image" src="https://github.com/user-attachments/assets/b279c15b-06ac-4335-90dc-34639f06792f" />
4.<img width="1895" height="918" alt="image" src="https://github.com/user-attachments/assets/f664e296-1133-4368-98b1-f54d0d848ef0" />
5.<img width="1893" height="922" alt="image" src="https://github.com/user-attachments/assets/19f71870-3ab7-4c52-8824-9242b7d6b916" />
Calculadora.
1.<img width="1907" height="1012" alt="image" src="https://github.com/user-attachments/assets/2a56c4e5-7006-481d-b5bd-6ca609b3ce05" />




## Declaración de uso de IA

Durante el desarrollo de este proyecto se utilizó inteligencia artificial como herramienta de apoyo para orientar la organización del código, mejorar la estructura del proyecto, corregir errores de compilación, ajustar rutas, documentar cambios y proponer mejoras visuales en la interfaz.

La IA fue utilizada únicamente como apoyo técnico y de aprendizaje. Las decisiones finales, la implementación, las pruebas, la adaptación del código y la integración dentro del proyecto fueron realizadas y revisadas por el estudiante.

Este proyecto conserva un propósito académico y refleja el proceso de aprendizaje sobre ASP.NET Core MVC, arquitectura hexagonal, separación de capas, controladores, vistas, servicios, repositorios e inyección de dependencias.

