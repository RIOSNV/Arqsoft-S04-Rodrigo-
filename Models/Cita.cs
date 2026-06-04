namespace CITAS_APP.Models
{
    public class Cita
    {
        public string id { get; set; }
        public string PacienteId { get; set; }
        public string MedicoId { get; set; }
        DateOnly fecha { get; set; }
        TimeOnly Hora { get; set; } 
        public string motivo { get; set; } 
        public string estado { get; set; }
    }
}
