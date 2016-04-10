using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCenter.Views
{
    public partial class MenuItem : UserControl
    {
        private bool selected = false;

        #region Properties
        [DisplayName("Identificador"), Description("Identificador del item"), Category("Item Menu")]
        public string ItemId
        {
            get;
            set;
        }
        [DisplayName("Texto"), Description("Texto del item"), Category("Item Menu")]
        public string ItemText
        {
            get { return lTextMenuItem.Text; }
            set { lTextMenuItem.Text = value; }
        }

        [DisplayName("Imagen"), Description("Imagen del item del menú"), Category("Item Menu")]
        public Image ItemIcon
        {
            get { return ImageMenuItem.Image; }
            set { ImageMenuItem.Image = value; }
        }

        [DisplayName("Color"), Description("Color del texto del menú"), Category("Item Menu")]
        public Color ItemTextColor
        {
            get { return lTextMenuItem.ForeColor; }
            set
            {
                lTextMenuItem.ForeColor = value;
            }
        }

        [DisplayName("Color Panel Seleccionado"), Description("Color del texto del menú al ser seleccionado"), Category("Item Menu")]
        public Color ItemColorSelected
        {
            get;
            set;
        }

        [DisplayName("Color de Fondo Default"), Description("Color de Fondo default del texto del menú"), Category("Item Menu")]
        public Color ItemDefaultBackColor
        {
            get;
            set;
        }

        [DisplayName("Color de Fondo"), Description("Color del fondo del item del menú"), Category("Item Menu")]
        public Color ItemBackColor
        {
            get 
            { 
                return base.BackColor; 
            }
            set 
            { 
                base.BackColor = value;
            }
        }

        [DisplayName("Color de Fondo Seleccionado"), Description("Fondo del item del menú al ser seleccionado"), Category("Item Menu")]
        public Color ItemBackColorSelected
        {
            get;
            set;
        }

        [DisplayName("Seleccionado"), Description("Estado del item al ser seleccionado"), Category("Item Menu")]
        public bool IsSelected
        {
            get 
            {
                return selected;
            }
            set 
            {
                selected = value;
                if (selected)
                {
                    ItemBackColor = this.ItemBackColorSelected;
                    pSelection.BackColor = this.ItemColorSelected;
                }
                else
                {
                    ItemBackColor = ItemDefaultBackColor;
                    pSelection.BackColor = Color.Transparent;
                }
            }
        }
        #endregion

        public MenuItem()
        {
            InitializeComponent();
        }

        private void menuItem_MouseHover(object sender, EventArgs e)
        {
            if (!selected)
            {
                ItemBackColor = this.ItemBackColorSelected;
            }
        }

        private void menuItem_MouseLeave(object sender, EventArgs e)
        {
            if (!selected)
            {
                ItemBackColor = ItemDefaultBackColor;
            }
        }

        public new event EventHandler Click
        {
            add
            {
                foreach (Control control in tlpCont.Controls)
                {
                    control.Click += value;
                    control.Tag = this.ItemId;
                }
            }
            remove
            {
                foreach (Control control in tlpCont.Controls)
                {
                    control.Click -= value;
                }
            }
        }
        
    }
}
