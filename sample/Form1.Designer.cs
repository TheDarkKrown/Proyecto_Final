namespace sample
{
    partial class Menu
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
            this.btnreiniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbocortes = new System.Windows.Forms.ComboBox();
            this.cbopersonal = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmayor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbohora = new System.Windows.Forms.ComboBox();
            this.cbomin = new System.Windows.Forms.ComboBox();
            this.btnMenor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.DateTimePicker();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblBarbero = new System.Windows.Forms.Label();
            this.Lbfecha = new System.Windows.Forms.Label();
            this.Lbprecio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.BackColor = System.Drawing.Color.Red;
            this.btnreiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreiniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnreiniciar.Location = new System.Drawing.Point(72, 418);
            this.btnreiniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.Size = new System.Drawing.Size(112, 35);
            this.btnreiniciar.TabIndex = 0;
            this.btnreiniciar.Text = "Cancelar";
            this.btnreiniciar.UseVisualStyleBackColor = false;
            this.btnreiniciar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione corte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Elige el barbero";
            // 
            // cbocortes
            // 
            this.cbocortes.FormattingEnabled = true;
            this.cbocortes.Items.AddRange(new object[] {
            "",
            "High Fade",
            "Mid Fade",
            "Low Fade",
            "Taper Fade",
            "Buzz",
            "Militar",
            "High Mullet",
            "Mid Mullet",
            "Undercut"});
            this.cbocortes.Location = new System.Drawing.Point(590, 78);
            this.cbocortes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbocortes.Name = "cbocortes";
            this.cbocortes.Size = new System.Drawing.Size(180, 28);
            this.cbocortes.TabIndex = 6;
            this.cbocortes.SelectedIndexChanged += new System.EventHandler(this.cbocortes_SelectedIndexChanged);
            // 
            // cbopersonal
            // 
            this.cbopersonal.FormattingEnabled = true;
            this.cbopersonal.Items.AddRange(new object[] {
            "",
            "Enger",
            "Samuel",
            "Carlos",
            "Luis"});
            this.cbopersonal.Location = new System.Drawing.Point(339, 78);
            this.cbopersonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbopersonal.Name = "cbopersonal";
            this.cbopersonal.Size = new System.Drawing.Size(180, 28);
            this.cbopersonal.TabIndex = 8;
            this.cbopersonal.SelectedIndexChanged += new System.EventHandler(this.cbopersonal_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Location = new System.Drawing.Point(208, 418);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 35);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(1058, 669);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(75, 78);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(148, 26);
            this.txtnombre.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 11.25F);
            this.label4.Location = new System.Drawing.Point(98, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 11.25F);
            this.label5.Location = new System.Drawing.Point(81, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 27);
            this.label5.TabIndex = 15;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Location = new System.Drawing.Point(1062, 29);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(49, 20);
            this.lblfecha.TabIndex = 17;
            this.lblfecha.Text = "          ";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 35);
            this.label8.TabIndex = 18;
            this.label8.Text = "Agende su cita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(543, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Precio";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.BackColor = System.Drawing.Color.Silver;
            this.lblprecio.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(528, 292);
            this.lblprecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(93, 29);
            this.lblprecio.TabIndex = 20;
            this.lblprecio.Text = "          ";
            this.lblprecio.Click += new System.EventHandler(this.lblprecio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnmayor);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbohora);
            this.groupBox1.Controls.Add(this.cbomin);
            this.groupBox1.Controls.Add(this.btnMenor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Calendar);
            this.groupBox1.Controls.Add(this.txtcorreo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbocortes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbopersonal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(42, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1155, 357);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnmayor
            // 
            this.btnmayor.BackColor = System.Drawing.Color.Aqua;
            this.btnmayor.Enabled = false;
            this.btnmayor.Location = new System.Drawing.Point(75, 171);
            this.btnmayor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmayor.Name = "btnmayor";
            this.btnmayor.Size = new System.Drawing.Size(168, 35);
            this.btnmayor.TabIndex = 34;
            this.btnmayor.Text = "Soy mayor de edad";
            this.btnmayor.UseVisualStyleBackColor = false;
            this.btnmayor.Click += new System.EventHandler(this.btnmayor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(906, 138);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 27);
            this.label12.TabIndex = 33;
            this.label12.Text = "Elegir Hora";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(906, 222);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 27);
            this.label10.TabIndex = 32;
            this.label10.Text = "Elegir Minuto";
            // 
            // cbohora
            // 
            this.cbohora.FormattingEnabled = true;
            this.cbohora.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cbohora.Location = new System.Drawing.Point(828, 171);
            this.cbohora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbohora.Name = "cbohora";
            this.cbohora.Size = new System.Drawing.Size(298, 28);
            this.cbohora.TabIndex = 31;
            // 
            // cbomin
            // 
            this.cbomin.FormattingEnabled = true;
            this.cbomin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbomin.Location = new System.Drawing.Point(828, 254);
            this.cbomin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbomin.Name = "cbomin";
            this.cbomin.Size = new System.Drawing.Size(298, 28);
            this.cbomin.TabIndex = 30;
            // 
            // btnMenor
            // 
            this.btnMenor.BackColor = System.Drawing.Color.Aqua;
            this.btnMenor.Location = new System.Drawing.Point(75, 171);
            this.btnMenor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(168, 35);
            this.btnMenor.TabIndex = 27;
            this.btnMenor.Text = "Soy menor de edad";
            this.btnMenor.UseVisualStyleBackColor = false;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(906, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Elige la fecha";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(828, 74);
            this.Calendar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(298, 26);
            this.Calendar.TabIndex = 24;
            this.Calendar.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(75, 282);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(224, 26);
            this.txtcorreo.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Maiandra GD", 11.25F);
            this.label11.Location = new System.Drawing.Point(70, 249);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 27);
            this.label11.TabIndex = 24;
            this.label11.Text = "Correo electronico";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 473);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(936, 214);
            this.textBox1.TabIndex = 24;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(72, 499);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(49, 20);
            this.LblNombre.TabIndex = 34;
            this.LblNombre.Text = "          ";
            // 
            // LblBarbero
            // 
            this.LblBarbero.AutoSize = true;
            this.LblBarbero.BackColor = System.Drawing.Color.White;
            this.LblBarbero.Location = new System.Drawing.Point(74, 547);
            this.LblBarbero.Name = "LblBarbero";
            this.LblBarbero.Size = new System.Drawing.Size(49, 20);
            this.LblBarbero.TabIndex = 36;
            this.LblBarbero.Text = "          ";
            // 
            // Lbfecha
            // 
            this.Lbfecha.AutoSize = true;
            this.Lbfecha.BackColor = System.Drawing.Color.White;
            this.Lbfecha.Location = new System.Drawing.Point(74, 596);
            this.Lbfecha.Name = "Lbfecha";
            this.Lbfecha.Size = new System.Drawing.Size(49, 20);
            this.Lbfecha.TabIndex = 37;
            this.Lbfecha.Text = "          ";
            // 
            // Lbprecio
            // 
            this.Lbprecio.AutoSize = true;
            this.Lbprecio.BackColor = System.Drawing.Color.White;
            this.Lbprecio.Location = new System.Drawing.Point(74, 644);
            this.Lbprecio.Name = "Lbprecio";
            this.Lbprecio.Size = new System.Drawing.Size(49, 20);
            this.Lbprecio.TabIndex = 38;
            this.Lbprecio.Text = "          ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1216, 723);
            this.Controls.Add(this.Lbprecio);
            this.Controls.Add(this.Lbfecha);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblBarbero);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.btnreiniciar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Agende su cita";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbocortes;
        private System.Windows.Forms.ComboBox cbopersonal;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Calendar;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.ComboBox cbohora;
        private System.Windows.Forms.ComboBox cbomin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblBarbero;
        private System.Windows.Forms.Label Lbfecha;
        private System.Windows.Forms.Label Lbprecio;
        private System.Windows.Forms.Button btnmayor;
    }
}

