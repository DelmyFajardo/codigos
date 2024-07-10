namespace login
{
    partial class Bienvenido
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPresiona = new System.Windows.Forms.Button();
            this.tablaDGV = new System.Windows.Forms.DataGridView();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.NombreBtn = new System.Windows.Forms.Label();
            this.NombreTb = new System.Windows.Forms.TextBox();
            this.CarnetBl = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.apellidoL = new System.Windows.Forms.Label();
            this.CursoL = new System.Windows.Forms.Label();
            this.ApellidoTB = new System.Windows.Forms.TextBox();
            this.CursoTB = new System.Windows.Forms.TextBox();
            this.CarnetL = new System.Windows.Forms.Label();
            this.CarnetTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a la ventana";
            // 
            // btnPresiona
            // 
            this.btnPresiona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPresiona.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPresiona.Location = new System.Drawing.Point(334, 31);
            this.btnPresiona.Name = "btnPresiona";
            this.btnPresiona.Size = new System.Drawing.Size(144, 40);
            this.btnPresiona.TabIndex = 1;
            this.btnPresiona.Text = "Presiona aqui!";
            this.btnPresiona.UseVisualStyleBackColor = false;
            this.btnPresiona.Click += new System.EventHandler(this.btnPresiona_Click);
            // 
            // tablaDGV
            // 
            this.tablaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDGV.GridColor = System.Drawing.Color.IndianRed;
            this.tablaDGV.Location = new System.Drawing.Point(107, 301);
            this.tablaDGV.Name = "tablaDGV";
            this.tablaDGV.Size = new System.Drawing.Size(620, 137);
            this.tablaDGV.TabIndex = 2;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.AutoSize = true;
            this.AgregarBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.AgregarBtn.Location = new System.Drawing.Point(107, 260);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtn.TabIndex = 3;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = false;
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.Color.Lime;
            this.eliminarBtn.Location = new System.Drawing.Point(371, 260);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 4;
            this.eliminarBtn.Text = "Eliminar ";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            // 
            // EditarBtn
            // 
            this.EditarBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.EditarBtn.Location = new System.Drawing.Point(652, 260);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(75, 23);
            this.EditarBtn.TabIndex = 5;
            this.EditarBtn.Text = "Editar ";
            this.EditarBtn.UseVisualStyleBackColor = false;
            // 
            // NombreBtn
            // 
            this.NombreBtn.AutoSize = true;
            this.NombreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NombreBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NombreBtn.Location = new System.Drawing.Point(268, 90);
            this.NombreBtn.Name = "NombreBtn";
            this.NombreBtn.Size = new System.Drawing.Size(46, 15);
            this.NombreBtn.TabIndex = 6;
            this.NombreBtn.Text = "Nombre";
            // 
            // NombreTb
            // 
            this.NombreTb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NombreTb.Location = new System.Drawing.Point(238, 117);
            this.NombreTb.Name = "NombreTb";
            this.NombreTb.Size = new System.Drawing.Size(139, 20);
            this.NombreTb.TabIndex = 7;
            this.NombreTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CarnetBl
            // 
            this.CarnetBl.AutoSize = true;
            this.CarnetBl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CarnetBl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CarnetBl.Location = new System.Drawing.Point(117, 99);
            this.CarnetBl.Name = "CarnetBl";
            this.CarnetBl.Size = new System.Drawing.Size(40, 15);
            this.CarnetBl.TabIndex = 8;
            this.CarnetBl.Text = "Carnet";
            // 
            // IdTB
            // 
            this.IdTB.ForeColor = System.Drawing.Color.Red;
            this.IdTB.Location = new System.Drawing.Point(82, 117);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(139, 20);
            this.IdTB.TabIndex = 9;
            this.IdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // apellidoL
            // 
            this.apellidoL.AutoSize = true;
            this.apellidoL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.apellidoL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.apellidoL.Location = new System.Drawing.Point(445, 90);
            this.apellidoL.Name = "apellidoL";
            this.apellidoL.Size = new System.Drawing.Size(49, 15);
            this.apellidoL.TabIndex = 10;
            this.apellidoL.Text = "Apellido ";
            // 
            // CursoL
            // 
            this.CursoL.AutoSize = true;
            this.CursoL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CursoL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CursoL.Location = new System.Drawing.Point(641, 90);
            this.CursoL.Name = "CursoL";
            this.CursoL.Size = new System.Drawing.Size(36, 15);
            this.CursoL.TabIndex = 11;
            this.CursoL.Text = "Curso";
            // 
            // ApellidoTB
            // 
            this.ApellidoTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ApellidoTB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ApellidoTB.Location = new System.Drawing.Point(407, 117);
            this.ApellidoTB.Name = "ApellidoTB";
            this.ApellidoTB.Size = new System.Drawing.Size(139, 20);
            this.ApellidoTB.TabIndex = 12;
            this.ApellidoTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CursoTB
            // 
            this.CursoTB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CursoTB.Location = new System.Drawing.Point(588, 117);
            this.CursoTB.Name = "CursoTB";
            this.CursoTB.Size = new System.Drawing.Size(139, 20);
            this.CursoTB.TabIndex = 13;
            this.CursoTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CarnetL
            // 
            this.CarnetL.AutoSize = true;
            this.CarnetL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CarnetL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CarnetL.Location = new System.Drawing.Point(362, 153);
            this.CarnetL.Name = "CarnetL";
            this.CarnetL.Size = new System.Drawing.Size(40, 15);
            this.CarnetL.TabIndex = 14;
            this.CarnetL.Text = "Carnet";
            // 
            // CarnetTB
            // 
            this.CarnetTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CarnetTB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CarnetTB.Location = new System.Drawing.Point(314, 171);
            this.CarnetTB.Name = "CarnetTB";
            this.CarnetTB.Size = new System.Drawing.Size(139, 20);
            this.CarnetTB.TabIndex = 15;
            this.CarnetTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarnetTB);
            this.Controls.Add(this.CarnetL);
            this.Controls.Add(this.CursoTB);
            this.Controls.Add(this.ApellidoTB);
            this.Controls.Add(this.CursoL);
            this.Controls.Add(this.apellidoL);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.CarnetBl);
            this.Controls.Add(this.NombreTb);
            this.Controls.Add(this.NombreBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.tablaDGV);
            this.Controls.Add(this.btnPresiona);
            this.Controls.Add(this.label1);
            this.Name = "Bienvenido";
            this.Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPresiona;
        private System.Windows.Forms.DataGridView tablaDGV;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Label NombreBtn;
        private System.Windows.Forms.TextBox NombreTb;
        private System.Windows.Forms.Label CarnetBl;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label apellidoL;
        private System.Windows.Forms.Label CursoL;
        private System.Windows.Forms.TextBox ApellidoTB;
        private System.Windows.Forms.TextBox CursoTB;
        private System.Windows.Forms.Label CarnetL;
        private System.Windows.Forms.TextBox CarnetTB;
    }
}