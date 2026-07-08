\# Diagrama de Contenedores — App\_Citas



Este diagrama muestra los principales contenedores o partes internas del sistema App\_Citas.



```mermaid

flowchart TD

&#x20;   Usuario\["Usuario / Recepcionista"] --> Web\["App\_Citas.Web<br/>Interfaz MVC"]



&#x20;   Web --> Controllers\["Controllers"]

&#x20;   Controllers --> Application\["App\_Citas.Application<br/>Servicios de aplicación"]



&#x20;   Application --> Domain\["App\_Citas.Domain<br/>Entidades e interfaces"]

&#x20;   Application --> Infrastructure\["App\_Citas.Infrastructure<br/>Repositorios JSON"]



&#x20;   Infrastructure --> Data\["Archivos JSON<br/>pacientes.json<br/>medicos.json<br/>citas.json"]

```

