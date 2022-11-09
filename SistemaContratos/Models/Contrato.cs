namespace SistemaContratos.Models
{
    public class Contrato
    {
        public int id { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public DateTime fecha_contrato { get; set; }
        public DateTime fecha_dictamen { get; set; }
        public string tareas { get; set; }
        public string remuneracion { get; set; }
        public string financiamiento_especial { get; set; }
        public string estado { get; set; }
        public DateTime fecha_inactividad { get; set; }
        public string motivo_baja { get; set; }
        public int paso { get; set; }
        public int persona_id { get; set; }
        public int estado_contrato_id { get; set; }
        public int area_id { get; set; }
        public string retribucion { get; set; }
        public string sujeto_a { get; set; }
        public int traslado { get; set; }
        public string nro_expediente { get; set; }
        public string pagaderos { get; set; }
        public string nro_resolucion { get; set; }
        public string ejercicio { get; set; }
        public string grupo_presupuestario { get; set; }
        public string unidad_presupuestaria { get; set; }
        public string subunidad_presupuestaria { get; set; }
        public string fuente { get; set; }
    }
}
