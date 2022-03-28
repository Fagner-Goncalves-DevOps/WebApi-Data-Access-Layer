using System;
using System.Collections.Generic;
using System.Text;

namespace DashTelecom.Domain.Models
{
    public class CustoServidor : Entity
    {
        public string Servidor { get; set; }
        public decimal Custo { get; set; }
        public int Disparos { get; set; }

    }
}
