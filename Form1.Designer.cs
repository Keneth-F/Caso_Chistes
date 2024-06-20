namespace Caso_Chistes
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnTellJoke = new System.Windows.Forms.Button();
            this.LblJoke = new System.Windows.Forms.Label();
            this.typingTimer = new System.Windows.Forms.Timer(this.components);
            this.pulseTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnTellJoke);
            this.panel1.Controls.Add(this.LblJoke);
            this.panel1.Location = new System.Drawing.Point(-1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 351);
            this.panel1.TabIndex = 0;
            // 
            // BtnTellJoke
            // 
            this.BtnTellJoke.Location = new System.Drawing.Point(12, 12);
            this.BtnTellJoke.Name = "BtnTellJoke";
            this.BtnTellJoke.Size = new System.Drawing.Size(365, 43);
            this.BtnTellJoke.TabIndex = 1;
            this.BtnTellJoke.Text = "Nuevo Chiste";
            this.BtnTellJoke.UseVisualStyleBackColor = true;
            this.BtnTellJoke.Click += new System.EventHandler(this.BtnTellJoke_Click);
            // 
            // LblJoke
            // 
            this.LblJoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJoke.Location = new System.Drawing.Point(9, 58);
            this.LblJoke.Name = "LblJoke";
            this.LblJoke.Size = new System.Drawing.Size(368, 293);
            this.LblJoke.TabIndex = 0;
            // 
            // typingTimer
            // 
            this.typingTimer.Interval = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 365);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnTellJoke;
        private System.Windows.Forms.Label LblJoke;
        private System.Windows.Forms.Timer typingTimer;
        private System.Windows.Forms.Timer pulseTimer;
    }
}

