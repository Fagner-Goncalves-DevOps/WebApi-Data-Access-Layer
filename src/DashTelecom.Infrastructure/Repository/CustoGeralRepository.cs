using DashTelecom.Domain.Intefaces;
using DashTelecom.Domain.Models;
using DashTelecom.Domain.Models.Validations;
using DashTelecom.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashTelecom.Infrastructure.Repository
{
    public class CustoGeralRepository : Repository<TabTelecomConsolidado> , ICustoGeralRepository
    {
        public CustoGeralRepository(MeuDbContext context) : base(context) { }

        public async Task<IEnumerable<CustoDia>> ObterCustoServidorDia() //OK
        {
            var CustoDia = await (
                        from s in Db.TabTelecomConsolidado
                        join a in Db.TabTelecomOperadoras on s.Terminator equals a.Rota
                        group new { s.Dia, s.Custo, s.Disparos } by s.Dia into gp
                        orderby(gp.Key)
                        select new CustoDia {
                            Dia = gp.Key.ToString("yyyy'-'MM'-'dd"),
                            Custo = gp.Sum(s => s.Custo),
                            Disparos = gp.Sum(s => s.Disparos)
                    }).AsNoTracking().ToListAsync();
            return CustoDia;
        }

        public async Task<IEnumerable<CustoServidor>> ObterCustoServidorPorServidor() //OK
        {

            var CustoServidor = await (
                        from s in Db.TabTelecomConsolidado
                        join a in Db.TabTelecomOperadoras on s.Terminator equals a.Rota
                        group new { s.Servidor, s.Custo } by s.Servidor into gp
                        orderby gp.Sum(s => s.Custo)  //descending || ascending
                        select new CustoServidor
                        {
                            Servidor = gp.Key,
                            Custo = gp.Sum(s => s.Custo)
                        }).AsNoTracking().ToListAsync();
            return CustoServidor;
        }

        public async Task<IEnumerable<CustoOperadora>> ObterCustoOperadora() //OK
        {

            var CustoOperadora = await(
                    from s in Db.TabTelecomConsolidado
                    join a in Db.TabTelecomOperadoras on s.Terminator equals a.Rota
                    group new {a.Operadora, s.Custo } by new { a.Operadora } into gp
                    select new CustoOperadora { 
                    Operadora = gp.Key.Operadora,
                    Custo = gp.Sum(t => t.Custo)
                    }).AsNoTracking().ToListAsync();

            return CustoOperadora;
        }
    }
}

