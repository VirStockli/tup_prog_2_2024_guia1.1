namespace WindowsFormsApp2
{
    partial class Ver
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
            this.lResultados = new System.Windows.Forms.Label();
            this.lbVer = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lResultados
            // 
            this.lResultados.AutoSize = true;
            this.lResultados.Location = new System.Drawing.Point(12, 9);
            this.lResultados.Name = "lResultados";
            this.lResultados.Size = new System.Drawing.Size(60, 13);
            this.lResultados.TabIndex = 0;
            this.lResultados.Text = "Resultados";
            // 
            // lbVer
            // 
            this.lbVer.FormattingEnabled = true;
            this.lbVer.Location = new System.Drawing.Point(12, 25);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(317, 56);
            this.lbVer.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(133, 87);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 34);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 123);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.lResultados);
            this.Name = "Ver";
            this.Text = "Ver Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lResultados;
        public System.Windows.Forms.ListBox lbVer;
        public System.Windows.Forms.Button btnCerrar;
    }
}