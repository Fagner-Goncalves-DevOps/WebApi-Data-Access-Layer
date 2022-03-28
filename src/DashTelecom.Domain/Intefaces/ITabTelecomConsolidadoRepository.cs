using DashTelecom.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DashTelecom.Domain.Intefaces
{
    public interface ITabTelecomConsolidadoRepository : IRepository<TabTelecomConsolidado>
    {
        Task<IEnumerable<TabTelecomConsolidado>> ObterTelecomConsolidado();
    }
}

 



