using System.Text.Json;

namespace SistemaContratos.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public JsonElement roles { get; set; }
    }
}
