namespace WindowsFormsApplication1
{
    partial class AutorizacionReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizacionReservas));
            this.DGVPendientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnactalizar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtasiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnautorizar = new System.Windows.Forms.Button();
            this.txtvuelo = new System.Windows.Forms.TextBox();
            this.btnRechazado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPendientes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVPendientes
            // 
            this.DGVPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DGVPendientes.Location = new System.Drawing.Point(12, 50);
            this.DGVPendientes.Name = "DGVPendientes";
            this.DGVPendientes.Size = new System.Drawing.Size(445, 217);
            this.DGVPendientes.TabIndex = 2;
            this.DGVPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPendientes_CellContentClick);
            this.DGVPendientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPendientes_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodVuelo";
            this.Column1.HeaderText = "Vuelo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CodAeropuertoSalida";
            this.Column2.HeaderText = "AeroSalida";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CodAeropuertoLlegada";
            this.Column3.HeaderText = "AeroLlegada";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FechaHora";
            this.Column4.HeaderText = "FechaHora";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnactalizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnactalizar
            // 
            this.btnactalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnactalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactalizar.Image")));
            this.btnactalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnactalizar.Name = "btnactalizar";
            this.btnactalizar.Size = new System.Drawing.Size(23, 22);
            this.btnactalizar.Text = "Cargar Grilla";
            this.btnactalizar.Click += new System.EventHandler(this.btnactalizar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 353);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Asiento";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(557, 111);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(103, 20);
            this.txtcliente.TabIndex = 8;
            // 
            // txtasiento
            // 
            this.txtasiento.Location = new System.Drawing.Point(557, 150);
            this.txtasiento.Name = "txtasiento";
            this.txtasiento.ReadOnly = true;
            this.txtasiento.Size = new System.Drawing.Size(47, 20);
            this.txtasiento.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Autorizar Reserva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vuelo";
            // 
            // btnautorizar
            // 
            this.btnautorizar.Enabled = false;
            this.btnautorizar.Location = new System.Drawing.Point(497, 207);
            this.btnautorizar.Name = "btnautorizar";
            this.btnautorizar.Size = new System.Drawing.Size(75, 23);
            this.btnautorizar.TabIndex = 12;
            this.btnautorizar.Text = "Autorizar";
            this.btnautorizar.UseVisualStyleBackColor = true;
            this.btnautorizar.Click += new System.EventHandler(this.btnautorizar_Click);
            // 
            // txtvuelo
            // 
            this.txtvuelo.Location = new System.Drawing.Point(557, 67);
            this.txtvuelo.Name = "txtvuelo";
            this.txtvuelo.ReadOnly = true;
            this.txtvuelo.Size = new System.Drawing.Size(160, 20);
            this.txtvuelo.TabIndex = 13;
            // 
            // btnRechazado
            // 
            this.btnRechazado.Enabled = false;
            this.btnRechazado.Location = new System.Drawing.Point(618, 207);
            this.btnRechazado.Name = "btnRechazado";
            this.btnRechazado.Size = new System.Drawing.Size(75, 23);
            this.btnRechazado.TabIndex = 14;
            this.btnRechazado.Text = "Rechazar";
            this.btnRechazado.UseVisualStyleBackColor = true;
            this.btnRechazado.Click += new System.EventHandler(this.btnRechazado_Click);
            // 
            // AutorizacionReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 375);
            this.Controls.Add(this.btnRechazado);
            this.Controls.Add(this.txtvuelo);
            this.Controls.Add(this.btnautorizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtasiento);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVPendientes);
            this.Name = "AutorizacionReservas";
            this.Text = "AutorizacionReservas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutorizacionReservas_FormClosing);
            this.Load += new System.EventHandler(this.AutorizacionReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPendientes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPendientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnactalizar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtasiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnautorizar;
        private System.Windows.Forms.TextBox txtvuelo;
        private System.Windows.Forms.Button btnRechazado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

    }
}