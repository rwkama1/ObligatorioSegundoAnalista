namespace WindowsFormsApplication1
{
    partial class LineasAereas
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnaltalineas = new System.Windows.Forms.ToolStripButton();
            this.btnbajalineas = new System.Windows.Forms.ToolStripButton();
            this.btnmodificarlineas = new System.Windows.Forms.ToolStripButton();
            this.btnlimpiar = new System.Windows.Forms.ToolStripButton();
            this.DGVLineas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsigla = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.btnaltatel = new System.Windows.Forms.Button();
            this.btnbajatel = new System.Windows.Forms.Button();
            this.LBTel = new System.Windows.Forms.ListBox();
            this.mtxttel = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLineas)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnaltalineas,
            this.btnbajalineas,
            this.btnmodificarlineas,
            this.btnlimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(104, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnaltalineas
            // 
            this.btnaltalineas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnaltalineas.Image = global::WindowsFormsApplication1.Properties.Resources.Alta;
            this.btnaltalineas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnaltalineas.Name = "btnaltalineas";
            this.btnaltalineas.Size = new System.Drawing.Size(23, 22);
            this.btnaltalineas.Text = "Alta";
            this.btnaltalineas.Click += new System.EventHandler(this.btnaltalineas_Click);
            // 
            // btnbajalineas
            // 
            this.btnbajalineas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbajalineas.Image = global::WindowsFormsApplication1.Properties.Resources.Baja;
            this.btnbajalineas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbajalineas.Name = "btnbajalineas";
            this.btnbajalineas.Size = new System.Drawing.Size(23, 22);
            this.btnbajalineas.Text = "Baja";
            this.btnbajalineas.Click += new System.EventHandler(this.btnbajalineas_Click);
            // 
            // btnmodificarlineas
            // 
            this.btnmodificarlineas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmodificarlineas.Image = global::WindowsFormsApplication1.Properties.Resources.Modificar;
            this.btnmodificarlineas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificarlineas.Name = "btnmodificarlineas";
            this.btnmodificarlineas.Size = new System.Drawing.Size(23, 22);
            this.btnmodificarlineas.Text = "Modificar";
            this.btnmodificarlineas.Click += new System.EventHandler(this.btnmodificarlineas_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnlimpiar.Image = global::WindowsFormsApplication1.Properties.Resources.limpiar;
            this.btnlimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(23, 22);
            this.btnlimpiar.Text = "Limpiar";
            // 
            // DGVLineas
            // 
            this.DGVLineas.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.DGVLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLineas.Location = new System.Drawing.Point(356, 74);
            this.DGVLineas.Name = "DGVLineas";
            this.DGVLineas.Size = new System.Drawing.Size(269, 220);
            this.DGVLineas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sigla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefonos";
            // 
            // txtsigla
            // 
            this.txtsigla.Location = new System.Drawing.Point(142, 83);
            this.txtsigla.MaxLength = 19;
            this.txtsigla.Name = "txtsigla";
            this.txtsigla.Size = new System.Drawing.Size(85, 20);
            this.txtsigla.TabIndex = 6;
            this.txtsigla.Validating += new System.ComponentModel.CancelEventHandler(this.txtsigla_Validating);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(142, 116);
            this.txtdireccion.MaxLength = 19;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(85, 20);
            this.txtdireccion.TabIndex = 7;
            // 
            // btnaltatel
            // 
            this.btnaltatel.Location = new System.Drawing.Point(251, 156);
            this.btnaltatel.Name = "btnaltatel";
            this.btnaltatel.Size = new System.Drawing.Size(75, 23);
            this.btnaltatel.TabIndex = 9;
            this.btnaltatel.Text = "Alta Tel";
            this.btnaltatel.UseVisualStyleBackColor = true;
            this.btnaltatel.Click += new System.EventHandler(this.btnaltatel_Click);
            // 
            // btnbajatel
            // 
            this.btnbajatel.Location = new System.Drawing.Point(238, 223);
            this.btnbajatel.Name = "btnbajatel";
            this.btnbajatel.Size = new System.Drawing.Size(75, 23);
            this.btnbajatel.TabIndex = 10;
            this.btnbajatel.Text = "Baja Tel";
            this.btnbajatel.UseVisualStyleBackColor = true;
            this.btnbajatel.Click += new System.EventHandler(this.btnbajatel_Click);
            // 
            // LBTel
            // 
            this.LBTel.FormattingEnabled = true;
            this.LBTel.Location = new System.Drawing.Point(26, 198);
            this.LBTel.Name = "LBTel";
            this.LBTel.Size = new System.Drawing.Size(163, 121);
            this.LBTel.TabIndex = 11;
            // 
            // mtxttel
            // 
            this.mtxttel.Location = new System.Drawing.Point(127, 153);
            this.mtxttel.Mask = "9999999999";
            this.mtxttel.Name = "mtxttel";
            this.mtxttel.Size = new System.Drawing.Size(100, 20);
            this.mtxttel.TabIndex = 12;
            // 
            // LineasAereas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(669, 386);
            this.Controls.Add(this.mtxttel);
            this.Controls.Add(this.LBTel);
            this.Controls.Add(this.btnbajatel);
            this.Controls.Add(this.btnaltatel);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtsigla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVLineas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "LineasAereas";
            this.Text = "LineasAereas";
            this.Load += new System.EventHandler(this.FrmLineas_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnaltalineas;
        private System.Windows.Forms.ToolStripButton btnbajalineas;
        private System.Windows.Forms.ToolStripButton btnmodificarlineas;
        private System.Windows.Forms.ToolStripButton btnlimpiar;
        private System.Windows.Forms.DataGridView DGVLineas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsigla;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Button btnaltatel;
        private System.Windows.Forms.Button btnbajatel;
        private System.Windows.Forms.ListBox LBTel;
        private System.Windows.Forms.MaskedTextBox mtxttel;
    }
}