using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCenter.Views
{
    public partial class FrmMain : Form
    {

        private IList<MenuItem> menuItem = new List<MenuItem>();

        public FrmMain()
        {
            InitializeComponent();
            loadMenu();
            msUserOption.Renderer = new MyRenderer();
            lockMenu = false;
        }

        #region Propiedades

        #region TopBarOptions

        public Control.ControlCollection AddControlsTopbarOptions(Control c)
        {
            flpTopbarOptions.Controls.Add(c);
            return flpTopbarOptions.Controls;
        }
        public Control.ControlCollection AddControlsTopbarOptions(Control[] c)
        {
            foreach (Control control in c)
            {
                flpTopbarOptions.Controls.Add(control);
            }         

            return flpTopbarOptions.Controls;
        }
        public void RemoveAllControlTopbarOptions()
        {
            flpTopbarOptions.Controls.Clear();
        }
        #endregion

        public bool lockMenu
        {
            get;
            set;
        }

        #endregion

        #region Configuraciones
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.Transparent; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Transparent; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Transparent; }
            }
            public override Color MenuItemBorder
            {
                get { return SystemColors.MenuHighlight; }
            }
        }
        #endregion

        #region Utilidades
        public void setStatusMessage(string msg)
        {
            if (!msg.Equals(""))
                lStatusText.Text = msg;
            else
                lStatusText.Text = "";
        }
        public Form getFormContentProcessed(Form form)
        {
            try
            {
                form.TopLevel = false;
                form.AutoScroll = true;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                setStatusMessage(ex.Message);
            }
            
            return form;
        }
        public Image RoundCorners(Image StartImage, int CornerRadius, Color BackgroundColor)
        {
            Bitmap RoundedImage = new Bitmap(StartImage.Width, StartImage.Height);
            try
            {
                CornerRadius *= 2;
                using (Graphics g = Graphics.FromImage(RoundedImage))
                {
                    g.Clear(BackgroundColor);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (Brush brush = new TextureBrush(StartImage))
                    {
                        using (GraphicsPath gp = new GraphicsPath())
                        {
                            gp.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                            gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                            gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                            gp.AddArc(0, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                            g.FillPath(brush, gp);
                        }                    
                    }                    
                }
            }
            catch (Exception ex)
            {
                setStatusMessage(ex.Message);
            }
            return RoundedImage;
        }

        #endregion

        #region Funciones

        private void loadMenu()
        {
            try
            {
                pbUserImage.Image = RoundCorners(Properties.Resources.home, 50, Color.Transparent);
                
                MenuItem item = new MenuItem();
                item.ItemId = "miEscritorio";
                item.ItemText = "Escritorio";
                item.Name = "miEscritorio";
                item.ItemTextColor = System.Drawing.SystemColors.HighlightText;
                item.ItemIcon = Properties.Resources.home;
                item.ItemColorSelected = Color.White;
                item.ItemDefaultBackColor = System.Drawing.Color.Transparent;
                item.ItemBackColor = System.Drawing.Color.Transparent;
                item.ItemBackColorSelected = System.Drawing.ColorTranslator.FromHtml("#2892fd");
                item.IsSelected = true;
                item.Click += item_Click;
                menuItem.Add(item);
                // 
                // miPacientes
                // 
                item = new MenuItem();
                item.ItemId = "miPacientes";
                item.ItemText = "Pacientes";
                item.Name = "miPacientes";
                item.ItemTextColor = System.Drawing.SystemColors.HighlightText;
                item.ItemIcon = Properties.Resources.pacient;
                item.ItemColorSelected = Color.White;
                item.ItemDefaultBackColor = System.Drawing.Color.Transparent;
                item.ItemBackColor = System.Drawing.Color.Transparent;
                item.ItemBackColorSelected = System.Drawing.ColorTranslator.FromHtml("#2892fd");
                item.IsSelected = false;
                item.Click += item_Click;
                menuItem.Add(item);
                // 
                // miPagos
                // 
                item = new MenuItem();
                item.ItemId = "miPagos";
                item.ItemText = "Pagos";
                item.Name = "miPagos";
                item.ItemTextColor = System.Drawing.SystemColors.HighlightText;
                item.ItemIcon = Properties.Resources.pay;
                item.ItemColorSelected = Color.White;
                item.ItemDefaultBackColor = System.Drawing.Color.Transparent;
                item.ItemBackColor = System.Drawing.Color.Transparent;
                item.ItemBackColorSelected = System.Drawing.ColorTranslator.FromHtml("#2892fd");
                item.IsSelected = false;
                item.Click += item_Click;
                menuItem.Add(item);

                foreach (MenuItem i in menuItem)
                    flpMenu.Controls.Add(i);
            }
            catch (Exception ex)
            {
                setStatusMessage(ex.Message);
            }
        }

        #endregion

        #region Eventos

        private void item_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                if (!lockMenu)
                {
                    string option = sender.GetType().GetProperty("Tag").GetValue(sender).ToString();

                    Control.ControlCollection controles = flpMenu.Controls;

                    foreach (Control control in controles.OfType<MenuItem>())
                    {
                        if (((MenuItem)control).Name.Equals(option))
                        {
                            ((MenuItem)control).IsSelected = true;
                            lSectionName.Text = ((MenuItem)control).ItemText;
                        }
                        else
                            ((MenuItem)control).IsSelected = false;
                    }

                    switch (option)
                    {
                        case "miEscritorio":
                            pContent.Controls.Clear();
                            break;
                        case "miPacientes":
                            pContent.Controls.Clear();
                            Paciente.FrmPacienteMain pacientes1 = new Paciente.FrmPacienteMain(this);
                            pContent.Controls.Add(getFormContentProcessed(pacientes1));
                            pacientes1.Show();
                            break;
                        case "miPagos":
                            pContent.Controls.Clear();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                setStatusMessage(ex.Message);
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lReloj.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        #endregion


    }
}
