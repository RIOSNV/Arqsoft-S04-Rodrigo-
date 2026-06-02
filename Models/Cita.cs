namespace CITAS_APP.Models
{
    public class Cita
    {
        public string id;
        public string PacienteId;
        public string MedicoId;
        DateOnly fecha;
        TimeOnly Hora;
        public string motivo;
        public string estado;
    }
}
