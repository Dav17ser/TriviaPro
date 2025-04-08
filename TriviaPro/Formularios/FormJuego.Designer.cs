namespace TriviaPro.Formularios
{
    partial class FormJuego
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
            this.components = new System.ComponentModel.Container();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.pbTiempo = new System.Windows.Forms.ProgressBar();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblPreguntaN = new System.Windows.Forms.Label();
            this.timerPregunta = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(27, 53);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(104, 13);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "Pregunta de ejemplo";
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(30, 101);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(68, 17);
            this.rdb1.TabIndex = 1;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Opción 1";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(30, 124);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(68, 17);
            this.rdb2.TabIndex = 2;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Opción 2";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(30, 147);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(68, 17);
            this.rdb3.TabIndex = 3;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "Opción 3";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(30, 170);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(68, 17);
            this.rdb4.TabIndex = 4;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "Opción 4";
            this.rdb4.UseVisualStyleBackColor = true;
            this.rdb4.Visible = false;
            // 
            // pbTiempo
            // 
            this.pbTiempo.Location = new System.Drawing.Point(156, 198);
            this.pbTiempo.Name = "pbTiempo";
            this.pbTiempo.Size = new System.Drawing.Size(100, 23);
            this.pbTiempo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTiempo.TabIndex = 5;
            this.pbTiempo.Value = 100;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(18, 198);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(132, 16);
            this.lblTiempo.TabIndex = 6;
            this.lblTiempo.Text = "Tiempo restante: 20s";
            // 
            // btnResponder
            // 
            this.btnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.Location = new System.Drawing.Point(307, 198);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(110, 31);
            this.btnResponder.TabIndex = 7;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(392, 53);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(65, 16);
            this.lblPuntaje.TabIndex = 9;
            this.lblPuntaje.Text = "Puntaje: 0";
            // 
            // lblPreguntaN
            // 
            this.lblPreguntaN.AutoSize = true;
            this.lblPreguntaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntaN.Location = new System.Drawing.Point(561, 53);
            this.lblPreguntaN.Name = "lblPreguntaN";
            this.lblPreguntaN.Size = new System.Drawing.Size(107, 16);
            this.lblPreguntaN.TabIndex = 10;
            this.lblPreguntaN.Text = "Pregunta 1 de 15";
            // 
            // timerPregunta
            // 
            this.timerPregunta.Interval = 1000;
            this.timerPregunta.Tick += new System.EventHandler(this.timerPregunta_Tick);
            // 
            // FormJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPreguntaN);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.pbTiempo);
            this.Controls.Add(this.rdb4);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.lblPregunta);
            this.Name = "FormJuego";
            this.Text = "FormJuego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.ProgressBar pbTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblPreguntaN;
        private System.Windows.Forms.Timer timerPregunta;
    }
}