namespace TriviaPro.Formularios
{
    partial class FormResumen
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
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblPuntajeFinal = new System.Windows.Forms.Label();
            this.lblPreguntasRespondidas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(350, 33);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(125, 16);
            this.lblResumen.TabIndex = 0;
            this.lblResumen.Text = "Resumen de Juego";
            // 
            // lblPuntajeFinal
            // 
            this.lblPuntajeFinal.AutoSize = true;
            this.lblPuntajeFinal.Location = new System.Drawing.Point(350, 82);
            this.lblPuntajeFinal.Name = "lblPuntajeFinal";
            this.lblPuntajeFinal.Size = new System.Drawing.Size(35, 13);
            this.lblPuntajeFinal.TabIndex = 1;
            this.lblPuntajeFinal.Text = "label2";
            this.lblPuntajeFinal.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPreguntasRespondidas
            // 
            this.lblPreguntasRespondidas.AutoSize = true;
            this.lblPreguntasRespondidas.Location = new System.Drawing.Point(350, 122);
            this.lblPreguntasRespondidas.Name = "lblPreguntasRespondidas";
            this.lblPreguntasRespondidas.Size = new System.Drawing.Size(35, 13);
            this.lblPreguntasRespondidas.TabIndex = 2;
            this.lblPreguntasRespondidas.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(190, 205);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(195, 41);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar Juego";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(464, 205);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 41);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FormResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPreguntasRespondidas);
            this.Controls.Add(this.lblPuntajeFinal);
            this.Controls.Add(this.lblResumen);
            this.Name = "FormResumen";
            this.Text = "FormResumen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblPuntajeFinal;
        private System.Windows.Forms.Label lblPreguntasRespondidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnSalir;
    }
}