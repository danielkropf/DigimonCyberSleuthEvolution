namespace Digimon_Evoluttion
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.radioButtonBaby = new System.Windows.Forms.RadioButton();
			this.radioButtonInTraining = new System.Windows.Forms.RadioButton();
			this.radioButtonRookie = new System.Windows.Forms.RadioButton();
			this.radioButtonChampion = new System.Windows.Forms.RadioButton();
			this.radioButtonUltimate = new System.Windows.Forms.RadioButton();
			this.radioButtonMega = new System.Windows.Forms.RadioButton();
			this.radioButtonDigiEggs = new System.Windows.Forms.RadioButton();
			this.radioButtonBeyondMega = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// radioButtonBaby
			// 
			this.radioButtonBaby.AutoSize = true;
			this.radioButtonBaby.Location = new System.Drawing.Point(12, 39);
			this.radioButtonBaby.Name = "radioButtonBaby";
			this.radioButtonBaby.Size = new System.Drawing.Size(49, 17);
			this.radioButtonBaby.TabIndex = 1;
			this.radioButtonBaby.Text = "Baby";
			this.radioButtonBaby.UseVisualStyleBackColor = true;
			this.radioButtonBaby.Click += new System.EventHandler(this.changeTheChosenLevel);
			// 
			// radioButtonInTraining
			// 
			this.radioButtonInTraining.AutoSize = true;
			this.radioButtonInTraining.Location = new System.Drawing.Point(12, 62);
			this.radioButtonInTraining.Name = "radioButtonInTraining";
			this.radioButtonInTraining.Size = new System.Drawing.Size(72, 17);
			this.radioButtonInTraining.TabIndex = 2;
			this.radioButtonInTraining.Text = "InTraining";
			this.radioButtonInTraining.UseVisualStyleBackColor = true;
			this.radioButtonInTraining.Click += new System.EventHandler(this.changeTheChosenLevel);
			// 
			// radioButtonRookie
			// 
			this.radioButtonRookie.AutoSize = true;
			this.radioButtonRookie.Location = new System.Drawing.Point(12, 85);
			this.radioButtonRookie.Name = "radioButtonRookie";
			this.radioButtonRookie.Size = new System.Drawing.Size(59, 17);
			this.radioButtonRookie.TabIndex = 3;
			this.radioButtonRookie.Text = "Rookie";
			this.radioButtonRookie.UseVisualStyleBackColor = true;
			this.radioButtonRookie.Click += new System.EventHandler(this.changeTheChosenLevel);
			// 
			// radioButtonChampion
			// 
			this.radioButtonChampion.AutoSize = true;
			this.radioButtonChampion.Location = new System.Drawing.Point(12, 108);
			this.radioButtonChampion.Name = "radioButtonChampion";
			this.radioButtonChampion.Size = new System.Drawing.Size(72, 17);
			this.radioButtonChampion.TabIndex = 4;
			this.radioButtonChampion.Text = "Champion";
			this.radioButtonChampion.UseVisualStyleBackColor = true;
			this.radioButtonChampion.Click += new System.EventHandler(this.changeTheChosenLevel);
			// 
			// radioButtonUltimate
			// 
			this.radioButtonUltimate.AutoSize = true;
			this.radioButtonUltimate.Location = new System.Drawing.Point(12, 131);
			this.radioButtonUltimate.Name = "radioButtonUltimate";
			this.radioButtonUltimate.Size = new System.Drawing.Size(63, 17);
			this.radioButtonUltimate.TabIndex = 5;
			this.radioButtonUltimate.Text = "Ultimate";
			this.radioButtonUltimate.UseVisualStyleBackColor = true;
			this.radioButtonUltimate.Click += new System.EventHandler(this.changeTheChosenLevel);
			// 
			// radioButtonMega
			// 
			this.radioButtonMega.AutoSize = true;
			this.radioButtonMega.Location = new System.Drawing.Point(12, 154);
			this.radioButtonMega.Name = "radioButtonMega";
			this.radioButtonMega.Size = new System.Drawing.Size(52, 17);
			this.radioButtonMega.TabIndex = 6;
			this.radioButtonMega.Text = "Mega";
			this.radioButtonMega.UseVisualStyleBackColor = true;
			this.radioButtonMega.Click += new System.EventHandler(this.changeTheChosenLevel);
			// 
			// radioButtonDigiEggs
			// 
			this.radioButtonDigiEggs.AutoSize = true;
			this.radioButtonDigiEggs.Location = new System.Drawing.Point(12, 177);
			this.radioButtonDigiEggs.Name = "radioButtonDigiEggs";
			this.radioButtonDigiEggs.Size = new System.Drawing.Size(70, 17);
			this.radioButtonDigiEggs.TabIndex = 7;
			this.radioButtonDigiEggs.Text = "Digi-Eggs";
			this.radioButtonDigiEggs.UseVisualStyleBackColor = true;
			this.radioButtonDigiEggs.Click += new System.EventHandler(this.changeTheChosenLevel);
			// 
			// radioButtonBeyondMega
			// 
			this.radioButtonBeyondMega.AutoSize = true;
			this.radioButtonBeyondMega.Location = new System.Drawing.Point(12, 200);
			this.radioButtonBeyondMega.Name = "radioButtonBeyondMega";
			this.radioButtonBeyondMega.Size = new System.Drawing.Size(91, 17);
			this.radioButtonBeyondMega.TabIndex = 8;
			this.radioButtonBeyondMega.Text = "Beyond Mega";
			this.radioButtonBeyondMega.UseVisualStyleBackColor = true;
			this.radioButtonBeyondMega.Click += new System.EventHandler(this.changeTheChosenLevel);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 223);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(340, 252);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(190, 203);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(140, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(194, 446);
			this.listBox1.TabIndex = 11;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(536, 12);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(194, 446);
			this.listBox2.TabIndex = 12;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(340, 30);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(190, 203);
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(340, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Pré-Evolution";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(340, 236);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Next Evolution";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 467);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButtonBeyondMega);
			this.Controls.Add(this.radioButtonDigiEggs);
			this.Controls.Add(this.radioButtonMega);
			this.Controls.Add(this.radioButtonUltimate);
			this.Controls.Add(this.radioButtonChampion);
			this.Controls.Add(this.radioButtonRookie);
			this.Controls.Add(this.radioButtonInTraining);
			this.Controls.Add(this.radioButtonBaby);
			this.Controls.Add(this.comboBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButtonBaby;
        private System.Windows.Forms.RadioButton radioButtonInTraining;
        private System.Windows.Forms.RadioButton radioButtonRookie;
        private System.Windows.Forms.RadioButton radioButtonChampion;
        private System.Windows.Forms.RadioButton radioButtonUltimate;
        private System.Windows.Forms.RadioButton radioButtonMega;
		private System.Windows.Forms.RadioButton radioButtonDigiEggs;
		private System.Windows.Forms.RadioButton radioButtonBeyondMega;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
    }
}

