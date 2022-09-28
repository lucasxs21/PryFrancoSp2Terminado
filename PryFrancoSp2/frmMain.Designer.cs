namespace PryFrancoSp2
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcTipo = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lstPersona = new System.Windows.Forms.ComboBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTelevision = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.mrcFormadepago = new System.Windows.Forms.GroupBox();
            this.lstTarjetas = new System.Windows.Forms.ComboBox();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.mrcTitulardereserva = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.mrcTipo.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.mrcFormadepago.SuspendLayout();
            this.mrcTitulardereserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTipo
            // 
            this.mrcTipo.Controls.Add(this.txtDias);
            this.mrcTipo.Controls.Add(this.lstPersona);
            this.mrcTipo.Controls.Add(this.lblDias);
            this.mrcTipo.Controls.Add(this.lblPersonas);
            this.mrcTipo.Controls.Add(this.lblTipo);
            this.mrcTipo.Controls.Add(this.lstTipo);
            this.mrcTipo.Location = new System.Drawing.Point(57, 71);
            this.mrcTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTipo.Name = "mrcTipo";
            this.mrcTipo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTipo.Size = new System.Drawing.Size(740, 123);
            this.mrcTipo.TabIndex = 0;
            this.mrcTipo.TabStop = false;
            this.mrcTipo.Text = "Tipo de cabaña";
            this.mrcTipo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Location = new System.Drawing.Point(576, 58);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(99, 22);
            this.txtDias.TabIndex = 12;
            // 
            // lstPersona
            // 
            this.lstPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPersona.Enabled = false;
            this.lstPersona.FormattingEnabled = true;
            this.lstPersona.Location = new System.Drawing.Point(348, 55);
            this.lstPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPersona.Name = "lstPersona";
            this.lstPersona.Size = new System.Drawing.Size(81, 24);
            this.lstPersona.TabIndex = 7;
            this.lstPersona.SelectedIndexChanged += new System.EventHandler(this.lstPersona_SelectedIndexChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(528, 59);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(35, 16);
            this.lblDias.TabIndex = 6;
            this.lblDias.Text = "Dias";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(263, 62);
            this.lblPersonas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(65, 16);
            this.lblPersonas.TabIndex = 6;
            this.lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(21, 62);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstTipo
            // 
            this.lstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.lstTipo.Location = new System.Drawing.Point(76, 58);
            this.lstTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(81, 24);
            this.lstTipo.TabIndex = 2;
            this.lstTipo.SelectedIndexChanged += new System.EventHandler(this.lstTipo_SelectedIndexChanged);
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(8, 23);
            this.chkCocina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(71, 20);
            this.chkCocina.TabIndex = 4;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(697, 570);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(33, 70);
            this.lblTarjeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(57, 16);
            this.lblTarjeta.TabIndex = 7;
            this.lblTarjeta.Text = "Tarjetas";
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkTelevision);
            this.mrcAdicionales.Controls.Add(this.chkHeladera);
            this.mrcAdicionales.Controls.Add(this.chkCocina);
            this.mrcAdicionales.Location = new System.Drawing.Point(57, 215);
            this.mrcAdicionales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcAdicionales.Size = new System.Drawing.Size(167, 150);
            this.mrcAdicionales.TabIndex = 8;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // chkTelevision
            // 
            this.chkTelevision.AutoSize = true;
            this.chkTelevision.Location = new System.Drawing.Point(8, 118);
            this.chkTelevision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTelevision.Name = "chkTelevision";
            this.chkTelevision.Size = new System.Drawing.Size(92, 20);
            this.chkTelevision.TabIndex = 6;
            this.chkTelevision.Text = "Television";
            this.chkTelevision.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(8, 69);
            this.chkHeladera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(86, 20);
            this.chkHeladera.TabIndex = 5;
            this.chkHeladera.Text = "Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // mrcFormadepago
            // 
            this.mrcFormadepago.Controls.Add(this.lstTarjetas);
            this.mrcFormadepago.Controls.Add(this.optTarjeta);
            this.mrcFormadepago.Controls.Add(this.lblTarjeta);
            this.mrcFormadepago.Controls.Add(this.optEfectivo);
            this.mrcFormadepago.Location = new System.Drawing.Point(296, 215);
            this.mrcFormadepago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcFormadepago.Name = "mrcFormadepago";
            this.mrcFormadepago.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcFormadepago.Size = new System.Drawing.Size(501, 150);
            this.mrcFormadepago.TabIndex = 9;
            this.mrcFormadepago.TabStop = false;
            this.mrcFormadepago.Text = "Forma de pago";
            this.mrcFormadepago.Enter += new System.EventHandler(this.mrcFormadepago_Enter);
            // 
            // lstTarjetas
            // 
            this.lstTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTarjetas.Enabled = false;
            this.lstTarjetas.FormattingEnabled = true;
            this.lstTarjetas.Items.AddRange(new object[] {
            "RED CARD",
            "GREEN CARD",
            "BLUE CARD"});
            this.lstTarjetas.Location = new System.Drawing.Point(37, 94);
            this.lstTarjetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTarjetas.Name = "lstTarjetas";
            this.lstTarjetas.Size = new System.Drawing.Size(324, 24);
            this.lstTarjetas.TabIndex = 8;
            this.lstTarjetas.SelectedIndexChanged += new System.EventHandler(this.lstTarjetas_SelectedIndexChanged);
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(264, 38);
            this.optTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(71, 20);
            this.optTarjeta.TabIndex = 1;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.optTarjeta_CheckedChanged);
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Checked = true;
            this.optEfectivo.Location = new System.Drawing.Point(37, 38);
            this.optEfectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(76, 20);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            // 
            // mrcTitulardereserva
            // 
            this.mrcTitulardereserva.Controls.Add(this.txtTelefono);
            this.mrcTitulardereserva.Controls.Add(this.txtNombre);
            this.mrcTitulardereserva.Controls.Add(this.lblTelefono);
            this.mrcTitulardereserva.Controls.Add(this.lblNombre);
            this.mrcTitulardereserva.Location = new System.Drawing.Point(57, 390);
            this.mrcTitulardereserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTitulardereserva.Name = "mrcTitulardereserva";
            this.mrcTitulardereserva.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTitulardereserva.Size = new System.Drawing.Size(740, 150);
            this.mrcTitulardereserva.TabIndex = 10;
            this.mrcTitulardereserva.TabStop = false;
            this.mrcTitulardereserva.Text = "Titular de la reserva";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(175, 102);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(532, 22);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(175, 44);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(532, 22);
            this.txtNombre.TabIndex = 11;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(52, 102);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 16);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefonos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(52, 44);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 626);
            this.Controls.Add(this.mrcTitulardereserva);
            this.Controls.Add(this.mrcFormadepago);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcTipo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "reserva de cabañas";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mrcTipo.ResumeLayout(false);
            this.mrcTipo.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.mrcFormadepago.ResumeLayout(false);
            this.mrcFormadepago.PerformLayout();
            this.mrcTitulardereserva.ResumeLayout(false);
            this.mrcTitulardereserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox lstPersona;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.CheckBox chkTelevision;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.GroupBox mrcFormadepago;
        private System.Windows.Forms.ComboBox lstTarjetas;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.GroupBox mrcTitulardereserva;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

