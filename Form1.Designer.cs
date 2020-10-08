namespace Sluiter_ASG5_Yahtzee {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageListDie = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelHoldDie5 = new System.Windows.Forms.Label();
            this.labelHoldDie4 = new System.Windows.Forms.Label();
            this.labelHoldDie3 = new System.Windows.Forms.Label();
            this.labelHoldDie2 = new System.Windows.Forms.Label();
            this.labelHoldDie1 = new System.Windows.Forms.Label();
            this.labelRollCount = new System.Windows.Forms.Label();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.pictureBoxDie5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelGameTotal = new System.Windows.Forms.Label();
            this.labelLowerTotal = new System.Windows.Forms.Label();
            this.labelBonus = new System.Windows.Forms.Label();
            this.labelUpperTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSetLower = new System.Windows.Forms.Button();
            this.buttonSetUpper = new System.Windows.Forms.Button();
            this.listBoxLower = new System.Windows.Forms.ListBox();
            this.listBoxUpper = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListDie
            // 
            this.imageListDie.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDie.ImageStream")));
            this.imageListDie.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDie.Images.SetKeyName(0, "1Die.bmp");
            this.imageListDie.Images.SetKeyName(1, "2Die.bmp");
            this.imageListDie.Images.SetKeyName(2, "3Die.bmp");
            this.imageListDie.Images.SetKeyName(3, "4Die.bmp");
            this.imageListDie.Images.SetKeyName(4, "5Die.bmp");
            this.imageListDie.Images.SetKeyName(5, "6Die.bmp");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelHoldDie5);
            this.groupBox1.Controls.Add(this.labelHoldDie4);
            this.groupBox1.Controls.Add(this.labelHoldDie3);
            this.groupBox1.Controls.Add(this.labelHoldDie2);
            this.groupBox1.Controls.Add(this.labelHoldDie1);
            this.groupBox1.Controls.Add(this.labelRollCount);
            this.groupBox1.Controls.Add(this.buttonRoll);
            this.groupBox1.Controls.Add(this.pictureBoxDie5);
            this.groupBox1.Controls.Add(this.pictureBoxDie4);
            this.groupBox1.Controls.Add(this.pictureBoxDie3);
            this.groupBox1.Controls.Add(this.pictureBoxDie2);
            this.groupBox1.Controls.Add(this.pictureBoxDie1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelHoldDie5
            // 
            this.labelHoldDie5.AutoSize = true;
            this.labelHoldDie5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoldDie5.Location = new System.Drawing.Point(480, 126);
            this.labelHoldDie5.Name = "labelHoldDie5";
            this.labelHoldDie5.Size = new System.Drawing.Size(46, 20);
            this.labelHoldDie5.TabIndex = 11;
            this.labelHoldDie5.Text = "Hold";
            // 
            // labelHoldDie4
            // 
            this.labelHoldDie4.AutoSize = true;
            this.labelHoldDie4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoldDie4.Location = new System.Drawing.Point(370, 126);
            this.labelHoldDie4.Name = "labelHoldDie4";
            this.labelHoldDie4.Size = new System.Drawing.Size(46, 20);
            this.labelHoldDie4.TabIndex = 10;
            this.labelHoldDie4.Text = "Hold";
            // 
            // labelHoldDie3
            // 
            this.labelHoldDie3.AutoSize = true;
            this.labelHoldDie3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoldDie3.Location = new System.Drawing.Point(260, 126);
            this.labelHoldDie3.Name = "labelHoldDie3";
            this.labelHoldDie3.Size = new System.Drawing.Size(46, 20);
            this.labelHoldDie3.TabIndex = 9;
            this.labelHoldDie3.Text = "Hold";
            // 
            // labelHoldDie2
            // 
            this.labelHoldDie2.AutoSize = true;
            this.labelHoldDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoldDie2.Location = new System.Drawing.Point(150, 126);
            this.labelHoldDie2.Name = "labelHoldDie2";
            this.labelHoldDie2.Size = new System.Drawing.Size(46, 20);
            this.labelHoldDie2.TabIndex = 8;
            this.labelHoldDie2.Text = "Hold";
            // 
            // labelHoldDie1
            // 
            this.labelHoldDie1.AutoSize = true;
            this.labelHoldDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoldDie1.Location = new System.Drawing.Point(40, 126);
            this.labelHoldDie1.Name = "labelHoldDie1";
            this.labelHoldDie1.Size = new System.Drawing.Size(46, 20);
            this.labelHoldDie1.TabIndex = 7;
            this.labelHoldDie1.Text = "Hold";
            // 
            // labelRollCount
            // 
            this.labelRollCount.AutoSize = true;
            this.labelRollCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRollCount.Location = new System.Drawing.Point(232, 167);
            this.labelRollCount.Name = "labelRollCount";
            this.labelRollCount.Size = new System.Drawing.Size(116, 20);
            this.labelRollCount.TabIndex = 6;
            this.labelRollCount.Text = "Roll Them Dice";
            // 
            // buttonRoll
            // 
            this.buttonRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoll.Location = new System.Drawing.Point(16, 160);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(103, 35);
            this.buttonRoll.TabIndex = 5;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // pictureBoxDie5
            // 
            this.pictureBoxDie5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDie5.Location = new System.Drawing.Point(456, 19);
            this.pictureBoxDie5.Name = "pictureBoxDie5";
            this.pictureBoxDie5.Size = new System.Drawing.Size(104, 104);
            this.pictureBoxDie5.TabIndex = 4;
            this.pictureBoxDie5.TabStop = false;
            this.pictureBoxDie5.Click += new System.EventHandler(this.pictureBoxDie5_Click);
            // 
            // pictureBoxDie4
            // 
            this.pictureBoxDie4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDie4.Location = new System.Drawing.Point(346, 19);
            this.pictureBoxDie4.Name = "pictureBoxDie4";
            this.pictureBoxDie4.Size = new System.Drawing.Size(104, 104);
            this.pictureBoxDie4.TabIndex = 3;
            this.pictureBoxDie4.TabStop = false;
            this.pictureBoxDie4.Click += new System.EventHandler(this.pictureBoxDie4_Click);
            // 
            // pictureBoxDie3
            // 
            this.pictureBoxDie3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDie3.Location = new System.Drawing.Point(236, 19);
            this.pictureBoxDie3.Name = "pictureBoxDie3";
            this.pictureBoxDie3.Size = new System.Drawing.Size(104, 104);
            this.pictureBoxDie3.TabIndex = 2;
            this.pictureBoxDie3.TabStop = false;
            this.pictureBoxDie3.Click += new System.EventHandler(this.pictureBoxDie3_Click);
            // 
            // pictureBoxDie2
            // 
            this.pictureBoxDie2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDie2.Location = new System.Drawing.Point(126, 19);
            this.pictureBoxDie2.Name = "pictureBoxDie2";
            this.pictureBoxDie2.Size = new System.Drawing.Size(104, 104);
            this.pictureBoxDie2.TabIndex = 1;
            this.pictureBoxDie2.TabStop = false;
            this.pictureBoxDie2.Click += new System.EventHandler(this.pictureBoxDie2_Click);
            // 
            // pictureBoxDie1
            // 
            this.pictureBoxDie1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDie1.Location = new System.Drawing.Point(16, 19);
            this.pictureBoxDie1.Name = "pictureBoxDie1";
            this.pictureBoxDie1.Size = new System.Drawing.Size(104, 104);
            this.pictureBoxDie1.TabIndex = 0;
            this.pictureBoxDie1.TabStop = false;
            this.pictureBoxDie1.Click += new System.EventHandler(this.pictureBoxDie1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelGameTotal);
            this.groupBox2.Controls.Add(this.labelLowerTotal);
            this.groupBox2.Controls.Add(this.labelBonus);
            this.groupBox2.Controls.Add(this.labelUpperTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonSetLower);
            this.groupBox2.Controls.Add(this.buttonSetUpper);
            this.groupBox2.Controls.Add(this.listBoxLower);
            this.groupBox2.Controls.Add(this.listBoxUpper);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // labelGameTotal
            // 
            this.labelGameTotal.AutoSize = true;
            this.labelGameTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameTotal.Location = new System.Drawing.Point(412, 212);
            this.labelGameTotal.Name = "labelGameTotal";
            this.labelGameTotal.Size = new System.Drawing.Size(16, 16);
            this.labelGameTotal.TabIndex = 11;
            this.labelGameTotal.Text = "0";
            // 
            // labelLowerTotal
            // 
            this.labelLowerTotal.AutoSize = true;
            this.labelLowerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLowerTotal.Location = new System.Drawing.Point(412, 152);
            this.labelLowerTotal.Name = "labelLowerTotal";
            this.labelLowerTotal.Size = new System.Drawing.Size(16, 16);
            this.labelLowerTotal.TabIndex = 10;
            this.labelLowerTotal.Text = "0";
            // 
            // labelBonus
            // 
            this.labelBonus.AutoSize = true;
            this.labelBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBonus.Location = new System.Drawing.Point(139, 212);
            this.labelBonus.Name = "labelBonus";
            this.labelBonus.Size = new System.Drawing.Size(16, 16);
            this.labelBonus.TabIndex = 9;
            this.labelBonus.Text = "0";
            // 
            // labelUpperTotal
            // 
            this.labelUpperTotal.AutoSize = true;
            this.labelUpperTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpperTotal.Location = new System.Drawing.Point(139, 152);
            this.labelUpperTotal.Name = "labelUpperTotal";
            this.labelUpperTotal.Size = new System.Drawing.Size(16, 16);
            this.labelUpperTotal.TabIndex = 8;
            this.labelUpperTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Game Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lower Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bonus ( > 62 ): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upper Total:";
            // 
            // buttonSetLower
            // 
            this.buttonSetLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetLower.Location = new System.Drawing.Point(442, 50);
            this.buttonSetLower.Name = "buttonSetLower";
            this.buttonSetLower.Size = new System.Drawing.Size(75, 33);
            this.buttonSetLower.TabIndex = 3;
            this.buttonSetLower.Text = "Set";
            this.buttonSetLower.UseVisualStyleBackColor = true;
            this.buttonSetLower.Click += new System.EventHandler(this.buttonSetLower_Click);
            // 
            // buttonSetUpper
            // 
            this.buttonSetUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetUpper.Location = new System.Drawing.Point(142, 50);
            this.buttonSetUpper.Name = "buttonSetUpper";
            this.buttonSetUpper.Size = new System.Drawing.Size(75, 33);
            this.buttonSetUpper.TabIndex = 2;
            this.buttonSetUpper.Text = "Set";
            this.buttonSetUpper.UseVisualStyleBackColor = true;
            this.buttonSetUpper.Click += new System.EventHandler(this.buttonSetUpper_Click);
            // 
            // listBoxLower
            // 
            this.listBoxLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLower.FormattingEnabled = true;
            this.listBoxLower.ItemHeight = 16;
            this.listBoxLower.Items.AddRange(new object[] {
            "Three Of A Kind: ",
            "Four Of A Kind: ",
            "Full House: ",
            "Small Straight: ",
            "Large Straight: ",
            "Yahtzee: ",
            "Chance: "});
            this.listBoxLower.Location = new System.Drawing.Point(316, 19);
            this.listBoxLower.Name = "listBoxLower";
            this.listBoxLower.Size = new System.Drawing.Size(120, 116);
            this.listBoxLower.TabIndex = 1;
            // 
            // listBoxUpper
            // 
            this.listBoxUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUpper.FormattingEnabled = true;
            this.listBoxUpper.ItemHeight = 16;
            this.listBoxUpper.Items.AddRange(new object[] {
            "Ones: ",
            "Twos: ",
            "Threes: ",
            "Fours: ",
            "Fives: ",
            "Sixes: "});
            this.listBoxUpper.Location = new System.Drawing.Point(16, 19);
            this.listBoxUpper.Name = "listBoxUpper";
            this.listBoxUpper.Size = new System.Drawing.Size(120, 116);
            this.listBoxUpper.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sluiter-ASG5-Yahtzee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListDie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRollCount;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.PictureBox pictureBoxDie5;
        private System.Windows.Forms.PictureBox pictureBoxDie4;
        private System.Windows.Forms.PictureBox pictureBoxDie3;
        private System.Windows.Forms.PictureBox pictureBoxDie2;
        private System.Windows.Forms.PictureBox pictureBoxDie1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelGameTotal;
        private System.Windows.Forms.Label labelLowerTotal;
        private System.Windows.Forms.Label labelBonus;
        private System.Windows.Forms.Label labelUpperTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetLower;
        private System.Windows.Forms.Button buttonSetUpper;
        private System.Windows.Forms.ListBox listBoxLower;
        private System.Windows.Forms.ListBox listBoxUpper;
        private System.Windows.Forms.Label labelHoldDie5;
        private System.Windows.Forms.Label labelHoldDie4;
        private System.Windows.Forms.Label labelHoldDie3;
        private System.Windows.Forms.Label labelHoldDie2;
        private System.Windows.Forms.Label labelHoldDie1;
    }
}

