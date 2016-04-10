namespace DentalCenter.Views
{
    partial class MenuItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItem));
            this.lTextMenuItem = new System.Windows.Forms.Label();
            this.ImageMenuItem = new System.Windows.Forms.PictureBox();
            this.tlpCont = new System.Windows.Forms.TableLayoutPanel();
            this.pSelection = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMenuItem)).BeginInit();
            this.tlpCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTextMenuItem
            // 
            this.lTextMenuItem.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lTextMenuItem, "lTextMenuItem");
            this.lTextMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lTextMenuItem.Name = "lTextMenuItem";
            this.lTextMenuItem.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            this.lTextMenuItem.MouseHover += new System.EventHandler(this.menuItem_MouseHover);
            // 
            // ImageMenuItem
            // 
            this.ImageMenuItem.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ImageMenuItem, "ImageMenuItem");
            this.ImageMenuItem.Name = "ImageMenuItem";
            this.ImageMenuItem.TabStop = false;
            this.ImageMenuItem.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            this.ImageMenuItem.MouseHover += new System.EventHandler(this.menuItem_MouseHover);
            // 
            // tlpCont
            // 
            resources.ApplyResources(this.tlpCont, "tlpCont");
            this.tlpCont.Controls.Add(this.pSelection, 2, 0);
            this.tlpCont.Controls.Add(this.lTextMenuItem, 1, 0);
            this.tlpCont.Controls.Add(this.ImageMenuItem, 0, 0);
            this.tlpCont.Name = "tlpCont";
            // 
            // pSelection
            // 
            resources.ApplyResources(this.pSelection, "pSelection");
            this.pSelection.Name = "pSelection";
            // 
            // MenuItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpCont);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "MenuItem";
            this.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.menuItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.ImageMenuItem)).EndInit();
            this.tlpCont.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageMenuItem;
        private System.Windows.Forms.Label lTextMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpCont;
        private System.Windows.Forms.Panel pSelection;
    }
}
