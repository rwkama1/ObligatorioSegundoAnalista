namespace WindowsFormsApplication1
{
    partial class Adiministrador
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
            this.btnalta = new System.Windows.Forms.ToolStripButton();
            this.btnbaja = new System.Windows.Forms.ToolStripButton();
            this.btnmod = new System.Windows.Forms.ToolStripButton();
            this.btnlimpiar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.chcGenera = new System.Windows.Forms.CheckBox();
            this.mtxtndoc = new System.Windows.Forms.MaskedTextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(427, 22);
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
            this.btnmod,
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
            // btnmod
            // 
            this.btnmod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmod.Image = global::WindowsFormsApplication1.Properties.Resources.Modificar;
            this.btnmod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(23, 22);
            this.btnmod.Text = "Modificar";
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(27, 189);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "GeneraVuelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuario";
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(119, 113);
            this.txtusu.MaxLength = 20;
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(100, 20);
            this.txtusu.TabIndex = 9;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(119, 189);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 11;
            // 
            // chcGenera
            // 
            this.chcGenera.AutoSize = true;
            this.chcGenera.Location = new System.Drawing.Point(119, 227);
            this.chcGenera.Name = "chcGenera";
            this.chcGenera.Size = new System.Drawing.Size(137, 17);
            this.chcGenera.TabIndex = 12;
            this.chcGenera.Text = "El admin genera vuelo?";
            this.chcGenera.UseVisualStyleBackColor = true;
            // 
            // mtxtndoc
            // 
            this.mtxtndoc.Location = new System.Drawing.Point(121, 74);
            this.mtxtndoc.Mask = "999999999";
            this.mtxtndoc.Name = "mtxtndoc";
            this.mtxtndoc.Size = new System.Drawing.Size(71, 20);
            this.mtxtndoc.TabIndex = 13;
            this.mtxtndoc.Validating += new System.ComponentModel.CancelEventHandler(this.txtndoc_Validating);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(119, 150);
            this.txtcontraseña.MaxLength = 8;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseña.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contraseña debe tener 8 caracteres";
            // 
            // Adiministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(427, 343);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtndoc);
            this.Controls.Add(this.chcGenera);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Adiministrador";
            this.Text = "Adiministrador";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnalta;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.ToolStripButton btnbaja;
        private System.Windows.Forms.ToolStripButton btnmod;
        private System.Windows.Forms.ToolStripButton btnlimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.CheckBox chcGenera;
        private System.Windows.Forms.MaskedTextBox mtxtndoc;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label4;
    }
}