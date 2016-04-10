namespace DentalCenter.Views
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lAplicationName = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpStatusBar = new System.Windows.Forms.TableLayoutPanel();
            this.lStatusText = new System.Windows.Forms.Label();
            this.lReloj = new System.Windows.Forms.Label();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pInfoUser = new System.Windows.Forms.Panel();
            this.msUserOption = new System.Windows.Forms.MenuStrip();
            this.userOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pContSectionName = new System.Windows.Forms.Panel();
            this.lSectionName = new System.Windows.Forms.Label();
            this.flpTopbarOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.pContent = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tlpMain.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.tlpContent.SuspendLayout();
            this.tlpStatusBar.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.pInfoUser.SuspendLayout();
            this.msUserOption.SuspendLayout();
            this.pContSectionName.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            resources.ApplyResources(this.tlpMain, "tlpMain");
            this.tlpMain.Controls.Add(this.flpMenu, 0, 0);
            this.tlpMain.Controls.Add(this.tlpContent, 1, 0);
            this.tlpMain.Name = "tlpMain";
            // 
            // flpMenu
            // 
            resources.ApplyResources(this.flpMenu, "flpMenu");
            this.flpMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.flpMenu.Controls.Add(this.panel2);
            this.flpMenu.Name = "flpMenu";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.lAplicationName);
            this.panel2.Controls.Add(this.lUserName);
            this.panel2.Controls.Add(this.pbUserImage);
            this.panel2.Name = "panel2";
            // 
            // lAplicationName
            // 
            resources.ApplyResources(this.lAplicationName, "lAplicationName");
            this.lAplicationName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lAplicationName.Name = "lAplicationName";
            // 
            // lUserName
            // 
            this.lUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lUserName, "lUserName");
            this.lUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lUserName.Name = "lUserName";
            // 
            // pbUserImage
            // 
            this.pbUserImage.Image = global::DentalCenter.Properties.Resources.home;
            resources.ApplyResources(this.pbUserImage, "pbUserImage");
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.TabStop = false;
            // 
            // tlpContent
            // 
            resources.ApplyResources(this.tlpContent, "tlpContent");
            this.tlpContent.Controls.Add(this.tlpStatusBar, 0, 2);
            this.tlpContent.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpContent.Controls.Add(this.pContent, 0, 1);
            this.tlpContent.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpContent.Name = "tlpContent";
            // 
            // tlpStatusBar
            // 
            resources.ApplyResources(this.tlpStatusBar, "tlpStatusBar");
            this.tlpStatusBar.Controls.Add(this.lStatusText, 0, 0);
            this.tlpStatusBar.Controls.Add(this.lReloj, 1, 0);
            this.tlpStatusBar.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpStatusBar.Name = "tlpStatusBar";
            // 
            // lStatusText
            // 
            resources.ApplyResources(this.lStatusText, "lStatusText");
            this.lStatusText.Name = "lStatusText";
            // 
            // lReloj
            // 
            resources.ApplyResources(this.lReloj, "lReloj");
            this.lReloj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lReloj.Name = "lReloj";
            // 
            // tlpHeader
            // 
            resources.ApplyResources(this.tlpHeader, "tlpHeader");
            this.tlpHeader.Controls.Add(this.pInfoUser, 2, 0);
            this.tlpHeader.Controls.Add(this.pContSectionName, 0, 0);
            this.tlpHeader.Controls.Add(this.flpTopbarOptions, 1, 0);
            this.tlpHeader.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpHeader.Name = "tlpHeader";
            // 
            // pInfoUser
            // 
            this.pInfoUser.Controls.Add(this.msUserOption);
            resources.ApplyResources(this.pInfoUser, "pInfoUser");
            this.pInfoUser.Name = "pInfoUser";
            // 
            // msUserOption
            // 
            this.msUserOption.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.msUserOption, "msUserOption");
            this.msUserOption.GripMargin = new System.Windows.Forms.Padding(0);
            this.msUserOption.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.msUserOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userOptions});
            this.msUserOption.Name = "msUserOption";
            // 
            // userOptions
            // 
            this.userOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.userOptions, "userOptions");
            this.userOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarPerfilToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.userOptions.Image = global::DentalCenter.Properties.Resources.home1;
            this.userOptions.Name = "userOptions";
            this.userOptions.Padding = new System.Windows.Forms.Padding(0);
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.editarPerfilToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.editarPerfilToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.editarPerfilToolStripMenuItem, "editarPerfilToolStripMenuItem");
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cerrarSesiónToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cerrarSesiónToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.cerrarSesiónToolStripMenuItem, "cerrarSesiónToolStripMenuItem");
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            // 
            // pContSectionName
            // 
            this.pContSectionName.Controls.Add(this.lSectionName);
            resources.ApplyResources(this.pContSectionName, "pContSectionName");
            this.pContSectionName.Name = "pContSectionName";
            // 
            // lSectionName
            // 
            resources.ApplyResources(this.lSectionName, "lSectionName");
            this.lSectionName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lSectionName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lSectionName.Name = "lSectionName";
            // 
            // flpTopbarOptions
            // 
            resources.ApplyResources(this.flpTopbarOptions, "flpTopbarOptions");
            this.flpTopbarOptions.Name = "flpTopbarOptions";
            // 
            // pContent
            // 
            resources.ApplyResources(this.pContent, "pContent");
            this.pContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pContent.Name = "pContent";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msUserOption;
            this.Name = "FrmMain";
            this.tlpMain.ResumeLayout(false);
            this.flpMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.tlpContent.ResumeLayout(false);
            this.tlpContent.PerformLayout();
            this.tlpStatusBar.ResumeLayout(false);
            this.tlpStatusBar.PerformLayout();
            this.tlpHeader.ResumeLayout(false);
            this.pInfoUser.ResumeLayout(false);
            this.pInfoUser.PerformLayout();
            this.msUserOption.ResumeLayout(false);
            this.msUserOption.PerformLayout();
            this.pContSectionName.ResumeLayout(false);
            this.pContSectionName.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpStatusBar;
        private System.Windows.Forms.Label lStatusText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lReloj;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Panel pInfoUser;
        private System.Windows.Forms.MenuStrip msUserOption;
        private System.Windows.Forms.ToolStripMenuItem userOptions;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
        private System.Windows.Forms.Panel pContSectionName;
        private System.Windows.Forms.Label lSectionName;
        private System.Windows.Forms.FlowLayoutPanel flpTopbarOptions;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Label lAplicationName;
        public System.Windows.Forms.Panel pContent;
    }
}



