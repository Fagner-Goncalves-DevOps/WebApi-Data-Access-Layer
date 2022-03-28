using System;
using System.Collections.Generic;
using System.Text;

namespace DashTelecom.Domain.Models
{
    public class CustoDia : Entity
    {
        public string Dia { get; set; }
        public decimal Custo { get; set; }
        public int Disparos { get; set; }

    }
}