using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENASA.models
{
    public class Procesado
    {
         int turno;
        String fechaInicio;
         int idEmpaque;
        String up;
        String certificado;
        String producto;
        String variedad;
        String bins;
        String kgVolcados;
        String descripcionCajas;
        String Confeccion;
        Decimal peso;
        String cajas;

        public Procesado(int turno, string fechaInicio, int idEmpaque, string up, string certificado, string producto, string variedad, string bins, string kgVolcados, string descripcionCajas, string confeccion, decimal peso, string cajas)
        {
            this.Turno = turno;
            this.FechaInicio = fechaInicio;
            this.IdEmpaque = idEmpaque;
            this.Up = up;
            this.Certificado = certificado;
            this.Producto = producto;
            this.Variedad = variedad;
            this.Bins = bins;
            this.KgVolcados = kgVolcados;
            this.DescripcionCajas = descripcionCajas;
            Confeccion1 = confeccion;
            this.Peso = peso;
            this.Cajas = cajas;
        }

        public int Turno { get => turno; set => turno = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public int IdEmpaque { get => idEmpaque; set => idEmpaque = value; }
        public string Up { get => up; set => up = value; }
        public string Certificado { get => certificado; set => certificado = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Variedad { get => variedad; set => variedad = value; }
        public string Bins { get => bins; set => bins = value; }
        public string KgVolcados { get => kgVolcados; set => kgVolcados = value; }
        public string DescripcionCajas { get => descripcionCajas; set => descripcionCajas = value; }
        public string Confeccion1 { get => Confeccion; set => Confeccion = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public string Cajas { get => cajas; set => cajas = value; }
    }
}
