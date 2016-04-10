using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalCenter.Views.Paciente
{
    public partial class FrmPacienteMain : Form
    {
        FrmMain frmMain;
        int a = 0, b = 0;
        public FrmPacienteMain()
        {
            InitializeComponent();
        }

        public FrmPacienteMain (FrmMain frmPrincipal)
        {
            InitializeComponent();
            frmMain = frmPrincipal;
            fillChartCantSexo(30, 20);
            fillChartEdades(2, 5, 15, 10, 5, 1);
        }

        private void fillChartCantSexo(int cantMasculino, int cantFemenino)   
        {
            this.cCantidadSexo.Series["sCantidadSexo"].Points.Clear();
            this.cCantidadSexo.Series["sCantidadSexo"].Points.AddXY("Masculino", cantMasculino);
            this.cCantidadSexo.Series["sCantidadSexo"].Points.AddXY("Femenino", cantFemenino);
        }

        private void fillChartEdades(int cero_diez, int diez_veinte, int veinte_treinta, int treinta_cuarenta, int cuarenta_cincuenta, int cincuenta_mas)
        {
            this.cEdades.Series["SeriesEdades"].Points.Clear();
            this.cEdades.Series["SeriesEdades"].Points.AddXY("0 - 10", cero_diez);
            this.cEdades.Series["SeriesEdades"].Points.AddXY("10 - 20", diez_veinte);
            this.cEdades.Series["SeriesEdades"].Points.AddXY("20 - 30", veinte_treinta);
            this.cEdades.Series["SeriesEdades"].Points.AddXY("30 - 40", treinta_cuarenta);
            this.cEdades.Series["SeriesEdades"].Points.AddXY("40 - 50", cuarenta_cincuenta);
            this.cEdades.Series["SeriesEdades"].Points.AddXY("50 - más", cincuenta_mas);
        }

        private void fillChartCantUbicacion()
        {
            //this.cEdades.Series["SeriesEdades"].Points.Clear();
            //this.cEdades.Series["SeriesEdades"].Points.AddXY("0 - 10", cero_diez);
            //this.cEdades.Series["SeriesEdades"].Points.AddXY("10 - 20", diez_veinte);
            //this.cEdades.Series["SeriesEdades"].Points.AddXY("20 - 30", veinte_treinta);
            //this.cEdades.Series["SeriesEdades"].Points.AddXY("30 - 40", treinta_cuarenta);
            //this.cEdades.Series["SeriesEdades"].Points.AddXY("40 - 50", cuarenta_cincuenta);
            //this.cEdades.Series["SeriesEdades"].Points.AddXY("50 - más", cincuenta_mas);
        } 


        private void button1_Click(object sender, EventArgs e)
        {
            //if (frmMain != null)
            //{
            //    Button b = new Button();
            //    b.Text = "hola";
            //    b.Name = "btn1";

            //    frmMain.AddControlsTopbarOptions(b);
            //}
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain.pContent.Controls.Clear();
            Paciente.FrmNuevoPaciente nuevoPaciente = new Paciente.FrmNuevoPaciente(frmMain);
            frmMain.pContent.Controls.Add(frmMain.getFormContentProcessed(nuevoPaciente));
            nuevoPaciente.Show();
        }
    }
}
