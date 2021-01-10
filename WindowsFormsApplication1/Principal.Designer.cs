namespace WindowsFormsApplication1
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineasAereasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aeropuertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaGeneralVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizacionReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.autorizacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(201, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vueloToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.lineasAereasToolStripMenuItem,
            this.aeropuertosToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // vueloToolStripMenuItem
            // 
            this.vueloToolStripMenuItem.Name = "vueloToolStripMenuItem";
            this.vueloToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.vueloToolStripMenuItem.Text = "Vuelo";
            this.vueloToolStripMenuItem.Click += new System.EventHandler(this.vueloToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // lineasAereasToolStripMenuItem
            // 
            this.lineasAereasToolStripMenuItem.Name = "lineasAereasToolStripMenuItem";
            this.lineasAereasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.lineasAereasToolStripMenuItem.Text = "Lineas Aereas";
            this.lineasAereasToolStripMenuItem.Click += new System.EventHandler(this.lineasAereasToolStripMenuItem_Click);
            // 
            // aeropuertosToolStripMenuItem
            // 
            this.aeropuertosToolStripMenuItem.Name = "aeropuertosToolStripMenuItem";
            this.aeropuertosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aeropuertosToolStripMenuItem.Text = "Aeropuertos";
            this.aeropuertosToolStripMenuItem.Click += new System.EventHandler(this.aeropuertosToolStripMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaGeneralVuelosToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // listaGeneralVuelosToolStripMenuItem
            // 
            this.listaGeneralVuelosToolStripMenuItem.Name = "listaGeneralVuelosToolStripMenuItem";
            this.listaGeneralVuelosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.listaGeneralVuelosToolStripMenuItem.Text = "ListaGeneralVuelos";
            this.listaGeneralVuelosToolStripMenuItem.Click += new System.EventHandler(this.listaGeneralVuelosToolStripMenuItem_Click);
            // 
            // autorizacionToolStripMenuItem
            // 
            this.autorizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorizacionReservasToolStripMenuItem});
            this.autorizacionToolStripMenuItem.Name = "autorizacionToolStripMenuItem";
            this.autorizacionToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.autorizacionToolStripMenuItem.Text = "Autorizacion";
            // 
            // autorizacionReservasToolStripMenuItem
            // 
            this.autorizacionReservasToolStripMenuItem.Name = "autorizacionReservasToolStripMenuItem";
            this.autorizacionReservasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.autorizacionReservasToolStripMenuItem.Text = "AutorizacionReservas";
            this.autorizacionReservasToolStripMenuItem.Click += new System.EventHandler(this.autorizacionReservasToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(470, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineasAereasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aeropuertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaGeneralVuelosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem autorizacionReservasToolStripMenuItem;
    }
}