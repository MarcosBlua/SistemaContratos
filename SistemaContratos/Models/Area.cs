using System.Data.SqlTypes;

namespace SistemaContratos.Models
{
    public class Area
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string estado { get; set; }
    }
}
