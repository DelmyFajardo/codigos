namespace calculadora_del_20
{
    partial class Form1
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
            this.txtNum1 = new System.Windows.Forms.Label();
            this.txtNUMER01 = new System.Windows.Forms.TextBox();
            this.txtNUMERO2 = new System.Windows.Forms.TextBox();
            this.btnSUMAR = new System.Windows.Forms.Button();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.AutoSize = true;
            this.txtNum1.Location = new System.Drawing.Point(328, 41);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(0, 13);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNUMER01
            // 
            this.txtNUMER01.Location = new System.Drawing.Point(299, 36);
            this.txtNUMER01.Name = "txtNUMER01";
            this.txtNUMER01.Size = new System.Drawing.Size(189, 20);
            this.txtNUMER01.TabIndex = 1;
            this.txtNUMER01.TextChanged += new System.EventHandler(this.txtNUMER01_TextChanged);
            // 
            // txtNUMERO2
            // 
            this.txtNUMERO2.Location = new System.Drawing.Point(302, 92);
            this.txtNUMERO2.Name = "txtNUMERO2";
            this.txtNUMERO2.Size = new System.Drawing.Size(176, 20);
            this.txtNUMERO2.TabIndex = 2;
            this.txtNUMERO2.TextChanged += new System.EventHandler(this.txtNUMERO2_TextChanged);
            // 
            // btnSUMAR
            // 
            this.btnSUMAR.Location = new System.Drawing.Point(346, 174);
            this.btnSUMAR.Name = "btnSUMAR";
            this.btnSUMAR.Size = new System.Drawing.Size(75, 23);
            this.btnSUMAR.TabIndex = 3;
            this.btnSUMAR.Text = "SUMAR";
            this.btnSUMAR.UseVisualStyleBackColor = true;
            this.btnSUMAR.Click += new System.EventHandler(this.btnSUMAR_Click);
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Location = new System.Drawing.Point(305, 239);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(115, 20);
            this.txtTOTAL.TabIndex = 4;
            this.txtTOTAL.TextChanged += new System.EventHandler(this.txtTOTAL_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.btnSUMAR);
            this.Controls.Add(this.txtNUMERO2);
            this.Controls.Add(this.txtNUMER01);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNum1;
        private System.Windows.Forms.TextBox txtNUMER01;
        private System.Windows.Forms.TextBox txtNUMERO2;
        private System.Windows.Forms.Button btnSUMAR;
        private System.Windows.Forms.TextBox txtTOTAL;
    }
}

