﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConesaApp.Database.Data.Entities
{
    [Index(nameof(usuarioID), Name = "usuarioID_UQ", IsUnique = true)]
    public class Usuario
    {
        [Key] public int usuarioID { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public string contraseña { get; set; }
        public List<Pagos>? Pagos { get; set; }
    }
}
