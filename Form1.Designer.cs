
namespace DogRace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.BobLabel = new System.Windows.Forms.Label();
            this.AlLabel = new System.Windows.Forms.Label();
            this.JoeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.Button();
            this.dogNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.betNumeric = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.NameOfBettorLabel = new System.Windows.Forms.Label();
            this.BobRadio = new System.Windows.Forms.RadioButton();
            this.AlRadio = new System.Windows.Forms.RadioButton();
            this.JoeRadio = new System.Windows.Forms.RadioButton();
            this.MinimumBetLabel = new System.Windows.Forms.Label();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.BobLabel);
            this.groupBox1.Controls.Add(this.AlLabel);
            this.groupBox1.Controls.Add(this.JoeLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Race);
            this.groupBox1.Controls.Add(this.dogNumberNumeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.betNumeric);
            this.groupBox1.Controls.Add(this.betsButton);
            this.groupBox1.Controls.Add(this.NameOfBettorLabel);
            this.groupBox1.Controls.Add(this.BobRadio);
            this.groupBox1.Controls.Add(this.AlRadio);
            this.groupBox1.Controls.Add(this.JoeRadio);
            this.groupBox1.Controls.Add(this.MinimumBetLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(3, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Section";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(587, 160);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(85, 25);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset Position!";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // BobLabel
            // 
            this.BobLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BobLabel.Location = new System.Drawing.Point(617, 105);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(356, 26);
            this.BobLabel.TabIndex = 13;
            this.BobLabel.Text = "Bob\'s Bet";
            this.BobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlLabel
            // 
            this.AlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlLabel.Location = new System.Drawing.Point(617, 66);
            this.AlLabel.Name = "AlLabel";
            this.AlLabel.Size = new System.Drawing.Size(356, 26);
            this.AlLabel.TabIndex = 12;
            this.AlLabel.Text = "Al\'s Bet";
            this.AlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JoeLabel
            // 
            this.JoeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoeLabel.Location = new System.Drawing.Point(617, 32);
            this.JoeLabel.Name = "JoeLabel";
            this.JoeLabel.Size = new System.Drawing.Size(356, 25);
            this.JoeLabel.TabIndex = 11;
            this.JoeLabel.Text = "Joe\'s Bet";
            this.JoeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JoeLabel.Click += new System.EventHandler(this.JoeLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bet Amount";
            // 
            // Race
            // 
            this.Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race.Location = new System.Drawing.Point(749, 145);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(144, 40);
            this.Race.TabIndex = 9;
            this.Race.Text = "Race!";
            this.Race.UseVisualStyleBackColor = true;
            this.Race.Click += new System.EventHandler(this.Race_Click);
            // 
            // dogNumberNumeric
            // 
            this.dogNumberNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dogNumberNumeric.Location = new System.Drawing.Point(126, 164);
            this.dogNumberNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumberNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumberNumeric.Name = "dogNumberNumeric";
            this.dogNumberNumeric.Size = new System.Drawing.Size(54, 26);
            this.dogNumberNumeric.TabIndex = 8;
            this.dogNumberNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 164);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bet On Dog";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // betNumeric
            // 
            this.betNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.betNumeric.Location = new System.Drawing.Point(342, 160);
            this.betNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betNumeric.Name = "betNumeric";
            this.betNumeric.Size = new System.Drawing.Size(54, 26);
            this.betNumeric.TabIndex = 6;
            this.betNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(281, 85);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(104, 46);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Place Bet";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // NameOfBettorLabel
            // 
            this.NameOfBettorLabel.AutoSize = true;
            this.NameOfBettorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfBettorLabel.Location = new System.Drawing.Point(305, 22);
            this.NameOfBettorLabel.Name = "NameOfBettorLabel";
            this.NameOfBettorLabel.Size = new System.Drawing.Size(53, 24);
            this.NameOfBettorLabel.TabIndex = 4;
            this.NameOfBettorLabel.Text = "Who";
            this.NameOfBettorLabel.Click += new System.EventHandler(this.NameOfBettorLabel_Click);
            // 
            // BobRadio
            // 
            this.BobRadio.AutoSize = true;
            this.BobRadio.ForeColor = System.Drawing.Color.OrangeRed;
            this.BobRadio.Location = new System.Drawing.Point(74, 125);
            this.BobRadio.Name = "BobRadio";
            this.BobRadio.Size = new System.Drawing.Size(59, 24);
            this.BobRadio.TabIndex = 3;
            this.BobRadio.TabStop = true;
            this.BobRadio.Text = "Bob";
            this.BobRadio.UseVisualStyleBackColor = true;
            this.BobRadio.Click += new System.EventHandler(this.radioclicked);
            // 
            // AlRadio
            // 
            this.AlRadio.AutoSize = true;
            this.AlRadio.ForeColor = System.Drawing.Color.OrangeRed;
            this.AlRadio.Location = new System.Drawing.Point(74, 85);
            this.AlRadio.Name = "AlRadio";
            this.AlRadio.Size = new System.Drawing.Size(43, 24);
            this.AlRadio.TabIndex = 2;
            this.AlRadio.TabStop = true;
            this.AlRadio.Text = "Al";
            this.AlRadio.UseVisualStyleBackColor = true;
            this.AlRadio.Click += new System.EventHandler(this.radioclicked);
            // 
            // JoeRadio
            // 
            this.JoeRadio.AutoSize = true;
            this.JoeRadio.ForeColor = System.Drawing.Color.OrangeRed;
            this.JoeRadio.Location = new System.Drawing.Point(74, 48);
            this.JoeRadio.Name = "JoeRadio";
            this.JoeRadio.Size = new System.Drawing.Size(56, 24);
            this.JoeRadio.TabIndex = 1;
            this.JoeRadio.TabStop = true;
            this.JoeRadio.Text = "Joe";
            this.JoeRadio.UseVisualStyleBackColor = true;
            this.JoeRadio.Click += new System.EventHandler(this.radioclicked);
            // 
            // MinimumBetLabel
            // 
            this.MinimumBetLabel.AutoSize = true;
            this.MinimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumBetLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumBetLabel.Location = new System.Drawing.Point(355, 22);
            this.MinimumBetLabel.Name = "MinimumBetLabel";
            this.MinimumBetLabel.Size = new System.Drawing.Size(120, 24);
            this.MinimumBetLabel.TabIndex = 0;
            this.MinimumBetLabel.Text = "Minimum Bet";
            this.MinimumBetLabel.Click += new System.EventHandler(this.MinimumBetLabel_Click);
            // 
            // Dog2
            // 
            this.Dog2.Image = ((System.Drawing.Image)(resources.GetObject("Dog2.Image")));
            this.Dog2.Location = new System.Drawing.Point(29, 66);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(76, 23);
            this.Dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog2.TabIndex = 4;
            this.Dog2.TabStop = false;
            this.Dog2.Click += new System.EventHandler(this.Dog2_Click);
            // 
            // Dog1
            // 
            this.Dog1.Image = ((System.Drawing.Image)(resources.GetObject("Dog1.Image")));
            this.Dog1.Location = new System.Drawing.Point(29, 17);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(76, 23);
            this.Dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog1.TabIndex = 5;
            this.Dog1.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.Image = ((System.Drawing.Image)(resources.GetObject("Dog3.Image")));
            this.Dog3.Location = new System.Drawing.Point(29, 120);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(76, 23);
            this.Dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog3.TabIndex = 6;
            this.Dog3.TabStop = false;
            // 
            // Dog4
            // 
            this.Dog4.Image = ((System.Drawing.Image)(resources.GetObject("Dog4.Image")));
            this.Dog4.Location = new System.Drawing.Point(29, 169);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(76, 23);
            this.Dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog4.TabIndex = 7;
            this.Dog4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(801, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 211);
            this.button1.TabIndex = 8;
            this.button1.Text = "FINISH";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(77, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(729, 10);
            this.button2.TabIndex = 9;
            this.button2.Text = "FINISH";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(77, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(729, 10);
            this.button3.TabIndex = 10;
            this.button3.Text = "FINISH";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(77, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(729, 10);
            this.button4.TabIndex = 11;
            this.button4.Text = "FINISH";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(77, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(729, 10);
            this.button5.TabIndex = 12;
            this.button5.Text = "FINISH";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(77, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(729, 10);
            this.button6.TabIndex = 13;
            this.button6.Text = "FINISH";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(94, -3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 211);
            this.button7.TabIndex = 14;
            this.button7.Text = "START";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.radioclicked);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label BobLabel;
        private System.Windows.Forms.Label AlLabel;
        private System.Windows.Forms.Label JoeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Race;
        private System.Windows.Forms.NumericUpDown dogNumberNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown betNumeric;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label NameOfBettorLabel;
        private System.Windows.Forms.RadioButton BobRadio;
        private System.Windows.Forms.RadioButton AlRadio;
        private System.Windows.Forms.RadioButton JoeRadio;
        private System.Windows.Forms.Label MinimumBetLabel;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

