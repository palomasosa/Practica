﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConesaApp.Database.Data.Entities
{
    [Index(nameof(metodoPagoID), Name = "metodoPagoID_UQ", IsUnique = true)]
    public class MetodoPago
    {
        [Key] public int metodoPagoID { get; set; }
        public string metodo { get; set; }
        public ICollection<Pagos>? Pagos { get; set; }
    }
}
