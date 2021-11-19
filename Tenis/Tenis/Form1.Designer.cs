
namespace Tenis
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
            this.btnJugador1 = new System.Windows.Forms.Button();
            this.btnJugador2 = new System.Windows.Forms.Button();
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.lblJugador2 = new System.Windows.Forms.Label();
            this.lblJugador1p = new System.Windows.Forms.Label();
            this.lblJugador2p = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJugador1
            // 
            this.btnJugador1.Location = new System.Drawing.Point(140, 84);
            this.btnJugador1.Name = "btnJugador1";
            this.btnJugador1.Size = new System.Drawing.Size(75, 23);
            this.btnJugador1.TabIndex = 0;
            this.btnJugador1.Text = "Jugador1";
            this.btnJugador1.UseVisualStyleBackColor = true;
            this.btnJugador1.Click += new System.EventHandler(this.btnJugador1_Click);
            // 
            // btnJugador2
            // 
            this.btnJugador2.Location = new System.Drawing.Point(525, 84);
            this.btnJugador2.Name = "btnJugador2";
            this.btnJugador2.Size = new System.Drawing.Size(75, 23);
            this.btnJugador2.TabIndex = 1;
            this.btnJugador2.Text = "Jugador2";
            this.btnJugador2.UseVisualStyleBackColor = true;
            this.btnJugador2.Click += new System.EventHandler(this.btnJugador2_Click);
            // 
            // lblJugador1
            // 
            this.lblJugador1.AutoSize = true;
            this.lblJugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador1.Location = new System.Drawing.Point(133, 186);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(49, 37);
            this.lblJugador1.TabIndex = 2;
            this.lblJugador1.Text = "J1";
            // 
            // lblJugador2
            // 
            this.lblJugador2.AutoSize = true;
            this.lblJugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador2.Location = new System.Drawing.Point(518, 186);
            this.lblJugador2.Name = "lblJugador2";
            this.lblJugador2.Size = new System.Drawing.Size(51, 37);
            this.lblJugador2.TabIndex = 3;
            this.lblJugador2.Text = "J2";
            // 
            // lblJugador1p
            // 
            this.lblJugador1p.AutoSize = true;
            this.lblJugador1p.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador1p.Location = new System.Drawing.Point(35, 129);
            this.lblJugador1p.Name = "lblJugador1p";
            this.lblJugador1p.Size = new System.Drawing.Size(100, 73);
            this.lblJugador1p.TabIndex = 4;
            this.lblJugador1p.Text = "J1";
            // 
            // lblJugador2p
            // 
            this.lblJugador2p.AutoSize = true;
            this.lblJugador2p.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador2p.Location = new System.Drawing.Point(427, 129);
            this.lblJugador2p.Name = "lblJugador2p";
            this.lblJugador2p.Size = new System.Drawing.Size(100, 73);
            this.lblJugador2p.TabIndex = 5;
            this.lblJugador2p.Text = "J2";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(43, 322);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(109, 25);
            this.lblRespuesta.TabIndex = 6;
            this.lblRespuesta.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblJugador2p);
            this.Controls.Add(this.lblJugador1p);
            this.Controls.Add(this.lblJugador2);
            this.Controls.Add(this.lblJugador1);
            this.Controls.Add(this.btnJugador2);
            this.Controls.Add(this.btnJugador1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugador1;
        private System.Windows.Forms.Button btnJugador2;
        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.Label lblJugador2;
        private System.Windows.Forms.Label lblJugador1p;
        private System.Windows.Forms.Label lblJugador2p;
        private System.Windows.Forms.Label lblRespuesta;
    }
}

