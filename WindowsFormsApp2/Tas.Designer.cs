namespace WindowsFormsApp2
{
    partial class Tas
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
            this.lMarca = new System.Windows.Forms.Label();
            this.lModelo = new System.Windows.Forms.Label();
            this.lCalcular = new System.Windows.Forms.Label();
            this.lValor = new System.Windows.Forms.Label();
            this.lTasa = new System.Windows.Forms.Label();
            this.lVida = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbVida = new System.Windows.Forms.TextBox();
            this.tbTasa = new System.Windows.Forms.TextBox();
            this.nudModelo = new System.Windows.Forms.NumericUpDown();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            this.SuspendLayout();
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(12, 14);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(37, 13);
            this.lMarca.TabIndex = 0;
            this.lMarca.Text = "Marca";
            // 
            // lModelo
            // 
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(12, 38);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(42, 13);
            this.lModelo.TabIndex = 1;
            this.lModelo.Text = "Modelo";
            // 
            // lCalcular
            // 
            this.lCalcular.AutoSize = true;
            this.lCalcular.Location = new System.Drawing.Point(12, 64);
            this.lCalcular.Name = "lCalcular";
            this.lCalcular.Size = new System.Drawing.Size(75, 13);
            this.lCalcular.TabIndex = 2;
            this.lCalcular.Text = "Año a calcular";
            // 
            // lValor
            // 
            this.lValor.AutoSize = true;
            this.lValor.Location = new System.Drawing.Point(12, 89);
            this.lValor.Name = "lValor";
            this.lValor.Size = new System.Drawing.Size(110, 13);
            this.lValor.TabIndex = 3;
            this.lValor.Text = "Valor de fabricación $";
            // 
            // lTasa
            // 
            this.lTasa.AutoSize = true;
            this.lTasa.Location = new System.Drawing.Point(246, 14);
            this.lTasa.Name = "lTasa";
            this.lTasa.Size = new System.Drawing.Size(113, 13);
            this.lTasa.TabIndex = 4;
            this.lTasa.Text = "Tasa de depreciación:";
            // 
            // lVida
            // 
            this.lVida.AutoSize = true;
            this.lVida.Location = new System.Drawing.Point(280, 38);
            this.lVida.Name = "lVida";
            this.lVida.Size = new System.Drawing.Size(79, 13);
            this.lVida.TabIndex = 5;
            this.lVida.Text = "Vida útil (años):";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(126, 11);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(74, 20);
            this.tbMarca.TabIndex = 6;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(126, 86);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(74, 20);
            this.tbValor.TabIndex = 7;
            // 
            // tbVida
            // 
            this.tbVida.Location = new System.Drawing.Point(365, 35);
            this.tbVida.Name = "tbVida";
            this.tbVida.Size = new System.Drawing.Size(60, 20);
            this.tbVida.TabIndex = 8;
            // 
            // tbTasa
            // 
            this.tbTasa.Location = new System.Drawing.Point(365, 11);
            this.tbTasa.Name = "tbTasa";
            this.tbTasa.Size = new System.Drawing.Size(60, 20);
            this.tbTasa.TabIndex = 9;
            // 
            // nudModelo
            // 
            this.nudModelo.Location = new System.Drawing.Point(126, 36);
            this.nudModelo.Name = "nudModelo";
            this.nudModelo.Size = new System.Drawing.Size(74, 20);
            this.nudModelo.TabIndex = 10;
            // 
            // nudAño
            // 
            this.nudAño.Location = new System.Drawing.Point(126, 62);
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(74, 20);
            this.nudAño.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 123);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 33);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular Costo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(126, 123);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(95, 33);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Tas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 175);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudAño);
            this.Controls.Add(this.nudModelo);
            this.Controls.Add(this.tbTasa);
            this.Controls.Add(this.tbVida);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lVida);
            this.Controls.Add(this.lTasa);
            this.Controls.Add(this.lValor);
            this.Controls.Add(this.lCalcular);
            this.Controls.Add(this.lModelo);
            this.Controls.Add(this.lMarca);
            this.Name = "Tas";
            this.Text = "Tasación de motos";
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lMarca;
        public System.Windows.Forms.Label lModelo;
        public System.Windows.Forms.Label lCalcular;
        public System.Windows.Forms.Label lValor;
        public System.Windows.Forms.Label lTasa;
        public System.Windows.Forms.Label lVida;
        public System.Windows.Forms.TextBox tbMarca;
        public System.Windows.Forms.TextBox tbValor;
        public System.Windows.Forms.TextBox tbVida;
        public System.Windows.Forms.TextBox tbTasa;
        public System.Windows.Forms.NumericUpDown nudModelo;
        public System.Windows.Forms.NumericUpDown nudAño;
        public System.Windows.Forms.Button btnCalcular;
        public System.Windows.Forms.Button btnCerrar;
    }
}

