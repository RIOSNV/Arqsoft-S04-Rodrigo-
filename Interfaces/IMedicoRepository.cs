using CITAS_APP.Models;
namespace CITAS_APP.Interfaces
{
        public interface IMedicoRepository
        {
            List<Medico> ObtenerTodos();
            Medico? ObtenerPorId(int id);
        }
    }

