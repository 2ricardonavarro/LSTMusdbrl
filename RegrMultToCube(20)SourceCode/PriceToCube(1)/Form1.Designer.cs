
namespace PriceToCube_1_
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
            this.PriceToCube = new System.Windows.Forms.Button();
            this.textBoxPerTraz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMXN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxES = new System.Windows.Forms.TextBox();
            this.textBox6E = new System.Windows.Forms.TextBox();
            this.textBoxWIN = new System.Windows.Forms.TextBox();
            this.textBoxCL = new System.Windows.Forms.TextBox();
            this.textBoxAUD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAddAutoVar = new System.Windows.Forms.TextBox();
            this.textBoxVarTemp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxVarTemp2 = new System.Windows.Forms.TextBox();
            this.buttonGerarGif = new System.Windows.Forms.Button();
            this.numericDiaInicial = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericDiaFinal = new System.Windows.Forms.NumericUpDown();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPtsStopLoss = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxPerTraz2 = new System.Windows.Forms.TextBox();
            this.Agr1 = new System.Windows.Forms.Button();
            this.textBoxPtsStopGain = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxSpread = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiaFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceToCube
            // 
            this.PriceToCube.Location = new System.Drawing.Point(174, 289);
            this.PriceToCube.Name = "PriceToCube";
            this.PriceToCube.Size = new System.Drawing.Size(83, 23);
            this.PriceToCube.TabIndex = 2;
            this.PriceToCube.Text = "PriceToCube";
            this.PriceToCube.UseVisualStyleBackColor = true;
            this.PriceToCube.Click += new System.EventHandler(this.PriceToCube_Click);
            // 
            // textBoxPerTraz
            // 
            this.textBoxPerTraz.Location = new System.Drawing.Point(12, 24);
            this.textBoxPerTraz.Name = "textBoxPerTraz";
            this.textBoxPerTraz.Size = new System.Drawing.Size(50, 20);
            this.textBoxPerTraz.TabIndex = 3;
            this.textBoxPerTraz.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PeriodosPraTraz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PeriodosPraFrente:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Condições:";
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(12, 114);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(140, 55);
            this.textBoxCondition.TabIndex = 7;
            this.textBoxCondition.Text = "passadoMix > c + col0 && passadoDol <   r + row0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PesosMix:";
            // 
            // textBoxMXN
            // 
            this.textBoxMXN.Location = new System.Drawing.Point(49, 208);
            this.textBoxMXN.Name = "textBoxMXN";
            this.textBoxMXN.Size = new System.Drawing.Size(63, 20);
            this.textBoxMXN.TabIndex = 9;
            this.textBoxMXN.Text = "138.1191";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "MXN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ES:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "6E:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "WIN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "CL:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "AUD:";
            // 
            // textBoxES
            // 
            this.textBoxES.Location = new System.Drawing.Point(49, 233);
            this.textBoxES.Name = "textBoxES";
            this.textBoxES.Size = new System.Drawing.Size(63, 20);
            this.textBoxES.TabIndex = 17;
            this.textBoxES.Text = "-0.7914";
            // 
            // textBox6E
            // 
            this.textBox6E.Location = new System.Drawing.Point(49, 257);
            this.textBox6E.Name = "textBox6E";
            this.textBox6E.Size = new System.Drawing.Size(63, 20);
            this.textBox6E.TabIndex = 18;
            this.textBox6E.Text = "-2423.583";
            // 
            // textBoxWIN
            // 
            this.textBoxWIN.Location = new System.Drawing.Point(48, 331);
            this.textBoxWIN.Name = "textBoxWIN";
            this.textBoxWIN.Size = new System.Drawing.Size(63, 20);
            this.textBoxWIN.TabIndex = 21;
            this.textBoxWIN.Text = "-18.49898";
            // 
            // textBoxCL
            // 
            this.textBoxCL.Location = new System.Drawing.Point(48, 307);
            this.textBoxCL.Name = "textBoxCL";
            this.textBoxCL.Size = new System.Drawing.Size(63, 20);
            this.textBoxCL.TabIndex = 20;
            this.textBoxCL.Text = "-14.7794";
            // 
            // textBoxAUD
            // 
            this.textBoxAUD.Location = new System.Drawing.Point(48, 282);
            this.textBoxAUD.Name = "textBoxAUD";
            this.textBoxAUD.Size = new System.Drawing.Size(63, 20);
            this.textBoxAUD.TabIndex = 19;
            this.textBoxAUD.Text = "-4496.3391";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "PesosIniciais";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "AddAutoVariacao:";
            // 
            // textBoxAddAutoVar
            // 
            this.textBoxAddAutoVar.Location = new System.Drawing.Point(16, 376);
            this.textBoxAddAutoVar.Name = "textBoxAddAutoVar";
            this.textBoxAddAutoVar.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddAutoVar.TabIndex = 24;
            this.textBoxAddAutoVar.Text = "0";
            // 
            // textBoxVarTemp
            // 
            this.textBoxVarTemp.Location = new System.Drawing.Point(159, 114);
            this.textBoxVarTemp.Name = "textBoxVarTemp";
            this.textBoxVarTemp.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarTemp.TabIndex = 25;
            this.textBoxVarTemp.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "VariavelTemp:";
            // 
            // textBoxVarTemp2
            // 
            this.textBoxVarTemp2.Location = new System.Drawing.Point(159, 140);
            this.textBoxVarTemp2.Name = "textBoxVarTemp2";
            this.textBoxVarTemp2.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarTemp2.TabIndex = 27;
            this.textBoxVarTemp2.Text = "1";
            // 
            // buttonGerarGif
            // 
            this.buttonGerarGif.Location = new System.Drawing.Point(14, 402);
            this.buttonGerarGif.Name = "buttonGerarGif";
            this.buttonGerarGif.Size = new System.Drawing.Size(75, 23);
            this.buttonGerarGif.TabIndex = 28;
            this.buttonGerarGif.Text = "GerarGif";
            this.buttonGerarGif.UseVisualStyleBackColor = true;
            this.buttonGerarGif.Click += new System.EventHandler(this.buttonGerarGif_Click);
            // 
            // numericDiaInicial
            // 
            this.numericDiaInicial.Location = new System.Drawing.Point(159, 229);
            this.numericDiaInicial.Name = "numericDiaInicial";
            this.numericDiaInicial.Size = new System.Drawing.Size(43, 20);
            this.numericDiaInicial.TabIndex = 29;
            this.numericDiaInicial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(156, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "DiaInicial:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(225, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "DiaFinal:";
            // 
            // numericDiaFinal
            // 
            this.numericDiaFinal.Location = new System.Drawing.Point(228, 229);
            this.numericDiaFinal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericDiaFinal.Name = "numericDiaFinal";
            this.numericDiaFinal.Size = new System.Drawing.Size(43, 20);
            this.numericDiaFinal.TabIndex = 31;
            this.numericDiaFinal.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            // 
            // textBoxMes
            // 
            this.textBoxMes.Location = new System.Drawing.Point(184, 260);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(87, 20);
            this.textBoxMes.TabIndex = 33;
            this.textBoxMes.Text = "2020-08-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(149, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Mes:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(156, 351);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "StopLoss (pts):";
            // 
            // textBoxPtsStopLoss
            // 
            this.textBoxPtsStopLoss.Location = new System.Drawing.Point(239, 349);
            this.textBoxPtsStopLoss.Name = "textBoxPtsStopLoss";
            this.textBoxPtsStopLoss.Size = new System.Drawing.Size(27, 20);
            this.textBoxPtsStopLoss.TabIndex = 36;
            this.textBoxPtsStopLoss.Text = "10";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(70, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "&&&&";
            // 
            // textBoxPerTraz2
            // 
            this.textBoxPerTraz2.Location = new System.Drawing.Point(95, 23);
            this.textBoxPerTraz2.Name = "textBoxPerTraz2";
            this.textBoxPerTraz2.Size = new System.Drawing.Size(57, 20);
            this.textBoxPerTraz2.TabIndex = 38;
            this.textBoxPerTraz2.Text = "0";
            // 
            // Agr1
            // 
            this.Agr1.Location = new System.Drawing.Point(152, 402);
            this.Agr1.Name = "Agr1";
            this.Agr1.Size = new System.Drawing.Size(75, 23);
            this.Agr1.TabIndex = 39;
            this.Agr1.Text = "Agr1";
            this.Agr1.UseVisualStyleBackColor = true;
            // 
            // textBoxPtsStopGain
            // 
            this.textBoxPtsStopGain.Location = new System.Drawing.Point(239, 376);
            this.textBoxPtsStopGain.Name = "textBoxPtsStopGain";
            this.textBoxPtsStopGain.Size = new System.Drawing.Size(27, 20);
            this.textBoxPtsStopGain.TabIndex = 41;
            this.textBoxPtsStopGain.Text = "10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(156, 378);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "StopGain (pts):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 435);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Spread(pts):";
            // 
            // textBoxSpread
            // 
            this.textBoxSpread.Location = new System.Drawing.Point(70, 431);
            this.textBoxSpread.Name = "textBoxSpread";
            this.textBoxSpread.Size = new System.Drawing.Size(37, 20);
            this.textBoxSpread.TabIndex = 43;
            this.textBoxSpread.Text = "0.0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "TodosMeses";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSpread);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxPtsStopGain);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Agr1);
            this.Controls.Add(this.textBoxPerTraz2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxPtsStopLoss);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxMes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericDiaFinal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericDiaInicial);
            this.Controls.Add(this.buttonGerarGif);
            this.Controls.Add(this.textBoxVarTemp2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxVarTemp);
            this.Controls.Add(this.textBoxAddAutoVar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxWIN);
            this.Controls.Add(this.textBoxCL);
            this.Controls.Add(this.textBoxAUD);
            this.Controls.Add(this.textBox6E);
            this.Controls.Add(this.textBoxES);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMXN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCondition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPerTraz);
            this.Controls.Add(this.PriceToCube);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericDiaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiaFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PriceToCube;
        private System.Windows.Forms.TextBox textBoxPerTraz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMXN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxES;
        private System.Windows.Forms.TextBox textBox6E;
        private System.Windows.Forms.TextBox textBoxWIN;
        private System.Windows.Forms.TextBox textBoxCL;
        private System.Windows.Forms.TextBox textBoxAUD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAddAutoVar;
        private System.Windows.Forms.TextBox textBoxVarTemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxVarTemp2;
        private System.Windows.Forms.Button buttonGerarGif;
        private System.Windows.Forms.NumericUpDown numericDiaInicial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericDiaFinal;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPtsStopLoss;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxPerTraz2;
        private System.Windows.Forms.Button Agr1;
        private System.Windows.Forms.TextBox textBoxPtsStopGain;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxSpread;
        private System.Windows.Forms.Button button2;
    }
}

