namespace Tarea3
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
            this.btnLlenaArray = new System.Windows.Forms.Button();
            this.btnInicProcesos = new System.Windows.Forms.Button();
            this.campoTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLlenaArray
            // 
            this.btnLlenaArray.Location = new System.Drawing.Point(22, 30);
            this.btnLlenaArray.Name = "btnLlenaArray";
            this.btnLlenaArray.Size = new System.Drawing.Size(128, 46);
            this.btnLlenaArray.TabIndex = 0;
            this.btnLlenaArray.Text = "Llenar Arreglo";
            this.btnLlenaArray.UseVisualStyleBackColor = true;
            this.btnLlenaArray.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInicProcesos
            // 
            this.btnInicProcesos.Location = new System.Drawing.Point(191, 30);
            this.btnInicProcesos.Name = "btnInicProcesos";
            this.btnInicProcesos.Size = new System.Drawing.Size(128, 46);
            this.btnInicProcesos.TabIndex = 1;
            this.btnInicProcesos.Text = "Iniciar subprocesos";
            this.btnInicProcesos.UseVisualStyleBackColor = true;
            this.btnInicProcesos.Click += new System.EventHandler(this.boton2_Click);
            // 
            // campoTexto
            // 
            this.campoTexto.Location = new System.Drawing.Point(22, 139);
            this.campoTexto.Multiline = true;
            this.campoTexto.Name = "campoTexto";
            this.campoTexto.ReadOnly = true;
            this.campoTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.campoTexto.Size = new System.Drawing.Size(297, 213);
            this.campoTexto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Posición";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoTexto);
            this.Controls.Add(this.btnInicProcesos);
            this.Controls.Add(this.btnLlenaArray);
            this.Name = "Form1";
            this.Text = "Tarea 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlenaArray;
        private System.Windows.Forms.Button btnInicProcesos;
        private System.Windows.Forms.TextBox campoTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

