using System;
using System.Collections.Generic;
using System.Text;

namespace ProdeFutbol.Entidades
{
    public class Partido
    {
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public DateTime Fecha { get; set; }
       public string InformarResultados {
            get
            {
                var resultado = "";
                if (GolesLocal > GolesVisitante)
                {
                    resultado = $"Gano {EquipoLocal.Nombre}";
                }
                else if (GolesLocal < GolesVisitante)
                {
                    resultado = $"Gano {EquipoVisitante.Nombre}";
                }
                else
                {
                    resultado = "empate";
                }
                return resultado;
            } }
    }
}
