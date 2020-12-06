namespace AdventOfCode2020
{
    partial class AdventOfCodeGui
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
            this._day01 = new System.Windows.Forms.Button();
            this._output = new System.Windows.Forms.RichTextBox();
            this._day02 = new System.Windows.Forms.Button();
            this._day03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _day01
            // 
            this._day01.Location = new System.Drawing.Point(13, 13);
            this._day01.Name = "_day01";
            this._day01.Size = new System.Drawing.Size(110, 42);
            this._day01.TabIndex = 0;
            this._day01.Text = "Day 01";
            this._day01.UseVisualStyleBackColor = true;
            this._day01.Click += new System.EventHandler(this._day01_Click);
            // 
            // _output
            // 
            this._output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._output.Location = new System.Drawing.Point(12, 416);
            this._output.Name = "_output";
            this._output.Size = new System.Drawing.Size(1156, 386);
            this._output.TabIndex = 1;
            this._output.Text = "";
            // 
            // _day02
            // 
            this._day02.Location = new System.Drawing.Point(12, 61);
            this._day02.Name = "_day02";
            this._day02.Size = new System.Drawing.Size(110, 42);
            this._day02.TabIndex = 2;
            this._day02.Text = "Day 02";
            this._day02.UseVisualStyleBackColor = true;
            this._day02.Click += new System.EventHandler(this._day02_Click);
            // 
            // _day03
            // 
            this._day03.Location = new System.Drawing.Point(13, 109);
            this._day03.Name = "_day03";
            this._day03.Size = new System.Drawing.Size(110, 42);
            this._day03.TabIndex = 3;
            this._day03.Text = "Day 03";
            this._day03.UseVisualStyleBackColor = true;
            this._day03.Click += new System.EventHandler(this._day03_Click);
            // 
            // AdventOfCodeGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 814);
            this.Controls.Add(this._day03);
            this.Controls.Add(this._day02);
            this.Controls.Add(this._output);
            this.Controls.Add(this._day01);
            this.Name = "AdventOfCodeGui";
            this.Text = "Advent of Code 2020";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _day01;
        private System.Windows.Forms.RichTextBox _output;
        private System.Windows.Forms.Button _day02;
        private System.Windows.Forms.Button _day03;
    }
}

