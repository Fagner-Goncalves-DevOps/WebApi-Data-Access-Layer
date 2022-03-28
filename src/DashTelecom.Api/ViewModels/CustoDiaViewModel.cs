using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DashTelecom.Api.ViewModels
{
    public class CustoDiaViewModel
    {
       // [DataType(DataType.Date)]
      // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
       // [Display(Name = "Dia")]
        public string Dia { get; set; }
        public decimal Custo { get; set; }
        public int Disparos { get; set; }
    }

}
