using System;
using System.Collections.Generic;
using System.Text;

namespace DashTelecom.Domain.Models
{
    public class TabTelecomConsolidado : Entity
    {
        //public int Id { get; set; }
        public DateTime Dia { get; set; }
        public int Fila { get; set; }
        public string Terminator { get; set; }
        public string StatusInicial { get; set; }
        public string StatusFinal { get; set; }
        public string Classe { get; set; }
        public int Bilhetado { get; set; }
        public int Disparos { get; set; }
        public decimal Custo { get; set; }
        public int Maior30 { get; set; }
        public int Menor30 { get; set; }
        public int DisparosTarifados { get; set; }
        public string Servidor { get; set; }

    }
    /* EF Relation talves trazer aqui servidorTerminator dxpara */
    // public TabTelecomOperadoras TabTelecomOperadoras { get; set; }
}



/*
    public int Id { get; set; }
    public DateTime DIA { get; set; }
    public int FILA { get; set; }
    public string TERMINATOR { get; set; }
    public string STATUS_INICIAL { get; set; }
    public string STATUS_FINAL { get; set; }
    public string CLASSE { get; set; }
    public int BILHETADO { get; set; }
    public int DISPAROS { get; set; }
    public decimal CUSTO { get; set; }
    public int MAIOR_30 { get; set; }
    public int MENOR_30 { get; set; }
    public int DISPARO_TARIFADO { get; set; }
    public string SERVIDOR { get; set; }

*/

