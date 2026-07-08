\# Diagrama de Contexto — App\_Citas



Este diagrama muestra la relación principal entre el usuario y el sistema App\_Citas.



```mermaid

flowchart TD

&#x20;   Usuario\["Usuario / Recepcionista"] --> Sistema\["App\_Citas<br/>Sistema de gestión de citas médicas"]



&#x20;   Sistema --> Pacientes\["Gestión de pacientes"]

&#x20;   Sistema --> Medicos\["Gestión de médicos"]

&#x20;   Sistema --> Citas\["Gestión de citas"]



&#x20;   Pacientes --> Datos\["Archivos JSON"]

&#x20;   Medicos --> Datos

&#x20;   Citas --> Datos

```

