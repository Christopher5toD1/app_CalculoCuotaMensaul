namespace columnas_texto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxTMontoPrestamo = new TextBox();
            TxTInteresAnual = new TextBox();
            TxTTiempoMeses = new TextBox();
            TxTTasaInteresMesual = new TextBox();
            TxTPagoCuotas = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            Cuadro = new DataGridView();
            NumeroCuota = new DataGridViewTextBoxColumn();
            Cuota = new DataGridViewTextBoxColumn();
            Intereses = new DataGridViewTextBoxColumn();
            MontoInicial = new DataGridViewTextBoxColumn();
            MontoFinal = new DataGridViewTextBoxColumn();
            AbonoCapital = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Cuadro).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 20);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 0;
            label1.Text = "Amortizacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 294);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 2;
            label3.Text = "Pago Cuotas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 245);
            label4.Name = "label4";
            label4.Size = new Size(190, 21);
            label4.TabIndex = 3;
            label4.Text = "Tasa De Interes Mensual ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(104, 192);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 4;
            label5.Text = "Tiempo(meses)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(61, 136);
            label6.Name = "label6";
            label6.Size = new Size(168, 21);
            label6.TabIndex = 5;
            label6.Text = "Tasa De Interes Anual";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(61, 86);
            label7.Name = "label7";
            label7.Size = new Size(171, 21);
            label7.TabIndex = 6;
            label7.Text = "Monto De El Prestamo";
            // 
            // TxTMontoPrestamo
            // 
            TxTMontoPrestamo.Location = new Point(254, 88);
            TxTMontoPrestamo.Name = "TxTMontoPrestamo";
            TxTMontoPrestamo.Size = new Size(137, 23);
            TxTMontoPrestamo.TabIndex = 7;
            // 
            // TxTInteresAnual
            // 
            TxTInteresAnual.Location = new Point(254, 138);
            TxTInteresAnual.Name = "TxTInteresAnual";
            TxTInteresAnual.Size = new Size(137, 23);
            TxTInteresAnual.TabIndex = 8;
            // 
            // TxTTiempoMeses
            // 
            TxTTiempoMeses.Location = new Point(254, 192);
            TxTTiempoMeses.Name = "TxTTiempoMeses";
            TxTTiempoMeses.Size = new Size(137, 23);
            TxTTiempoMeses.TabIndex = 9;
            // 
            // TxTTasaInteresMesual
            // 
            TxTTasaInteresMesual.Location = new Point(254, 243);
            TxTTasaInteresMesual.Name = "TxTTasaInteresMesual";
            TxTTasaInteresMesual.ReadOnly = true;
            TxTTasaInteresMesual.Size = new Size(137, 23);
            TxTTasaInteresMesual.TabIndex = 10;
            // 
            // TxTPagoCuotas
            // 
            TxTPagoCuotas.Location = new Point(254, 296);
            TxTPagoCuotas.Name = "TxTPagoCuotas";
            TxTPagoCuotas.ReadOnly = true;
            TxTPagoCuotas.Size = new Size(137, 23);
            TxTPagoCuotas.TabIndex = 11;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnCalcular.Location = new Point(578, 86);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 51);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnLimpiar.Location = new Point(578, 179);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(118, 51);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(578, 268);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 51);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Cuadro
            // 
            Cuadro.AllowUserToAddRows = false;
            Cuadro.AllowUserToDeleteRows = false;
            Cuadro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Cuadro.Columns.AddRange(new DataGridViewColumn[] { NumeroCuota, Cuota, Intereses, MontoInicial, MontoFinal, AbonoCapital });
            Cuadro.Location = new Point(61, 350);
            Cuadro.Name = "Cuadro";
            Cuadro.ReadOnly = true;
            Cuadro.Size = new Size(644, 176);
            Cuadro.TabIndex = 16;
            // 
            // NumeroCuota
            // 
            NumeroCuota.HeaderText = "Numero Cuota";
            NumeroCuota.Name = "NumeroCuota";
            NumeroCuota.ReadOnly = true;
            // 
            // Cuota
            // 
            Cuota.HeaderText = "Cuota";
            Cuota.Name = "Cuota";
            Cuota.ReadOnly = true;
            // 
            // Intereses
            // 
            Intereses.HeaderText = "Intereses";
            Intereses.Name = "Intereses";
            Intereses.ReadOnly = true;
            // 
            // MontoInicial
            // 
            MontoInicial.HeaderText = "Monto inicial";
            MontoInicial.Name = "MontoInicial";
            MontoInicial.ReadOnly = true;
            // 
            // MontoFinal
            // 
            MontoFinal.HeaderText = "Monto FInal";
            MontoFinal.Name = "MontoFinal";
            MontoFinal.ReadOnly = true;
            // 
            // AbonoCapital
            // 
            AbonoCapital.HeaderText = "Abono Capital";
            AbonoCapital.Name = "AbonoCapital";
            AbonoCapital.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(805, 601);
            Controls.Add(Cuadro);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(TxTPagoCuotas);
            Controls.Add(TxTTasaInteresMesual);
            Controls.Add(TxTTiempoMeses);
            Controls.Add(TxTInteresAnual);
            Controls.Add(TxTMontoPrestamo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Cuadro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxTMontoPrestamo;
        private TextBox TxTInteresAnual;
        private TextBox TxTTiempoMeses;
        private TextBox TxTTasaInteresMesual;
        private TextBox TxTPagoCuotas;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private DataGridView Cuadro;
        private DataGridViewTextBoxColumn NumeroCuota;
        private DataGridViewTextBoxColumn Cuota;
        private DataGridViewTextBoxColumn Intereses;
        private DataGridViewTextBoxColumn MontoInicial;
        private DataGridViewTextBoxColumn MontoFinal;
        private DataGridViewTextBoxColumn AbonoCapital;
    }
}
