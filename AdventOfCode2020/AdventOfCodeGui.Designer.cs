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
            this._day1 = new System.Windows.Forms.Button();
            this._output = new System.Windows.Forms.RichTextBox();
            this._day2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _day1
            // 
            this._day1.Location = new System.Drawing.Point(13, 13);
            this._day1.Name = "_day1";
            this._day1.Size = new System.Drawing.Size(110, 42);
            this._day1.TabIndex = 0;
            this._day1.Text = "Day 01";
            this._day1.UseVisualStyleBackColor = true;
            this._day1.Click += new System.EventHandler(this._day1_Click);
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
            // _day2
            // 
            this._day2.Location = new System.Drawing.Point(12, 61);
            this._day2.Name = "_day2";
            this._day2.Size = new System.Drawing.Size(110, 42);
            this._day2.TabIndex = 2;
            this._day2.Text = "Day 02";
            this._day2.UseVisualStyleBackColor = true;
            this._day2.Click += new System.EventHandler(this._day2_Click);
            // 
            // AdventOfCodeGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 814);
            this.Controls.Add(this._day2);
            this.Controls.Add(this._output);
            this.Controls.Add(this._day1);
            this.Name = "AdventOfCodeGui";
            this.Text = "Advent of Code 2020";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _day1;
        private System.Windows.Forms.RichTextBox _output;
        private System.Windows.Forms.Button _day2;
    }
}

