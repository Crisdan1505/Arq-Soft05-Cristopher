\# Diagrama de Arquitectura Hexagonal — App\_Citas



Este diagrama representa la separación entre la capa externa, la aplicación, el dominio y la infraestructura.



```mermaid

flowchart TD

&#x20;   Usuario\["Usuario"] --> Web\["App\_Citas.Web - MVC Razor Views"]



&#x20;   Web --> Application\["App\_Citas.Application - Casos de uso y servicios"]



&#x20;   Application --> Domain\["App\_Citas.Domain - Entidades y puertos"]



&#x20;   Application --> Ports\["Interfaces y puertos"]

&#x20;   Ports --> Infrastructure\["App\_Citas.Infrastructure - Adaptadores y repositorios"]



&#x20;   Infrastructure --> JSON\["Archivos JSON - Persistencia local"]



&#x20;   Domain --> Paciente\["Paciente"]

&#x20;   Domain --> Medico\["Medico"]

&#x20;   Domain --> Cita\["Cita"]

```

