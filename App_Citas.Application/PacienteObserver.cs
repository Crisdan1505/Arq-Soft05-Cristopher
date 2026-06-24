using App_Citas.Domain;

namespace App_Citas.Application
{
    public class PacienteObserver
    {
        public void Notificar(Paciente paciente)
        {
            Console.WriteLine(
                $"[Observer] Notificación enviada al paciente: {paciente.Nombre}"
            );
        }
    }
}