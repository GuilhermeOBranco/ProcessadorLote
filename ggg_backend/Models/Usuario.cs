using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ggg_backend.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int funcional { get; set; }
        public string racf { get; set; }
        public int area { get; set; }
        public int tipoLogin { get; set; }
    }
}