namespace WindowsFormsApp1
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
            this.btnCaso1 = new System.Windows.Forms.Button();
            this.btncaso2 = new System.Windows.Forms.Button();
            this.btncaso3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaso1
            // 
            this.btnCaso1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCaso1.Location = new System.Drawing.Point(12, 158);
            this.btnCaso1.Name = "btnCaso1";
            this.btnCaso1.Size = new System.Drawing.Size(244, 52);
            this.btnCaso1.TabIndex = 0;
            this.btnCaso1.Text = "Nombre medico";
            this.btnCaso1.UseVisualStyleBackColor = false;
            this.btnCaso1.Click += new System.EventHandler(this.btnCaso1_Click);
            // 
            // btncaso2
            // 
            this.btncaso2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncaso2.Location = new System.Drawing.Point(276, 158);
            this.btncaso2.Name = "btncaso2";
            this.btncaso2.Size = new System.Drawing.Size(244, 52);
            this.btncaso2.TabIndex = 1;
            this.btncaso2.Text = "Error Max Caracteres";
            this.btncaso2.UseVisualStyleBackColor = false;
            this.btncaso2.Click += new System.EventHandler(this.btncaso2_Click);
            // 
            // btncaso3
            // 
            this.btncaso3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncaso3.Location = new System.Drawing.Point(544, 158);
            this.btncaso3.Name = "btncaso3";
            this.btncaso3.Size = new System.Drawing.Size(244, 52);
            this.btncaso3.TabIndex = 2;
            this.btncaso3.Text = "Sin caracteres";
            this.btncaso3.UseVisualStyleBackColor = false;
            this.btncaso3.Click += new System.EventHandler(this.btncaso3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncaso3);
            this.Controls.Add(this.btncaso2);
            this.Controls.Add(this.btnCaso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaso1;
        private System.Windows.Forms.Button btncaso2;
        private System.Windows.Forms.Button btncaso3;
    }
}

