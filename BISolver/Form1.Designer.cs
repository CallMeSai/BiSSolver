namespace BISolver
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
            this.lblJob = new System.Windows.Forms.Label();
            this.lbliLvlMin = new System.Windows.Forms.Label();
            this.lbliLvlMax = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.numMinLvl = new System.Windows.Forms.NumericUpDown();
            this.numMaxLvl = new System.Windows.Forms.NumericUpDown();
            this.cmbAttr = new System.Windows.Forms.ComboBox();
            this.lblAttr = new System.Windows.Forms.Label();
            this.pctWeapon = new System.Windows.Forms.PictureBox();
            this.pctHands = new System.Windows.Forms.PictureBox();
            this.pctWaist = new System.Windows.Forms.PictureBox();
            this.pctLegs = new System.Windows.Forms.PictureBox();
            this.pctFeet = new System.Windows.Forms.PictureBox();
            this.pctOH = new System.Windows.Forms.PictureBox();
            this.pctEarrings = new System.Windows.Forms.PictureBox();
            this.pctNecklace = new System.Windows.Forms.PictureBox();
            this.pctBracelet = new System.Windows.Forms.PictureBox();
            this.pctRing1 = new System.Windows.Forms.PictureBox();
            this.pctBody = new System.Windows.Forms.PictureBox();
            this.pctHead = new System.Windows.Forms.PictureBox();
            this.pctRing2 = new System.Windows.Forms.PictureBox();
            this.lstStats = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWaist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFeet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEarrings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNecklace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBracelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRing1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRing2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(14, 9);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(27, 13);
            this.lblJob.TabIndex = 3;
            this.lblJob.Text = "Job:";
            // 
            // lbliLvlMin
            // 
            this.lbliLvlMin.AutoSize = true;
            this.lbliLvlMin.Location = new System.Drawing.Point(14, 61);
            this.lbliLvlMin.Name = "lbliLvlMin";
            this.lbliLvlMin.Size = new System.Drawing.Size(46, 13);
            this.lbliLvlMin.TabIndex = 4;
            this.lbliLvlMin.Text = "Min iLvl:";
            // 
            // lbliLvlMax
            // 
            this.lbliLvlMax.AutoSize = true;
            this.lbliLvlMax.Location = new System.Drawing.Point(14, 110);
            this.lbliLvlMax.Name = "lbliLvlMax";
            this.lbliLvlMax.Size = new System.Drawing.Size(49, 13);
            this.lbliLvlMax.TabIndex = 5;
            this.lbliLvlMax.Text = "Max iLvl:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(97, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(12, 192);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(267, 251);
            this.lstResult.TabIndex = 7;
            // 
            // cmbJob
            // 
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Location = new System.Drawing.Point(14, 25);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(121, 21);
            this.cmbJob.TabIndex = 8;
            this.cmbJob.Text = "Paladin";
            // 
            // numMinLvl
            // 
            this.numMinLvl.Location = new System.Drawing.Point(14, 77);
            this.numMinLvl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMinLvl.Name = "numMinLvl";
            this.numMinLvl.Size = new System.Drawing.Size(120, 20);
            this.numMinLvl.TabIndex = 9;
            this.numMinLvl.Value = new decimal(new int[] {
            370,
            0,
            0,
            0});
            // 
            // numMaxLvl
            // 
            this.numMaxLvl.Location = new System.Drawing.Point(14, 126);
            this.numMaxLvl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxLvl.Name = "numMaxLvl";
            this.numMaxLvl.Size = new System.Drawing.Size(120, 20);
            this.numMaxLvl.TabIndex = 10;
            this.numMaxLvl.Value = new decimal(new int[] {
            375,
            0,
            0,
            0});
            // 
            // cmbAttr
            // 
            this.cmbAttr.FormattingEnabled = true;
            this.cmbAttr.Location = new System.Drawing.Point(141, 24);
            this.cmbAttr.Name = "cmbAttr";
            this.cmbAttr.Size = new System.Drawing.Size(121, 21);
            this.cmbAttr.TabIndex = 11;
            this.cmbAttr.Text = "Critical Hit";
            // 
            // lblAttr
            // 
            this.lblAttr.AutoSize = true;
            this.lblAttr.Location = new System.Drawing.Point(138, 9);
            this.lblAttr.Name = "lblAttr";
            this.lblAttr.Size = new System.Drawing.Size(72, 13);
            this.lblAttr.TabIndex = 12;
            this.lblAttr.Text = "Main Attribute";
            // 
            // pctWeapon
            // 
            this.pctWeapon.Location = new System.Drawing.Point(284, 54);
            this.pctWeapon.Name = "pctWeapon";
            this.pctWeapon.Size = new System.Drawing.Size(50, 50);
            this.pctWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctWeapon.TabIndex = 13;
            this.pctWeapon.TabStop = false;
            // 
            // pctHands
            // 
            this.pctHands.Location = new System.Drawing.Point(284, 222);
            this.pctHands.Name = "pctHands";
            this.pctHands.Size = new System.Drawing.Size(50, 50);
            this.pctHands.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctHands.TabIndex = 14;
            this.pctHands.TabStop = false;
            // 
            // pctWaist
            // 
            this.pctWaist.Location = new System.Drawing.Point(284, 277);
            this.pctWaist.Name = "pctWaist";
            this.pctWaist.Size = new System.Drawing.Size(50, 50);
            this.pctWaist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctWaist.TabIndex = 15;
            this.pctWaist.TabStop = false;
            // 
            // pctLegs
            // 
            this.pctLegs.Location = new System.Drawing.Point(284, 333);
            this.pctLegs.Name = "pctLegs";
            this.pctLegs.Size = new System.Drawing.Size(50, 50);
            this.pctLegs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLegs.TabIndex = 16;
            this.pctLegs.TabStop = false;
            // 
            // pctFeet
            // 
            this.pctFeet.Location = new System.Drawing.Point(284, 389);
            this.pctFeet.Name = "pctFeet";
            this.pctFeet.Size = new System.Drawing.Size(50, 50);
            this.pctFeet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFeet.TabIndex = 17;
            this.pctFeet.TabStop = false;
            // 
            // pctOH
            // 
            this.pctOH.Location = new System.Drawing.Point(340, 110);
            this.pctOH.Name = "pctOH";
            this.pctOH.Size = new System.Drawing.Size(50, 50);
            this.pctOH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctOH.TabIndex = 18;
            this.pctOH.TabStop = false;
            // 
            // pctEarrings
            // 
            this.pctEarrings.Location = new System.Drawing.Point(340, 165);
            this.pctEarrings.Name = "pctEarrings";
            this.pctEarrings.Size = new System.Drawing.Size(50, 50);
            this.pctEarrings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEarrings.TabIndex = 19;
            this.pctEarrings.TabStop = false;
            // 
            // pctNecklace
            // 
            this.pctNecklace.Location = new System.Drawing.Point(340, 222);
            this.pctNecklace.Name = "pctNecklace";
            this.pctNecklace.Size = new System.Drawing.Size(50, 50);
            this.pctNecklace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctNecklace.TabIndex = 20;
            this.pctNecklace.TabStop = false;
            // 
            // pctBracelet
            // 
            this.pctBracelet.Location = new System.Drawing.Point(340, 277);
            this.pctBracelet.Name = "pctBracelet";
            this.pctBracelet.Size = new System.Drawing.Size(50, 50);
            this.pctBracelet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBracelet.TabIndex = 21;
            this.pctBracelet.TabStop = false;
            // 
            // pctRing1
            // 
            this.pctRing1.Location = new System.Drawing.Point(340, 333);
            this.pctRing1.Name = "pctRing1";
            this.pctRing1.Size = new System.Drawing.Size(50, 50);
            this.pctRing1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRing1.TabIndex = 22;
            this.pctRing1.TabStop = false;
            // 
            // pctBody
            // 
            this.pctBody.Location = new System.Drawing.Point(284, 166);
            this.pctBody.Name = "pctBody";
            this.pctBody.Size = new System.Drawing.Size(50, 50);
            this.pctBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBody.TabIndex = 23;
            this.pctBody.TabStop = false;
            // 
            // pctHead
            // 
            this.pctHead.Location = new System.Drawing.Point(284, 110);
            this.pctHead.Name = "pctHead";
            this.pctHead.Size = new System.Drawing.Size(50, 50);
            this.pctHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctHead.TabIndex = 24;
            this.pctHead.TabStop = false;
            // 
            // pctRing2
            // 
            this.pctRing2.Location = new System.Drawing.Point(340, 389);
            this.pctRing2.Name = "pctRing2";
            this.pctRing2.Size = new System.Drawing.Size(50, 50);
            this.pctRing2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRing2.TabIndex = 25;
            this.pctRing2.TabStop = false;
            // 
            // lstStats
            // 
            this.lstStats.FormattingEnabled = true;
            this.lstStats.Location = new System.Drawing.Point(140, 51);
            this.lstStats.Name = "lstStats";
            this.lstStats.Size = new System.Drawing.Size(120, 95);
            this.lstStats.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.lstStats);
            this.Controls.Add(this.pctRing2);
            this.Controls.Add(this.pctHead);
            this.Controls.Add(this.pctBody);
            this.Controls.Add(this.pctRing1);
            this.Controls.Add(this.pctBracelet);
            this.Controls.Add(this.pctNecklace);
            this.Controls.Add(this.pctEarrings);
            this.Controls.Add(this.pctOH);
            this.Controls.Add(this.pctFeet);
            this.Controls.Add(this.pctLegs);
            this.Controls.Add(this.pctWaist);
            this.Controls.Add(this.pctHands);
            this.Controls.Add(this.pctWeapon);
            this.Controls.Add(this.lblAttr);
            this.Controls.Add(this.cmbAttr);
            this.Controls.Add(this.numMaxLvl);
            this.Controls.Add(this.numMinLvl);
            this.Controls.Add(this.cmbJob);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbliLvlMax);
            this.Controls.Add(this.lbliLvlMin);
            this.Controls.Add(this.lblJob);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numMinLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWaist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFeet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEarrings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNecklace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBracelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRing1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRing2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lbliLvlMin;
        private System.Windows.Forms.Label lbliLvlMax;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.NumericUpDown numMinLvl;
        private System.Windows.Forms.NumericUpDown numMaxLvl;
        private System.Windows.Forms.ComboBox cmbAttr;
        private System.Windows.Forms.Label lblAttr;
        private System.Windows.Forms.PictureBox pctWeapon;
        private System.Windows.Forms.PictureBox pctHands;
        private System.Windows.Forms.PictureBox pctWaist;
        private System.Windows.Forms.PictureBox pctLegs;
        private System.Windows.Forms.PictureBox pctFeet;
        private System.Windows.Forms.PictureBox pctOH;
        private System.Windows.Forms.PictureBox pctEarrings;
        private System.Windows.Forms.PictureBox pctNecklace;
        private System.Windows.Forms.PictureBox pctBracelet;
        private System.Windows.Forms.PictureBox pctRing1;
        private System.Windows.Forms.PictureBox pctBody;
        private System.Windows.Forms.PictureBox pctHead;
        private System.Windows.Forms.PictureBox pctRing2;
        private System.Windows.Forms.ListBox lstStats;
    }
}

