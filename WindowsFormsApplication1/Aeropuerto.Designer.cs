namespace WindowsFormsApplication1
{
    partial class Aeropuerto
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnalta = new System.Windows.Forms.ToolStripButton();
            this.btnbaja = new System.Windows.Forms.ToolStripButton();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.btnlimpiar = new System.Windows.Forms.ToolStripButton();
            this.EPerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.DGVAero = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.mtxtcodaero = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAero)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(617, 22);
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
            this.btnalta,
            this.btnbaja,
            this.btnmodificar,
            this.btnlimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(104, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnalta
            // 
            this.btnalta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnalta.Image = global::WindowsFormsApplication1.Properties.Resources.Alta;
            this.btnalta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(23, 22);
            this.btnalta.Text = "Alta";
            this.btnalta.Click += new System.EventHandler(this.btnalta_Click);
            // 
            // btnbaja
            // 
            this.btnbaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbaja.Image = global::WindowsFormsApplication1.Properties.Resources.Baja;
            this.btnbaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(23, 22);
            this.btnbaja.Text = "Baja";
            this.btnbaja.Click += new System.EventHandler(this.btnbaja_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmodificar.Image = global::WindowsFormsApplication1.Properties.Resources.Modificar;
            this.btnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(23, 22);
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnlimpiar.Image = global::WindowsFormsApplication1.Properties.Resources.limpiar;
            this.btnlimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(23, 22);
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // EPerror
            // 
            this.EPerror.ContainerControl = this;
            // 
            // DGVAero
            // 
            this.DGVAero.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.DGVAero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAero.Location = new System.Drawing.Point(264, 70);
            this.DGVAero.Name = "DGVAero";
            this.DGVAero.Size = new System.Drawing.Size(341, 200);
            this.DGVAero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ciudad";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(91, 147);
            this.txtnombre.MaxLength = 19;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(78, 20);
            this.txtnombre.TabIndex = 7;
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(93, 205);
            this.txtciudad.MaxLength = 19;
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(76, 20);
            this.txtciudad.TabIndex = 8;
            // 
            // mtxtcodaero
            // 
            this.mtxtcodaero.Location = new System.Drawing.Point(93, 92);
            this.mtxtcodaero.Mask = ">???";
            this.mtxtcodaero.Name = "mtxtcodaero";
            this.mtxtcodaero.Size = new System.Drawing.Size(39, 20);
            this.mtxtcodaero.TabIndex = 9;
            this.mtxtcodaero.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodigo_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo lleva solo letras";
            // 
            // Aeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(617, 344);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtcodaero);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVAero);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Aeropuerto";
            this.Text = "Aeropuerto";
            this.Load += new System.EventHandler(this.FrmAeropuerto_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnalta;
        private System.Windows.Forms.ToolStripButton btnbaja;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripButton btnlimpiar;
        private System.Windows.Forms.ErrorProvider EPerror;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVAero;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.MaskedTextBox mtxtcodaero;
        private System.Windows.Forms.Label label4;
    }
}