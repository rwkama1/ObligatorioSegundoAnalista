namespace WindowsFormsApplication1
{
    partial class ListadoGeneralVuelos
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
            this.CBlineasF = new System.Windows.Forms.ComboBox();
            this.CBconjunto = new System.Windows.Forms.ComboBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnlineas = new System.Windows.Forms.Button();
            this.btnconjunto = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtreserva = new System.Windows.Forms.MaskedTextBox();
            this.mtxtfecha = new System.Windows.Forms.MaskedTextBox();
            this.btnreserva = new System.Windows.Forms.Button();
            this.btnfecha = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DGVVuelo = new System.Windows.Forms.DataGridView();
            this.CodVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AeropuertoSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aeropuertollegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // CBlineasF
            // 
            this.CBlineasF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBlineasF.FormattingEnabled = true;
            this.CBlineasF.Location = new System.Drawing.Point(41, 161);
            this.CBlineasF.Name = "CBlineasF";
            this.CBlineasF.Size = new System.Drawing.Size(121, 21);
            this.CBlineasF.TabIndex = 0;
            // 
            // CBconjunto
            // 
            this.CBconjunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBconjunto.FormattingEnabled = true;
            this.CBconjunto.Items.AddRange(new object[] {
            "Filtrar por Linea",
            "Filtrar por Cantidad Reservas",
            "Filtrar por Fecha"});
            this.CBconjunto.Location = new System.Drawing.Point(41, 212);
            this.CBconjunto.Name = "CBconjunto";
            this.CBconjunto.Size = new System.Drawing.Size(140, 21);
            this.CBconjunto.TabIndex = 1;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(423, 56);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(103, 28);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "LimpiarFiltro";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnlineas
            // 
            this.btnlineas.Location = new System.Drawing.Point(233, 159);
            this.btnlineas.Name = "btnlineas";
            this.btnlineas.Size = new System.Drawing.Size(96, 23);
            this.btnlineas.TabIndex = 5;
            this.btnlineas.Text = "Linea Aerea";
            this.btnlineas.UseVisualStyleBackColor = true;
            this.btnlineas.Click += new System.EventHandler(this.btnlineas_Click);
            // 
            // btnconjunto
            // 
            this.btnconjunto.Location = new System.Drawing.Point(218, 212);
            this.btnconjunto.Name = "btnconjunto";
            this.btnconjunto.Size = new System.Drawing.Size(130, 23);
            this.btnconjunto.TabIndex = 9;
            this.btnconjunto.Text = "FiltrarConjunto";
            this.btnconjunto.UseVisualStyleBackColor = true;
            this.btnconjunto.Click += new System.EventHandler(this.btnconjunto_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(738, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "FiltrarReserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "FiltrarFecha";
            // 
            // mtxtreserva
            // 
            this.mtxtreserva.Location = new System.Drawing.Point(115, 44);
            this.mtxtreserva.Mask = "99999";
            this.mtxtreserva.Name = "mtxtreserva";
            this.mtxtreserva.Size = new System.Drawing.Size(100, 20);
            this.mtxtreserva.TabIndex = 16;
            this.mtxtreserva.ValidatingType = typeof(int);
            // 
            // mtxtfecha
            // 
            this.mtxtfecha.Location = new System.Drawing.Point(115, 95);
            this.mtxtfecha.Mask = "00/00/0000";
            this.mtxtfecha.Name = "mtxtfecha";
            this.mtxtfecha.Size = new System.Drawing.Size(100, 20);
            this.mtxtfecha.TabIndex = 17;
            this.mtxtfecha.ValidatingType = typeof(System.DateTime);
            // 
            // btnreserva
            // 
            this.btnreserva.Location = new System.Drawing.Point(273, 41);
            this.btnreserva.Name = "btnreserva";
            this.btnreserva.Size = new System.Drawing.Size(88, 23);
            this.btnreserva.TabIndex = 18;
            this.btnreserva.Text = "CantReserva";
            this.btnreserva.UseVisualStyleBackColor = true;
            this.btnreserva.Click += new System.EventHandler(this.btnreserva_Click);
            // 
            // btnfecha
            // 
            this.btnfecha.Location = new System.Drawing.Point(273, 95);
            this.btnfecha.Name = "btnfecha";
            this.btnfecha.Size = new System.Drawing.Size(75, 23);
            this.btnfecha.TabIndex = 19;
            this.btnfecha.Text = "Fecha";
            this.btnfecha.UseVisualStyleBackColor = true;
            this.btnfecha.Click += new System.EventHandler(this.btnfecha_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.Aeropuertollegada,
            this.CantReservas});
            this.DGVVuelo.Location = new System.Drawing.Point(0, 309);
            this.DGVVuelo.Name = "DGVVuelo";
            this.DGVVuelo.ReadOnly = true;
            this.DGVVuelo.Size = new System.Drawing.Size(726, 172);
            this.DGVVuelo.TabIndex = 20;
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
            // CantReservas
            // 
            this.CantReservas.DataPropertyName = "CantReservas";
            this.CantReservas.HeaderText = "CantReservas";
            this.CantReservas.Name = "CantReservas";
            this.CantReservas.ReadOnly = true;
            // 
            // ListadoGeneralVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(738, 525);
            this.Controls.Add(this.DGVVuelo);
            this.Controls.Add(this.btnfecha);
            this.Controls.Add(this.btnreserva);
            this.Controls.Add(this.mtxtfecha);
            this.Controls.Add(this.mtxtreserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnconjunto);
            this.Controls.Add(this.btnlineas);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.CBconjunto);
            this.Controls.Add(this.CBlineasF);
            this.Name = "ListadoGeneralVuelos";
            this.Text = "ListadoGeneralVuelos";
            this.Load += new System.EventHandler(this.FrmListadoGVuelos_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVuelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBlineasF;
        private System.Windows.Forms.ComboBox CBconjunto;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnlineas;
        private System.Windows.Forms.Button btnconjunto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtfecha;
        private System.Windows.Forms.MaskedTextBox mtxtreserva;
        private System.Windows.Forms.Button btnreserva;
        private System.Windows.Forms.Button btnfecha;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView DGVVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn AeropuertoSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aeropuertollegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantReservas;
    }
}