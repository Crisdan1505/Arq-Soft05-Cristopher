using App_Citas.Domain;

namespace App_Citas.Application
{
    public static class PacienteFactory
    {
        public static Paciente Crear(Paciente paciente)
        {
            Console.WriteLine($"[Factory] Paciente creado: {paciente.Nombre}");
            return paciente;
        }
    }
}