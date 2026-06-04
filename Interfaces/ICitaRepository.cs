using CITAS_APP.Models;

namespace CITAS_APP.Interfaces
{
  
        public interface ICitaRepository
        {
            List<Cita> ObtenerTodos();
            List<Cita> ObtenerPorPaciente(int pacienteId);
        }
    }