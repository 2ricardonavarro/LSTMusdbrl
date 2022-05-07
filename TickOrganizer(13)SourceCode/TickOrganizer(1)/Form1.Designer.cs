
namespace TickOrganizer_1_
{
    partial class Form1
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
            this.OrganizeTick = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSemana = new System.Windows.Forms.TextBox();
            this.textBoxDiaInicial = new System.Windows.Forms.TextBox();
            this.textBoxQtdDiasSeguidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrganizeTick
            // 
            this.OrganizeTick.Location = new System.Drawing.Point(27, 159);
            this.OrganizeTick.Name = "OrganizeTick";
            this.OrganizeTick.Size = new System.Drawing.Size(86, 23);
            this.OrganizeTick.TabIndex = 0;
            this.OrganizeTick.Text = "OrganizeTick";
            this.OrganizeTick.UseVisualStyleBackColor = true;
            this.OrganizeTick.Click += new System.EventHandler(this.OrganizeTick_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OrganizeTryd";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OrganizeTick_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSemana
            // 
            this.textBoxSemana.Location = new System.Drawing.Point(27, 29);
            this.textBoxSemana.Name = "textBoxSemana";
            this.textBoxSemana.Size = new System.Drawing.Size(86, 20);
            this.textBoxSemana.TabIndex = 3;
            this.textBoxSemana.Text = "Semana1";
            // 
            // textBoxDiaInicial
            // 
            this.textBoxDiaInicial.Location = new System.Drawing.Point(27, 70);
            this.textBoxDiaInicial.Name = "textBoxDiaInicial";
            this.textBoxDiaInicial.Size = new System.Drawing.Size(86, 20);
            this.textBoxDiaInicial.TabIndex = 4;
            this.textBoxDiaInicial.Text = "2021-01-04";
            // 
            // textBoxQtdDiasSeguidos
            // 
            this.textBoxQtdDiasSeguidos.Location = new System.Drawing.Point(27, 113);
            this.textBoxQtdDiasSeguidos.Name = "textBoxQtdDiasSeguidos";
            this.textBoxQtdDiasSeguidos.Size = new System.Drawing.Size(86, 20);
            this.textBoxQtdDiasSeguidos.TabIndex = 5;
            this.textBoxQtdDiasSeguidos.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Semana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dia Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Qtd Dias Seguidos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 279);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQtdDiasSeguidos);
            this.Controls.Add(this.textBoxDiaInicial);
            this.Controls.Add(this.textBoxSemana);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrganizeTick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrganizeTick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSemana;
        private System.Windows.Forms.TextBox textBoxDiaInicial;
        private System.Windows.Forms.TextBox textBoxQtdDiasSeguidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

