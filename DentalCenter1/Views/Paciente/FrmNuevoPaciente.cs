using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCenter.Views.Paciente
{
    public partial class FrmNuevoPaciente : Form
    {
        FrmMain frmMain;

        #region CONSTRUCTOR
        public FrmNuevoPaciente()
        {
            InitializeComponent();
        }
        public FrmNuevoPaciente(FrmMain frmPrincipal)
        {
            InitializeComponent();
            //Se obtiene la referencia del formulario principal
            frmMain = frmPrincipal;
            //Se bloquea el menu
            frmMain.lockMenu = true;

            //Se bloquea el scrollbar Horizontal
            this.tlpNuevoPacienteCont.HorizontalScroll.Maximum = 0;
            this.tlpNuevoPacienteCont.AutoScroll = false;
            this.tlpNuevoPacienteCont.HorizontalScroll.Enabled = false;
            this.tlpNuevoPacienteCont.HorizontalScroll.Visible = false;
            this.tlpNuevoPacienteCont.AutoScroll = true;

            //Se cargan los botones de la topBar
            cargarToolBarButtons();
            //Se cargan las configuraciones de inicio
            init();
        }

        #endregion

        #region UTILERIA
        //Controles a cargarse en la toolbar
        private void cargarToolBarButtons()
        {
            //Creacion del boton para guardar la informacion del paciente
            Button btnGuardarPaciente = new Button()
            {
                BackColor = System.Drawing.Color.WhiteSmoke,
                Cursor = System.Windows.Forms.Cursors.Hand,
                FlatAppearance =
                {
                    BorderSize = 0,
                    CheckedBackColor = System.Drawing.SystemColors.ControlLight,
                    MouseDownBackColor = System.Drawing.SystemColors.ControlLight,
                    MouseOverBackColor = System.Drawing.Color.White
                },
                Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(203, 3),
                Size = new System.Drawing.Size(80, 24),
                Text = "Guardar",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                UseVisualStyleBackColor = false,
                Name = "btnGuardarPaciente"
            };
            //Creacion del boton Cancelar
            Button btnCancelarPaciente = new Button()
            {
                BackColor = System.Drawing.Color.WhiteSmoke,
                Cursor = System.Windows.Forms.Cursors.Hand,
                FlatAppearance =
                {
                    BorderSize = 0,
                    CheckedBackColor = System.Drawing.SystemColors.ControlLight,
                    MouseDownBackColor = System.Drawing.SystemColors.ControlLight,
                    MouseOverBackColor = System.Drawing.Color.White
                },
                Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(203, 3),
                Size = new System.Drawing.Size(80, 24),
                Text = "Cancelar",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                UseVisualStyleBackColor = false,
                Name = "btnCancelarPaciente"
            };
            //Eventos de los botones Guardar y Cancelar
            btnGuardarPaciente.Click += new System.EventHandler(this.GuardarPaciente_Click);
            btnCancelarPaciente.Click += new System.EventHandler(this.CancelarPaciente_Click);

            //Se agregan los controles a un arreglo para luego agregarlos a la toolbar
            Control[] controls = new Control[] { btnGuardarPaciente, btnCancelarPaciente };
            frmMain.AddControlsTopbarOptions(controls);
        }
        private bool verificarCorreo(string correo)
        {
            bool r = false;

            //Se comprueba que el correo es válido en caso de que este no lo sea se lanzará una excepcion
            try
            {
                var validador = new MailAddress(correo);
                r = true;
            }
            catch
            {
                r = false;
            }

            return r;
        }
        private void init()
        {
            //Cargar ComboBox Sexo
            String[] sexo = new String[] { "Masculino", "Femenino" };
            this.cbSexo.DataSource = sexo;
            this.cbSexo.SelectedIndex = 0;

            //Se agrega la primer fila de teléfono
            agregarFilaTelefono(true);
            //Se agrega la primer fila de correo
            agregarFilaCorreo(true);
        }
        private void agregarFilaTelefono(bool init = false)
        {
            try
            {
                //Comprobar las filas del TableLayoutPanel
                if (init)
                    tlpTelefono.RowCount = 1;
                else
                    tlpTelefono.RowCount += 1;

                //Aplicar ancho y tipo de fila
                tlpTelefono.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));

                //Crear TextBox Numero de telefono
                TextBox tbNumTelefono = new TextBox()
                {
                    Dock = System.Windows.Forms.DockStyle.Fill,
                    Location = new System.Drawing.Point(3, 3),
                    Size = new System.Drawing.Size(104, 23),
                    Name = "tbNumTelefono" + tlpTelefono.RowCount.ToString()
                };

                //Crear ComboBox Tipo de Telefono
                ComboBox cbTipoTelefono = new ComboBox()
                {
                    AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend,
                    AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems,
                    Dock = System.Windows.Forms.DockStyle.Fill,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    FormattingEnabled = true,
                    Location = new System.Drawing.Point(113, 3),
                    Size = new System.Drawing.Size(84, 23),
                    Name = "cbTipoTelefono" + tlpTelefono.RowCount.ToString()
                };

                //Crear Button para Agregar nueva fila
                Button btnAgregarFilaTelefono = new Button()
                {
                    AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink,
                    BackColor = System.Drawing.Color.WhiteSmoke,
                    Cursor = System.Windows.Forms.Cursors.Hand,
                    Dock = System.Windows.Forms.DockStyle.Fill,
                    FlatAppearance =
                    {
                        BorderSize = 0,
                        CheckedBackColor = System.Drawing.SystemColors.ControlLight,
                        MouseDownBackColor = System.Drawing.SystemColors.ControlLight,
                        MouseOverBackColor = System.Drawing.Color.White
                    },
                    Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(203, 3),
                    Size = new System.Drawing.Size(24, 23),
                    TextAlign = System.Drawing.ContentAlignment.TopCenter,
                    UseVisualStyleBackColor = false,
                    Name = "btnAgregarFilaTelefono" + tlpTelefono.RowCount.ToString()
                };

                //Se agregan los controles a la nueva fila
                tlpTelefono.Controls.Add(tbNumTelefono, 0, tlpTelefono.RowCount - 1);
                tlpTelefono.Controls.Add(cbTipoTelefono, 1, tlpTelefono.RowCount - 1);

                //Agregar botón para agregar fila sino es la primera fila
                if (!init)
                {
                    tlpTelefono.Controls.Add(btnAgregarFilaTelefono, 2, tlpTelefono.RowCount - 1);

                    //Si existen mas de 1 fila de telefono se modifica el boton para remover la fila
                    btnAgregarFilaTelefono.Text = "-";
                    btnAgregarFilaTelefono.Click += new System.EventHandler(this.QuitarTelefono_Click);
                }                    

                //Arreglo de tipo de telefono
                String[] tipoTelefono = new String[] { "Claro", "Movistar" };

                //Se aplican los eventos y propiedades una vez creados los controles
                cbTipoTelefono.DataSource = tipoTelefono;
                cbTipoTelefono.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                frmMain.setStatusMessage(ex.Message);
            }
        }
        private void agregarFilaCorreo(bool init = false)
        {

            try
            {
                //Comprobar las filas del TableLayoutPanel
                if (init)
                    tlpCorreo.RowCount = 1;
                else
                    tlpCorreo.RowCount += 1;

                //Aplicar ancho y tipo de fila
                tlpCorreo.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));

                //Crear TextBox para ingresar el correo
                TextBox tbCorreo = new TextBox()
                {
                    Dock = System.Windows.Forms.DockStyle.Fill,
                    Location = new System.Drawing.Point(3, 3),
                    Size = new System.Drawing.Size(193, 23),
                    Name = "tbCorreo" + tlpCorreo.RowCount.ToString()
                };
                
                //Crear Button para Agregar nueva fila
                Button btnAgregarFilaCorreo = new Button()
                {
                    AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink,
                    BackColor = System.Drawing.Color.WhiteSmoke,
                    Cursor = System.Windows.Forms.Cursors.Hand,
                    Dock = System.Windows.Forms.DockStyle.Fill,
                    FlatAppearance =
                    {
                        BorderSize = 0,
                        CheckedBackColor = System.Drawing.SystemColors.ControlLight,
                        MouseDownBackColor = System.Drawing.SystemColors.ControlLight,
                        MouseOverBackColor = System.Drawing.Color.White
                    },
                    Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(203, 3),
                    Size = new System.Drawing.Size(24, 23),
                    TextAlign = System.Drawing.ContentAlignment.TopCenter,
                    UseVisualStyleBackColor = false,
                    Name = "btnAgregarFilaCorreo" + tlpCorreo.RowCount.ToString()
                };

                //Se agregan los controles a la nueva fila
                tlpCorreo.Controls.Add(tbCorreo, 0, tlpCorreo.RowCount - 1);
                
                //Agregar botón para agregar fila sino es la primera fila
                if (!init)
                {
                    tlpCorreo.Controls.Add(btnAgregarFilaCorreo, 1, tlpCorreo.RowCount - 1);

                    //Si existen mas de 1 fila de correo se modifica el boton para remover la fila
                    btnAgregarFilaCorreo.Text = "-";
                    btnAgregarFilaCorreo.Click += new System.EventHandler(this.QuitarCorreo_Click);
                }        

                //Se agrega evento de validación de correo
                tbCorreo.Leave += new System.EventHandler(this.tbCorreo_Leave);
            }
            catch (Exception ex)
            {
                frmMain.setStatusMessage(ex.Message);
            }
        }
        private void removerFila(TableLayoutPanel panel, int filaIndex)
        {
            try
            {
                if (filaIndex >= panel.RowCount)
                {
                    return;
                }

                //Borrar todos los controles de la fila que se desea eliminar
                for (int i = 0; i < panel.ColumnCount; i++)
                {
                    var control = panel.GetControlFromPosition(i, filaIndex);
                    panel.Controls.Remove(control);
                }

                //Mover los controles hacia arriba en caso de que la fila eliminada este en medio
                for (int i = filaIndex + 1; i < panel.RowCount; i++)
                {
                    for (int j = 0; j < panel.ColumnCount; j++)
                    {
                        var control = panel.GetControlFromPosition(j, i);
                        if (control != null)
                        {
                            panel.SetRow(control, i - 1);
                        }
                    }
                }

                //Borrar la ultima fila
                panel.RowStyles.RemoveAt(panel.RowCount - 1);
                panel.RowCount--;
            }
            catch (Exception ex)
            {
                frmMain.setStatusMessage(ex.Message);
            }
        }

        #endregion

        #region EVENTOS
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            //Se remueven los controles de la topbar
            frmMain.RemoveAllControlTopbarOptions();
            //Se limpia el contenedor padre
            frmMain.pContent.Controls.Clear();
            //Se crea una nueva instancia del formulario principal de paciente
            Paciente.FrmPacienteMain frmPacienteMain = new Paciente.FrmPacienteMain(frmMain);
            //Se agrega y se muestra el formulario principal de paciente al contenedor padre
            frmMain.pContent.Controls.Add(frmMain.getFormContentProcessed(frmPacienteMain));
            frmPacienteMain.Show();
            //Se desbloquea el menu
            frmMain.lockMenu = false;
        }
        private void GuardarPaciente_Click(object sender, EventArgs e)
        {

        }
        private void CancelarPaciente_Click(object sender, EventArgs e)
        {
            //Se cierra la instancia de este formulario
            this.Close();
        }
        private void AgregarTelefono_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Se invoca al metodo agregarFilaTelefono
            agregarFilaTelefono();
        }
        private void QuitarTelefono_Click(object sender, EventArgs e)
        {
            //Se obtiene la fila del boton donde se lanzó el evento click y se elimina la fila
            Button btn = (Button)sender;
            removerFila(tlpTelefono, tlpTelefono.GetRow(btn));
        }
        private void AgregarCorreo_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Se invoca al metodo agregarFilaCorreo
            agregarFilaCorreo();
        }
        private void QuitarCorreo_Click(object sender, EventArgs e)
        {
            //Se obtiene la fila del boton donde se lanzó el evento click y se elimina la fila
            Button btn = (Button)sender;
            removerFila(tlpCorreo, tlpCorreo.GetRow(btn));
        }
        private void tbCorreo_Leave(object sender, EventArgs e)
        {
            //Se obtiene el correo del control donde se lanzo el evento
            TextBox tbCorreo = (TextBox)sender;
            string correo = tbCorreo.Text;

            //Se valida que el correo no este vácio
            if (!correo.Equals(""))
            {
                //Se verifica si el correo es válido en caso de que no lo sea se lanzará una alerta
                if (!verificarCorreo(correo))
                {
                    MessageBox.Show("El correo '" + correo + "' es inválido", "Correo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbCorreo.Text = "";
                    tbCorreo.Focus();
                }
            }
        }

        #endregion     

    }
}
