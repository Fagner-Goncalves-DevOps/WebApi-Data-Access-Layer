using System;
using System.Collections.Generic;
using System.Text;

namespace DashTelecom.Domain.Models
{
    public class TabTelecomOperadoras : Entity
    {
       // public int Id { get; set; }
        public string Rota { get; set; }
        public string Operadora { get; set; }
        public string Tipo { get; set; }
        public string Pag_sub { get; set; }
        public string Tecnologia { get; set; }
        public string Operadora_ftr { get; set; }
    }
}
