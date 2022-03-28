using DashTelecom.Domain.Models;
using DashTelecom.Domain.Models.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace DashTelecom.Domain.Intefaces
{
    public interface ICustoGeralRepository //: IRepository<CustoDia> //não e necessidade desse heraça aqui, deixar por enquanto, não vamos usar interface generica junto com as especializadas
    {
        Task<IEnumerable<CustoDia>> ObterCustoServidorDia();
        Task<IEnumerable<CustoOperadora>> ObterCustoOperadora();
        Task<IEnumerable<CustoServidor>> ObterCustoServidorPorServidor();
    }
}
