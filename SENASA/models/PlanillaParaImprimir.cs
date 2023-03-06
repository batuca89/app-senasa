using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENASA.models
{
    public class PlanillaParaImprimir
    {
        String up;
        String certificado;
        String especie;
        String variedad;
        String bines;
        String kgVolcado;
        String confeccion;
        String peso;

        public PlanillaParaImprimir(string up, string certificado, string especie, string variedad, string bines, string kgVolcado, string confeccion, string peso)
        {
            this.up = up;
            this.certificado = certificado;
            this.especie = especie;
            this.variedad = variedad;
            this.bines = bines;
            this.kgVolcado = kgVolcado;
            this.confeccion = confeccion;
            this.peso = peso;
        }

        public string Up { get => up; set => up = value; }
        public string Certificado { get => certificado; set => certificado = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Variedad { get => variedad; set => variedad = value; }
        public string Bines { get => bines; set => bines = value; }
        public string KgVolcado { get => kgVolcado; set => kgVolcado = value; }
        public string Confeccion { get => confeccion; set => confeccion = value; }
        public string Peso { get => peso; set => peso = value; }
    }
}
