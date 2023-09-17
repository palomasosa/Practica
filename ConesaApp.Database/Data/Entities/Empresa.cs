using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConesaApp.Database.Data.Entities
{
    [Index(nameof(empresaID), Name = "empresaID_UQ", IsUnique = true)]
    public class Empresa
    {
        [Key] public int empresaID { get; set; }
        public string nombre { get; set; }
        public ICollection<Poliza>? Polizas { get; set; }
    }
}
