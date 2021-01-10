namespace WindowsFormsApplication1
{
    partial class Vuelos
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
            this.btnaltavuelo = new System.Windows.Forms.ToolStripButton();
            this.btnbajavuelo = new System.Windows.Forms.ToolStripButton();
            this.btnmodificarvuelo = new System.Windows.Forms.ToolStripButton();
            this.btnlimpiarvuelo = new System.Windows.Forms.ToolStripButton();
            this.DGVVuelo = new System.Windows.Forms.DataGridView();
            this.CodVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AeropuertoSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aeropuertollegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBLineas = new System.Windows.Forms.ComboBox();
            this.mtxtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtfechahora = new System.Windows.Forms.MaskedTextBox();
            this.mtxtcantasientos = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CBAeroSalida = new System.Windows.Forms.ComboBox();
            this.CBAerollegada = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVuelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
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
            this.btnaltavuelo,
            this.btnbajavuelo,
            this.btnmodificarvuelo,
            this.btnlimpiarvuelo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(104, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnaltavuelo
            // 
            this.btnaltavuelo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnaltavuelo.Image = global::WindowsFormsApplication1.Properties.Resources.Alta;
            this.btnaltavuelo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnaltavuelo.Name = "btnaltavuelo";
            this.btnaltavuelo.Size = new System.Drawing.Size(23, 22);
            this.btnaltavuelo.Text = "Alta";
            this.btnaltavuelo.Click += new System.EventHandler(this.btnaltavuelo_Click);
            // 
            // btnbajavuelo
            // 
            this.btnbajavuelo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbajavuelo.Image = global::WindowsFormsApplication1.Properties.Resources.Baja;
            this.btnbajavuelo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbajavuelo.Name = "btnbajavuelo";
            this.btnbajavuelo.Size = new System.Drawing.Size(23, 22);
            this.btnbajavuelo.Text = "Baja";
            this.btnbajavuelo.Click += new System.EventHandler(this.btnbajavuelo_Click);
            // 
            // btnmodificarvuelo
            // 
            this.btnmodificarvuelo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmodificarvuelo.Image = global::WindowsFormsApplication1.Properties.Resources.Modificar;
            this.btnmodificarvuelo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificarvuelo.Name = "btnmodificarvuelo";
            this.btnmodificarvuelo.Size = new System.Drawing.Size(23, 22);
            this.btnmodificarvuelo.Text = "Modificar";
            this.btnmodificarvuelo.Click += new System.EventHandler(this.btnmodificarvuelo_Click);
            // 
            // btnlimpiarvuelo
            // 
            this.btnlimpiarvuelo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnlimpiarvuelo.Image = global::WindowsFormsApplication1.Properties.Resources.limpiar;
            this.btnlimpiarvuelo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlimpiarvuelo.Name = "btnlimpiarvuelo";
            this.btnlimpiarvuelo.Size = new System.Drawing.Size(23, 22);
            this.btnlimpiarvuelo.Text = "Limpiar";
            this.btnlimpiarvuelo.Click += new System.EventHandler(this.btnlimpiarvuelo_Click);
            // 
            // DGVVuelo
            // 
            this.DGVVuelo.AllowUserToAddRows = false;
            this.DGVVuelo.AllowUserToDeleteRows = false;
            this.DGVVuelo.AllowUserToOrderColumns = true;
            this.DGVVuelo.AllowUserToResizeColumns = false;
            this.DGVVuelo.AllowUserToResizeRows = false;
            this.DGVVuelo.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.DGVVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVuelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodVuelo,
            this.FechaHora,
            this.Asientos,
            this.Linea,
            this.AeropuertoSalida,
            this.Aeropuertollegada});
            this.DGVVuelo.Location = new System.Drawing.Point(12, 279);
            this.DGVVuelo.Name = "DGVVuelo";
            this.DGVVuelo.ReadOnly = true;
            this.DGVVuelo.Size = new System.Drawing.Size(752, 172);
            this.DGVVuelo.TabIndex = 2;
            // 
            // CodVuelo
            // 
            this.CodVuelo.DataPropertyName = "CodVuelo";
            this.CodVuelo.HeaderText = "CodVuelo";
            this.CodVuelo.Name = "CodVuelo";
            this.CodVuelo.ReadOnly = true;
            // 
            // FechaHora
            // 
            this.FechaHora.DataPropertyName = "FechaHora";
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            // 
            // Asientos
            // 
            this.Asientos.DataPropertyName = "Asientos";
            this.Asientos.HeaderText = "Asientos";
            this.Asientos.Name = "Asientos";
            this.Asientos.ReadOnly = true;
            // 
            // Linea
            // 
            this.Linea.DataPropertyName = "SiglaLinea";
            this.Linea.HeaderText = "Linea";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            // 
            // AeropuertoSalida
            // 
            this.AeropuertoSalida.DataPropertyName = "CodAeropuertoSalida";
            this.AeropuertoSalida.HeaderText = "AeropuertoSalida";
            this.AeropuertoSalida.Name = "AeropuertoSalida";
            this.AeropuertoSalida.ReadOnly = true;
            // 
            // Aeropuertollegada
            // 
            this.Aeropuertollegada.DataPropertyName = "CodAeropuertoLlegada";
            this.Aeropuertollegada.HeaderText = "Aeropuertollegada";
            this.Aeropuertollegada.Name = "Aeropuertollegada";
            this.Aeropuertollegada.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FechaHora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Linea Aerea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "AeropuertoLLegada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "AeropuertoSalida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Asientos";
            // 
            // CBLineas
            // 
            this.CBLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLineas.FormattingEnabled = true;
            this.CBLineas.Location = new System.Drawing.Point(132, 232);
            this.CBLineas.Name = "CBLineas";
            this.CBLineas.Size = new System.Drawing.Size(121, 21);
            this.CBLineas.TabIndex = 14;
            // 
            // mtxtCodigo
            // 
            this.mtxtCodigo.Location = new System.Drawing.Point(145, 68);
            this.mtxtCodigo.Mask = ">??????999999999999";
            this.mtxtCodigo.Name = "mtxtCodigo";
            this.mtxtCodigo.Size = new System.Drawing.Size(119, 20);
            this.mtxtCodigo.TabIndex = 15;
            this.mtxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodigo_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Codigo lleva 6 letras y 12 Numeros";
            // 
            // mtxtfechahora
            // 
            this.mtxtfechahora.Location = new System.Drawing.Point(132, 120);
            this.mtxtfechahora.Name = "mtxtfechahora";
            this.mtxtfechahora.ReadOnly = true;
            this.mtxtfechahora.Size = new System.Drawing.Size(105, 20);
            this.mtxtfechahora.TabIndex = 17;
            // 
            // mtxtcantasientos
            // 
            this.mtxtcantasientos.Location = new System.Drawing.Point(145, 146);
            this.mtxtcantasientos.Mask = "99999";
            this.mtxtcantasientos.Name = "mtxtcantasientos";
            this.mtxtcantasientos.Size = new System.Drawing.Size(44, 20);
            this.mtxtcantasientos.TabIndex = 18;
            this.mtxtcantasientos.ValidatingType = typeof(int);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CBAeroSalida
            // 
            this.CBAeroSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAeroSalida.FormattingEnabled = true;
            this.CBAeroSalida.Location = new System.Drawing.Point(145, 170);
            this.CBAeroSalida.Name = "CBAeroSalida";
            this.CBAeroSalida.Size = new System.Drawing.Size(61, 21);
            this.CBAeroSalida.TabIndex = 19;
            // 
            // CBAerollegada
            // 
            this.CBAerollegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAerollegada.FormattingEnabled = true;
            this.CBAerollegada.Location = new System.Drawing.Point(145, 197);
            this.CBAerollegada.Name = "CBAerollegada";
            this.CBAerollegada.Size = new System.Drawing.Size(74, 21);
            this.CBAerollegada.TabIndex = 20;
            // 
            // Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(786, 512);
            this.Controls.Add(this.CBAerollegada);
            this.Controls.Add(this.CBAeroSalida);
            this.Controls.Add(this.mtxtcantasientos);
            this.Controls.Add(this.mtxtfechahora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtxtCodigo);
            this.Controls.Add(this.CBLineas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVVuelo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Vuelos";
            this.Text = "Vuelos";
            this.Load += new System.EventHandler(this.FrmVuelos_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVuelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnaltavuelo;
        private System.Windows.Forms.ToolStripButton btnbajavuelo;
        private System.Windows.Forms.ToolStripButton btnmodificarvuelo;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.ToolStripButton btnlimpiarvuelo;
        private System.Windows.Forms.DataGridView DGVVuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBLineas;
        private System.Windows.Forms.MaskedTextBox mtxtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtfechahora;
        private System.Windows.Forms.MaskedTextBox mtxtcantasientos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn AeropuertoSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aeropuertollegada;
        private System.Windows.Forms.ComboBox CBAeroSalida;
        private System.Windows.Forms.ComboBox CBAerollegada;
    }
}