using CITAS_APP.Models;

namespace CITAS_APP.Interfaces
{
    public interface IPacienteRepository
    {
        List<Paciente> ObtenerTodos();
        Paciente? ObtenerPorId(int id);

        void Agregar(Paciente paciente);

        void Eliminar(int id);
    }
}
