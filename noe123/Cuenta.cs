using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noe123
{
    internal class Cuenta
    {
        decimal ValorHaber { get; set; }
        decimal ValorDebe { get; set; }
        holaCuenta count { get; set; }
    }

    public enum TipoCuenta
    {
        Activo,
        Pasivo,
        Gasto,
        Ganancia,
        Capital
    }

    public enum TipoCuentaEspecial
    {
        CapitalAcciones,
        Ventas,
        ReservaLegal,
        UtilidadRetenida
    }

    public class holaCuenta
    {
        public string Nombre { get; set; }
        public TipoCuenta Tipo { get; set; }
        public TipoCuentaEspecial TipoEspecial { get; set; }
    }
}

