namespace _3MLIDTS_KevinMontores_03
{
    partial class Form1
    {
        /// <summary>
        /// Variable necesaria para el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libera los recursos utilizados.
        /// </summary>
        /// <param name="disposing">
        /// true para liberar los recursos administrados; false en caso contrario.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbl_celsius = new System.Windows.Forms.Label();
            this.gb_temperaturas = new System.Windows.Forms.GroupBox();
            this.lbl_fahrenheit = new System.Windows.Forms.Label();
            this.lbl_kelvin = new System.Windows.Forms.Label();
            this.tbxCelsius = new System.Windows.Forms.TextBox();
            this.tbxFahrenheit = new System.Windows.Forms.TextBox();
            this.tbxKelvin = new System.Windows.Forms.TextBox();
            this.rbCelsius = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gb_temperaturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(424, 390);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(160, 52);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbl_celsius
            // 
            this.lbl_celsius.AutoSize = true;
            this.lbl_celsius.BackColor = System.Drawing.Color.Transparent;
            this.lbl_celsius.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_celsius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbl_celsius.Location = new System.Drawing.Point(63, 62);
            this.lbl_celsius.Name = "lbl_celsius";
            this.lbl_celsius.Size = new System.Drawing.Size(117, 28);
            this.lbl_celsius.TabIndex = 0;
            this.lbl_celsius.Text = "Celsius (°C)";
            this.lbl_celsius.Click += new System.EventHandler(this.label1_Click);
            // 
            // gb_temperaturas
            // 
            this.gb_temperaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.gb_temperaturas.Controls.Add(this.lbl_celsius);
            this.gb_temperaturas.Controls.Add(this.lbl_fahrenheit);
            this.gb_temperaturas.Controls.Add(this.lbl_kelvin);
            this.gb_temperaturas.Controls.Add(this.tbxCelsius);
            this.gb_temperaturas.Controls.Add(this.tbxFahrenheit);
            this.gb_temperaturas.Controls.Add(this.tbxKelvin);
            this.gb_temperaturas.Controls.Add(this.rbCelsius);
            this.gb_temperaturas.Controls.Add(this.rbFahrenheit);
            this.gb_temperaturas.Controls.Add(this.rbKelvin);
            this.gb_temperaturas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_temperaturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.gb_temperaturas.Location = new System.Drawing.Point(90, 48);
            this.gb_temperaturas.Name = "gb_temperaturas";
            this.gb_temperaturas.Padding = new System.Windows.Forms.Padding(15);
            this.gb_temperaturas.Size = new System.Drawing.Size(620, 310);
            this.gb_temperaturas.TabIndex = 0;
            this.gb_temperaturas.TabStop = false;
            this.gb_temperaturas.Text = "Ingrese el valor y seleccione la escala de origen";
            // 
            // lbl_fahrenheit
            // 
            this.lbl_fahrenheit.AutoSize = true;
            this.lbl_fahrenheit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fahrenheit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fahrenheit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbl_fahrenheit.Location = new System.Drawing.Point(63, 119);
            this.lbl_fahrenheit.Name = "lbl_fahrenheit";
            this.lbl_fahrenheit.Size = new System.Drawing.Size(150, 28);
            this.lbl_fahrenheit.TabIndex = 2;
            this.lbl_fahrenheit.Text = "Fahrenheit (°F)";
            // 
            // lbl_kelvin
            // 
            this.lbl_kelvin.AutoSize = true;
            this.lbl_kelvin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kelvin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kelvin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lbl_kelvin.Location = new System.Drawing.Point(63, 176);
            this.lbl_kelvin.Name = "lbl_kelvin";
            this.lbl_kelvin.Size = new System.Drawing.Size(104, 28);
            this.lbl_kelvin.TabIndex = 4;
            this.lbl_kelvin.Text = "Kelvin (K)";
            // 
            // tbxCelsius
            // 
            this.tbxCelsius.BackColor = System.Drawing.Color.White;
            this.tbxCelsius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCelsius.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCelsius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.tbxCelsius.Location = new System.Drawing.Point(235, 57);
            this.tbxCelsius.Name = "tbxCelsius";
            this.tbxCelsius.Size = new System.Drawing.Size(300, 37);
            this.tbxCelsius.TabIndex = 1;
            this.tbxCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxFahrenheit
            // 
            this.tbxFahrenheit.BackColor = System.Drawing.Color.White;
            this.tbxFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFahrenheit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFahrenheit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.tbxFahrenheit.Location = new System.Drawing.Point(235, 114);
            this.tbxFahrenheit.Name = "tbxFahrenheit";
            this.tbxFahrenheit.Size = new System.Drawing.Size(300, 37);
            this.tbxFahrenheit.TabIndex = 3;
            this.tbxFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxKelvin
            // 
            this.tbxKelvin.BackColor = System.Drawing.Color.White;
            this.tbxKelvin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxKelvin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKelvin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.tbxKelvin.Location = new System.Drawing.Point(235, 171);
            this.tbxKelvin.Name = "tbxKelvin";
            this.tbxKelvin.Size = new System.Drawing.Size(300, 37);
            this.tbxKelvin.TabIndex = 5;
            this.tbxKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbCelsius
            // 
            this.rbCelsius.AutoSize = true;
            this.rbCelsius.BackColor = System.Drawing.Color.Transparent;
            this.rbCelsius.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCelsius.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.rbCelsius.Location = new System.Drawing.Point(67, 246);
            this.rbCelsius.Name = "rbCelsius";
            this.rbCelsius.Size = new System.Drawing.Size(96, 32);
            this.rbCelsius.TabIndex = 6;
            this.rbCelsius.TabStop = true;
            this.rbCelsius.Text = "Celsius";
            this.rbCelsius.UseVisualStyleBackColor = false;
            // 
            // rbFahrenheit
            // 
            this.rbFahrenheit.AutoSize = true;
            this.rbFahrenheit.BackColor = System.Drawing.Color.Transparent;
            this.rbFahrenheit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFahrenheit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.rbFahrenheit.Location = new System.Drawing.Point(245, 246);
            this.rbFahrenheit.Name = "rbFahrenheit";
            this.rbFahrenheit.Size = new System.Drawing.Size(128, 32);
            this.rbFahrenheit.TabIndex = 7;
            this.rbFahrenheit.TabStop = true;
            this.rbFahrenheit.Text = "Fahrenheit";
            this.rbFahrenheit.UseVisualStyleBackColor = false;
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.BackColor = System.Drawing.Color.Transparent;
            this.rbKelvin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbKelvin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.rbKelvin.Location = new System.Drawing.Point(458, 246);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(90, 32);
            this.rbKelvin.TabIndex = 8;
            this.rbKelvin.TabStop = true;
            this.rbKelvin.Text = "Kelvin";
            this.rbKelvin.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(216, 390);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(160, 52);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.BackgroundImage = global::_3MLIDTS_KevinMontores_03._1.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(836, 522);
            this.Controls.Add(this.gb_temperaturas);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de temperatura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_temperaturas.ResumeLayout(false);
            this.gb_temperaturas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbl_celsius;
        private System.Windows.Forms.GroupBox gb_temperaturas;
        private System.Windows.Forms.RadioButton rbKelvin;
        private System.Windows.Forms.RadioButton rbFahrenheit;
        private System.Windows.Forms.RadioButton rbCelsius;
        private System.Windows.Forms.Label lbl_fahrenheit;
        private System.Windows.Forms.Label lbl_kelvin;
        private System.Windows.Forms.TextBox tbxFahrenheit;
        private System.Windows.Forms.TextBox tbxCelsius;
        private System.Windows.Forms.TextBox tbxKelvin;
        private System.Windows.Forms.Button btnCalcular;
    }
}