namespace DentalCenter.Views.Paciente
{
    partial class FrmPacienteMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea52 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series69 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series70 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title52 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea53 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series71 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title53 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea54 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series72 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title54 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tlpPacienteCont = new System.Windows.Forms.TableLayoutPanel();
            this.pCantComarcas = new System.Windows.Forms.Panel();
            this.cCantUbicacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pTopConsulta = new System.Windows.Forms.Panel();
            this.pCantEdades = new System.Windows.Forms.Panel();
            this.pCantSexo = new System.Windows.Forms.Panel();
            this.cCantidadSexo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pCantRegistros = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombreUltimoRegistrado = new System.Windows.Forms.Label();
            this.lNumCantRegistros = new System.Windows.Forms.Label();
            this.lNombreCantRegistrados = new System.Windows.Forms.Label();
            this.cEdades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlpFunciones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.btnVerPacientes = new System.Windows.Forms.Button();
            this.tlpPacienteCont.SuspendLayout();
            this.pCantComarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cCantUbicacion)).BeginInit();
            this.pCantEdades.SuspendLayout();
            this.pCantSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cCantidadSexo)).BeginInit();
            this.pCantRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEdades)).BeginInit();
            this.tlpFunciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPacienteCont
            // 
            this.tlpPacienteCont.BackColor = System.Drawing.Color.Transparent;
            this.tlpPacienteCont.ColumnCount = 3;
            this.tlpPacienteCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPacienteCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpPacienteCont.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpPacienteCont.Controls.Add(this.pCantComarcas, 1, 1);
            this.tlpPacienteCont.Controls.Add(this.pTopConsulta, 0, 1);
            this.tlpPacienteCont.Controls.Add(this.pCantEdades, 2, 0);
            this.tlpPacienteCont.Controls.Add(this.pCantSexo, 1, 0);
            this.tlpPacienteCont.Controls.Add(this.pCantRegistros, 0, 0);
            this.tlpPacienteCont.Controls.Add(this.tlpFunciones, 0, 2);
            this.tlpPacienteCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPacienteCont.Location = new System.Drawing.Point(0, 0);
            this.tlpPacienteCont.Name = "tlpPacienteCont";
            this.tlpPacienteCont.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tlpPacienteCont.RowCount = 3;
            this.tlpPacienteCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPacienteCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPacienteCont.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPacienteCont.Size = new System.Drawing.Size(789, 510);
            this.tlpPacienteCont.TabIndex = 0;
            // 
            // pCantComarcas
            // 
            this.pCantComarcas.BackColor = System.Drawing.Color.White;
            this.tlpPacienteCont.SetColumnSpan(this.pCantComarcas, 2);
            this.pCantComarcas.Controls.Add(this.cCantUbicacion);
            this.pCantComarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCantComarcas.Location = new System.Drawing.Point(274, 183);
            this.pCantComarcas.Margin = new System.Windows.Forms.Padding(10);
            this.pCantComarcas.Name = "pCantComarcas";
            this.tlpPacienteCont.SetRowSpan(this.pCantComarcas, 2);
            this.pCantComarcas.Size = new System.Drawing.Size(500, 307);
            this.pCantComarcas.TabIndex = 4;
            // 
            // cCantUbicacion
            // 
            chartArea52.AxisX.MajorGrid.Enabled = false;
            chartArea52.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea52.Name = "ChartAreaCantUbicacion";
            this.cCantUbicacion.ChartAreas.Add(chartArea52);
            this.cCantUbicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCantUbicacion.Location = new System.Drawing.Point(0, 0);
            this.cCantUbicacion.Name = "cCantUbicacion";
            series69.ChartArea = "ChartAreaCantUbicacion";
            series69.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series69.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series69.IsValueShownAsLabel = true;
            series69.IsVisibleInLegend = false;
            series69.IsXValueIndexed = true;
            series69.Name = "SeriesMunicipio";
            series70.ChartArea = "ChartAreaCantUbicacion";
            series70.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series70.IsValueShownAsLabel = true;
            series70.Name = "SeriesDepartamento";
            this.cCantUbicacion.Series.Add(series69);
            this.cCantUbicacion.Series.Add(series70);
            this.cCantUbicacion.Size = new System.Drawing.Size(500, 307);
            this.cCantUbicacion.TabIndex = 0;
            this.cCantUbicacion.Text = "s";
            title52.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title52.Name = "TitleCantUbicacion";
            title52.Text = "Pacientes por Ubicación";
            this.cCantUbicacion.Titles.Add(title52);
            // 
            // pTopConsulta
            // 
            this.pTopConsulta.BackColor = System.Drawing.Color.White;
            this.pTopConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTopConsulta.Location = new System.Drawing.Point(15, 183);
            this.pTopConsulta.Margin = new System.Windows.Forms.Padding(10);
            this.pTopConsulta.Name = "pTopConsulta";
            this.pTopConsulta.Size = new System.Drawing.Size(239, 143);
            this.pTopConsulta.TabIndex = 3;
            // 
            // pCantEdades
            // 
            this.pCantEdades.BackColor = System.Drawing.Color.White;
            this.pCantEdades.Controls.Add(this.cEdades);
            this.pCantEdades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCantEdades.Location = new System.Drawing.Point(533, 20);
            this.pCantEdades.Margin = new System.Windows.Forms.Padding(10);
            this.pCantEdades.Name = "pCantEdades";
            this.pCantEdades.Size = new System.Drawing.Size(241, 143);
            this.pCantEdades.TabIndex = 2;
            // 
            // pCantSexo
            // 
            this.pCantSexo.BackColor = System.Drawing.Color.White;
            this.pCantSexo.Controls.Add(this.cCantidadSexo);
            this.pCantSexo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCantSexo.Location = new System.Drawing.Point(274, 20);
            this.pCantSexo.Margin = new System.Windows.Forms.Padding(10);
            this.pCantSexo.Name = "pCantSexo";
            this.pCantSexo.Size = new System.Drawing.Size(239, 143);
            this.pCantSexo.TabIndex = 1;
            // 
            // cCantidadSexo
            // 
            this.cCantidadSexo.BackColor = System.Drawing.Color.Transparent;
            this.cCantidadSexo.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea53.AxisX.IsMarksNextToAxis = false;
            chartArea53.AxisX.MajorGrid.Enabled = false;
            chartArea53.AxisX.MajorTickMark.Enabled = false;
            chartArea53.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90;
            chartArea53.AxisX.TitleFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea53.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea53.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea53.AxisY.TitleFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea53.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea53.BorderColor = System.Drawing.Color.Transparent;
            chartArea53.Name = "ChartAreaCantSexo";
            this.cCantidadSexo.ChartAreas.Add(chartArea53);
            this.cCantidadSexo.Dock = System.Windows.Forms.DockStyle.Fill;
            legend18.Name = "legendSexo";
            legend18.TitleFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCantidadSexo.Legends.Add(legend18);
            this.cCantidadSexo.Location = new System.Drawing.Point(0, 0);
            this.cCantidadSexo.Margin = new System.Windows.Forms.Padding(0);
            this.cCantidadSexo.Name = "cCantidadSexo";
            series71.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series71.ChartArea = "ChartAreaCantSexo";
            series71.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series71.CustomProperties = "PieLineColor=White, CollectedColor=White";
            series71.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series71.IsValueShownAsLabel = true;
            series71.Label = "#PERCENT{P0} / #VAL{G} P";
            series71.LabelForeColor = System.Drawing.Color.White;
            series71.LabelToolTip = "#AXISLABEL";
            series71.Legend = "legendSexo";
            series71.LegendText = "#AXISLABEL";
            series71.Name = "sCantidadSexo";
            this.cCantidadSexo.Series.Add(series71);
            this.cCantidadSexo.Size = new System.Drawing.Size(239, 143);
            this.cCantidadSexo.TabIndex = 0;
            title53.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            title53.BorderWidth = 0;
            title53.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title53.Name = "titleSexo";
            title53.Text = "Pacientes por sexo";
            this.cCantidadSexo.Titles.Add(title53);
            // 
            // pCantRegistros
            // 
            this.pCantRegistros.BackColor = System.Drawing.Color.White;
            this.pCantRegistros.Controls.Add(this.label1);
            this.pCantRegistros.Controls.Add(this.lNombreUltimoRegistrado);
            this.pCantRegistros.Controls.Add(this.lNumCantRegistros);
            this.pCantRegistros.Controls.Add(this.lNombreCantRegistrados);
            this.pCantRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCantRegistros.Location = new System.Drawing.Point(15, 20);
            this.pCantRegistros.Margin = new System.Windows.Forms.Padding(10);
            this.pCantRegistros.Name = "pCantRegistros";
            this.pCantRegistros.Size = new System.Drawing.Size(239, 143);
            this.pCantRegistros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "14/03/2016";
            // 
            // lNombreUltimoRegistrado
            // 
            this.lNombreUltimoRegistrado.AutoSize = true;
            this.lNombreUltimoRegistrado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUltimoRegistrado.Location = new System.Drawing.Point(11, 113);
            this.lNombreUltimoRegistrado.Name = "lNombreUltimoRegistrado";
            this.lNombreUltimoRegistrado.Size = new System.Drawing.Size(110, 19);
            this.lNombreUltimoRegistrado.TabIndex = 2;
            this.lNombreUltimoRegistrado.Text = "Último registro:";
            // 
            // lNumCantRegistros
            // 
            this.lNumCantRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNumCantRegistros.AutoSize = true;
            this.lNumCantRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lNumCantRegistros.Font = new System.Drawing.Font("Calibri", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumCantRegistros.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lNumCantRegistros.Location = new System.Drawing.Point(4, 4);
            this.lNumCantRegistros.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lNumCantRegistros.Name = "lNumCantRegistros";
            this.lNumCantRegistros.Size = new System.Drawing.Size(136, 64);
            this.lNumCantRegistros.TabIndex = 0;
            this.lNumCantRegistros.Text = "1000";
            // 
            // lNombreCantRegistrados
            // 
            this.lNombreCantRegistrados.AutoSize = true;
            this.lNombreCantRegistrados.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreCantRegistrados.Location = new System.Drawing.Point(139, 36);
            this.lNombreCantRegistrados.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lNombreCantRegistrados.Name = "lNombreCantRegistrados";
            this.lNombreCantRegistrados.Size = new System.Drawing.Size(97, 23);
            this.lNombreCantRegistrados.TabIndex = 1;
            this.lNombreCantRegistrados.Text = "registrados";
            this.lNombreCantRegistrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cEdades
            // 
            chartArea54.AxisX.IsLabelAutoFit = false;
            chartArea54.AxisX.LabelStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea54.AxisX.LogarithmBase = 2D;
            chartArea54.AxisX.MajorGrid.Enabled = false;
            chartArea54.AxisX.MajorTickMark.Enabled = false;
            chartArea54.AxisX.TitleFont = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea54.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea54.AxisY.IsLabelAutoFit = false;
            chartArea54.AxisY.LabelStyle.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea54.AxisY.LogarithmBase = 2D;
            chartArea54.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea54.AxisY.TitleFont = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea54.Name = "ChartAreaEdades";
            this.cEdades.ChartAreas.Add(chartArea54);
            this.cEdades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cEdades.Location = new System.Drawing.Point(0, 0);
            this.cEdades.Name = "cEdades";
            series72.ChartArea = "ChartAreaEdades";
            series72.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series72.CustomProperties = "DrawingStyle=Emboss";
            series72.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series72.IsValueShownAsLabel = true;
            series72.IsVisibleInLegend = false;
            series72.IsXValueIndexed = true;
            series72.LabelToolTip = "#PERCENT{P2}";
            series72.Name = "SeriesEdades";
            series72.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.cEdades.Series.Add(series72);
            this.cEdades.Size = new System.Drawing.Size(241, 143);
            this.cEdades.TabIndex = 1;
            this.cEdades.Text = "s";
            title54.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title54.Name = "TitleEdades";
            title54.Text = "Pacientes por Edades";
            this.cEdades.Titles.Add(title54);
            // 
            // tlpFunciones
            // 
            this.tlpFunciones.ColumnCount = 1;
            this.tlpFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFunciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFunciones.Controls.Add(this.btnVerPacientes, 0, 1);
            this.tlpFunciones.Controls.Add(this.btnAgregarPaciente, 0, 0);
            this.tlpFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFunciones.Location = new System.Drawing.Point(15, 346);
            this.tlpFunciones.Margin = new System.Windows.Forms.Padding(10);
            this.tlpFunciones.Name = "tlpFunciones";
            this.tlpFunciones.RowCount = 2;
            this.tlpFunciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFunciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFunciones.Size = new System.Drawing.Size(239, 144);
            this.tlpFunciones.TabIndex = 5;
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.AutoSize = true;
            this.btnAgregarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPaciente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarPaciente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPaciente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarPaciente.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(233, 66);
            this.btnAgregarPaciente.TabIndex = 0;
            this.btnAgregarPaciente.Text = "Nuevo Paciente";
            this.btnAgregarPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarPaciente.UseVisualStyleBackColor = false;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // btnVerPacientes
            // 
            this.btnVerPacientes.AutoSize = true;
            this.btnVerPacientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerPacientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerPacientes.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnVerPacientes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnVerPacientes.Location = new System.Drawing.Point(3, 75);
            this.btnVerPacientes.Name = "btnVerPacientes";
            this.btnVerPacientes.Size = new System.Drawing.Size(233, 66);
            this.btnVerPacientes.TabIndex = 1;
            this.btnVerPacientes.Text = "Ver Pacientes";
            this.btnVerPacientes.UseVisualStyleBackColor = false;
            // 
            // FrmPacienteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(789, 510);
            this.Controls.Add(this.tlpPacienteCont);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPacienteMain";
            this.Text = "Paciente";
            this.tlpPacienteCont.ResumeLayout(false);
            this.pCantComarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cCantUbicacion)).EndInit();
            this.pCantEdades.ResumeLayout(false);
            this.pCantSexo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cCantidadSexo)).EndInit();
            this.pCantRegistros.ResumeLayout(false);
            this.pCantRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEdades)).EndInit();
            this.tlpFunciones.ResumeLayout(false);
            this.tlpFunciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPacienteCont;
        private System.Windows.Forms.Panel pCantComarcas;
        private System.Windows.Forms.Panel pTopConsulta;
        private System.Windows.Forms.Panel pCantEdades;
        private System.Windows.Forms.Panel pCantSexo;
        private System.Windows.Forms.Panel pCantRegistros;
        private System.Windows.Forms.Label lNumCantRegistros;
        private System.Windows.Forms.Label lNombreCantRegistrados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombreUltimoRegistrado;
        private System.Windows.Forms.DataVisualization.Charting.Chart cCantidadSexo;
        private System.Windows.Forms.DataVisualization.Charting.Chart cCantUbicacion;
        private System.Windows.Forms.DataVisualization.Charting.Chart cEdades;
        private System.Windows.Forms.TableLayoutPanel tlpFunciones;
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.Button btnVerPacientes;


    }
}