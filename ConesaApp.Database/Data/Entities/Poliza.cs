using Microsoft.EntityFrameworkCore;

namespace ConesaApp.Database.Data.Entities
{
    [Index(nameof(PolizaID), Name = "polizaID_UQ", IsUnique = true)]
    public class Poliza
    {
        public int PolizaID { get; set; }
        public int NroPoliza { get; set; }
        public bool Actualizado { get; set; }
        public decimal ValorAsegurado { get; set; }
        public DateTime InicioVigencia { get; set; }
        public DateTime FinVigencia { get; set; }
        public decimal ValorCuota { get; set; }
        public int EmpresaID { get; set; }
        public int CoberturaID { get; set; }
        public List<Pagos> Pagos { get; set; }
        public Vehiculo Vehiculo { get; set; }
    }
}
