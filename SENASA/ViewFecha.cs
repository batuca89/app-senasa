using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Spreadsheet;
using SENASA.models;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENASA
{
    public partial class ViewFecha : Form
    {
        static List<Inspec> listaInspectores = new List<Inspec>();
        static String Inspector1;
        static String Inspector2;
        static String Inspector3;
        static String tuInspector1;
        static String tuInspector2;
        static String tuInspector3;
        String informeNro="";
        static String fecha;
        static String horas_Desde;
        static String horas_hasta;
        static List<Procesado> planillaParaImprimirs = new List<Procesado>();
        static DataTable procesadoTable = new DataTable();
        List<TextBox> textBoxInspectores = new List<TextBox>();
        List<TextBox> textBoxtu = new List<TextBox>();
        


        public ViewFecha()
        {
            InitializeComponent();
            




        }

        public void cargarInspectores(List<Inspec> lista)
        {
            
            listaInspectores=lista;
        }

        public void cargarListas(List<Procesado> _planillaParaImprimir)
        {
            planillaParaImprimirs = _planillaParaImprimir; 
        }

        public void cargarListDatagrid(DataTable _lista)
        {
            procesadoTable = _lista;
        }

        public void cargarFechaYhora(String _fecha, String _desde, String _hasta)
        {
            fecha = _fecha;
            horas_Desde = _desde;
            horas_hasta= _hasta;
        }
     

        public void cargarFormulario()
        {
            textBoxInspectores.Add(this.txt_nombre_inspector1);
            textBoxInspectores.Add(this.txt_nombre_inspector2);
            textBoxInspectores.Add(this.txt_nombre_inspector3);
            textBoxtu.Add(this.txt_tu_ispector1);
            textBoxtu.Add(this.txt_tu_ispector2);
            textBoxtu.Add(this.txt_tu_ispector3);
            int a = 0;
            foreach (var index in listaInspectores)
            {
                textBoxInspectores[a].Text = index.ApellidoNombre;
                textBoxtu[a].Text = index.Tu;
                a++;
            }

            dgv_vista.DataSource = planillaParaImprimirs;
            this.txt_fecha.Text = fecha;
            this.txt_horas_desde.Text = horas_Desde;
            this.txt_horas_hasta.Text = horas_hasta;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ViewFecha_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttuInspector3_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttuInspector2_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttuinspector1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textViewNombre3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textViewNombre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textViewNombre2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearBordeSuperiorNegro(int fila, int columnaDesde, int columnaHasta, SLDocument document)
        {
            SLStyle style = document.CreateStyle();
            style.Border.SetTopBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin, System.Drawing.Color.Black);
            for (int i=columnaDesde; i< columnaHasta; i++)
            {
                document.SetCellStyle(fila, i, style);
            }
        }
        private void CrearBordelateralNegro(int columna, int filaDesde, int filaHasta, SLDocument document)
        {
            SLStyle style = document.CreateStyle();
            style.Border.SetRightBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin, System.Drawing.Color.Black);
            for (int i = filaDesde; i < filaHasta; i++)
            {
                document.SetCellStyle( i, columna, style);
            }
        }

        private void PintarCeldaBlanca(int fila, int columnaDesde, int columnaHasta, SLDocument document)
        {
            SLStyle style = document.CreateStyle();
            style.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.White, System.Drawing.Color.Yellow);
            for (int i = columnaDesde; i < columnaHasta; i++)
            {
                document.SetCellStyle(fila, i, style);
            }
        }

        private void ConfigColumn(SLDocument document)
        {
            document.SetColumnWidth(1, 13);
            document.SetColumnWidth(2, 9);
            document.SetColumnWidth(3, 11);
            document.SetColumnWidth(4, 9);
            document.SetColumnWidth(5, 9);
            document.SetColumnWidth(6, 9);
            document.SetColumnWidth(7, 14);
            document.SetColumnWidth(8, 14);
        }

        private void pintarVariasCeldasBlancas(int filaDesde, int filaHasta, int columnaDesde, int columnaHasta, SLDocument document)
        {
            for (int i = filaDesde; i <= filaHasta; i++)
            {
                PintarCeldaBlanca(i, columnaDesde, columnaHasta, document);
            }
        }
        private void btn_excel_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument();
            sl.SetCellValue(2, 3, "UNION EUROPEA");
            sl.MergeWorksheetCells(1, 6, 1, 3);
            ConfigColumn(sl);
            String pathImg = @"C:\Users\matias.salas\source\repos\senasa-main\SENASA\Resources\logoSenasa_pequeño.png";
            String path = @"C:\Users\matias.salas\Desktop\miexcel.xlsx";
            //SLPicture pic = new SLPicture(pathImg);
            // sl.MergeWorksheetCells("A1", "H3");
            pintarVariasCeldasBlancas(1, 8, 1, 9, sl);                     
            CrearBordeSuperiorNegro(4, 1, 9, sl);
            CrearBordeSuperiorNegro(9, 1, 9, sl);

            int fila = 10;
            int columna = 1;

            foreach(var index in planillaParaImprimirs)
            {
                sl.SetCellValue(fila, columna, index.Up);
                fila++;
            }
            CrearBordelateralNegro(8, 1,fila, sl);
            //sl.SetCellValue(1, 1, "primera fila1");
            //sl.SetCellValue(2, 2, "segunda fila2");

            sl.SaveAs(path);

        }
    }
}
