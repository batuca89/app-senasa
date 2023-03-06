using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENASA.models
{
    internal class CargarListados
    {
        static int turno;
        static String fechaInicio;
        static int idEmpaque;
        static String up;
        static int certificado;
        static String producto;
        static String variedad;
        static int bins;
        static Decimal kgVolcados;
        static String descripcionCajas;
        static String Confeccion;
        static Decimal peso;
        static int cajas;
        static String apellidoNombre;
        static String tu;

        public int Turno { get => turno; set => turno = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public int IdEmpaque { get => idEmpaque; set => idEmpaque = value; }
        public string Up { get => up; set => up = value; }
        public int Certificado { get => certificado; set => certificado = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Variedad { get => variedad; set => variedad = value; }
        public int Bins { get => bins; set => bins = value; }
        public decimal KgVolcados { get => kgVolcados; set => kgVolcados = value; }
        public string DescripcionCajas { get => descripcionCajas; set => descripcionCajas = value; }
        public string Confeccion1 { get => Confeccion; set => Confeccion = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public int Cajas { get => cajas; set => cajas = value; }
        public string ApellidoNombre { get => apellidoNombre; set => apellidoNombre = value; }
        public string Tu { get => tu; set => tu = value; }
    }


}
