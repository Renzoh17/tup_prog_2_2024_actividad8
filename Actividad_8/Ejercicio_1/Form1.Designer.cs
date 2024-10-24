namespace Ejercicio_1
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
            this.tbInformar = new System.Windows.Forms.TextBox();
            this.btnVerCuentas = new System.Windows.Forms.Button();
            this.btnImportarCuentas = new System.Windows.Forms.Button();
            this.btnExportarCuentas = new System.Windows.Forms.Button();
            this.btnResguardar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // tbInformar
            // 
            this.tbInformar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInformar.Location = new System.Drawing.Point(12, 12);
            this.tbInformar.Multiline = true;
            this.tbInformar.Name = "tbInformar";
            this.tbInformar.ReadOnly = true;
            this.tbInformar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInformar.Size = new System.Drawing.Size(613, 189);
            this.tbInformar.TabIndex = 0;
            // 
            // btnVerCuentas
            // 
            this.btnVerCuentas.Location = new System.Drawing.Point(641, 11);
            this.btnVerCuentas.Name = "btnVerCuentas";
            this.btnVerCuentas.Size = new System.Drawing.Size(121, 30);
            this.btnVerCuentas.TabIndex = 1;
            this.btnVerCuentas.Text = "1 - Ver cuentas";
            this.btnVerCuentas.UseVisualStyleBackColor = true;
            this.btnVerCuentas.Click += new System.EventHandler(this.btnVerCuentas_Click);
            // 
            // btnImportarCuentas
            // 
            this.btnImportarCuentas.Location = new System.Drawing.Point(641, 47);
            this.btnImportarCuentas.Name = "btnImportarCuentas";
            this.btnImportarCuentas.Size = new System.Drawing.Size(121, 30);
            this.btnImportarCuentas.TabIndex = 2;
            this.btnImportarCuentas.Text = "2 - Importar cuentas";
            this.btnImportarCuentas.UseVisualStyleBackColor = true;
            this.btnImportarCuentas.Click += new System.EventHandler(this.btnImportarCuentas_Click);
            // 
            // btnExportarCuentas
            // 
            this.btnExportarCuentas.Location = new System.Drawing.Point(641, 83);
            this.btnExportarCuentas.Name = "btnExportarCuentas";
            this.btnExportarCuentas.Size = new System.Drawing.Size(121, 30);
            this.btnExportarCuentas.TabIndex = 3;
            this.btnExportarCuentas.Text = "3 - Expotar Cuentas";
            this.btnExportarCuentas.UseVisualStyleBackColor = true;
            this.btnExportarCuentas.Click += new System.EventHandler(this.btnExportarCuentas_Click);
            // 
            // btnResguardar
            // 
            this.btnResguardar.Location = new System.Drawing.Point(641, 119);
            this.btnResguardar.Name = "btnResguardar";
            this.btnResguardar.Size = new System.Drawing.Size(121, 45);
            this.btnResguardar.TabIndex = 4;
            this.btnResguardar.Text = "4 - Resguardar (Backup)";
            this.btnResguardar.UseVisualStyleBackColor = true;
            this.btnResguardar.Click += new System.EventHandler(this.btnResguardar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(641, 170);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(121, 30);
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.Text = "5 - Restaurar (Restore)";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 213);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnResguardar);
            this.Controls.Add(this.btnExportarCuentas);
            this.Controls.Add(this.btnImportarCuentas);
            this.Controls.Add(this.btnVerCuentas);
            this.Controls.Add(this.tbInformar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInformar;
        private System.Windows.Forms.Button btnVerCuentas;
        private System.Windows.Forms.Button btnImportarCuentas;
        private System.Windows.Forms.Button btnExportarCuentas;
        private System.Windows.Forms.Button btnResguardar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

