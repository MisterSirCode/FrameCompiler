namespace FrameCompiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SelectFramesButton = new System.Windows.Forms.Button();
            this.FrameRangeDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.FormatType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RenderButton = new System.Windows.Forms.Button();
            this.RenderBox = new System.Windows.Forms.PictureBox();
            this.FramesPerSecond = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VideoLengthLabel = new System.Windows.Forms.Label();
            this.CoverPanel = new System.Windows.Forms.Panel();
            this.CoverText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RenderBox)).BeginInit();
            this.CoverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFramesButton
            // 
            this.SelectFramesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SelectFramesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.SelectFramesButton.Location = new System.Drawing.Point(12, 12);
            this.SelectFramesButton.Name = "SelectFramesButton";
            this.SelectFramesButton.Size = new System.Drawing.Size(140, 32);
            this.SelectFramesButton.TabIndex = 0;
            this.SelectFramesButton.Text = "Select Initial Frame";
            this.SelectFramesButton.UseVisualStyleBackColor = false;
            this.SelectFramesButton.Click += new System.EventHandler(this.SelectFramesButton_Click);
            // 
            // FrameRangeDialog
            // 
            this.FrameRangeDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FrameRangeDialog_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(15, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Format";
            // 
            // FormatType
            // 
            this.FormatType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FormatType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FormatType.FormattingEnabled = true;
            this.FormatType.Items.AddRange(new object[] {
            "MP4"});
            this.FormatType.Location = new System.Drawing.Point(15, 137);
            this.FormatType.Name = "FormatType";
            this.FormatType.Size = new System.Drawing.Size(134, 21);
            this.FormatType.TabIndex = 2;
            this.FormatType.Text = "MP4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FPS";
            // 
            // RenderButton
            // 
            this.RenderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RenderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.RenderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RenderButton.Location = new System.Drawing.Point(15, 414);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Size = new System.Drawing.Size(140, 47);
            this.RenderButton.TabIndex = 5;
            this.RenderButton.Text = "Render";
            this.RenderButton.UseVisualStyleBackColor = false;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // RenderBox
            // 
            this.RenderBox.BackColor = System.Drawing.Color.Black;
            this.RenderBox.Image = ((System.Drawing.Image)(resources.GetObject("RenderBox.Image")));
            this.RenderBox.Location = new System.Drawing.Point(169, 12);
            this.RenderBox.Name = "RenderBox";
            this.RenderBox.Size = new System.Drawing.Size(449, 449);
            this.RenderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RenderBox.TabIndex = 6;
            this.RenderBox.TabStop = false;
            // 
            // FramesPerSecond
            // 
            this.FramesPerSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FramesPerSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FramesPerSecond.FormattingEnabled = true;
            this.FramesPerSecond.Items.AddRange(new object[] {
            "23.98",
            "24",
            "25",
            "29.97",
            "30",
            "50",
            "59.94",
            "60",
            "120",
            "240"});
            this.FramesPerSecond.Location = new System.Drawing.Point(15, 186);
            this.FramesPerSecond.Name = "FramesPerSecond";
            this.FramesPerSecond.Size = new System.Drawing.Size(134, 21);
            this.FramesPerSecond.TabIndex = 8;
            this.FramesPerSecond.Text = "60";
            this.FramesPerSecond.SelectedIndexChanged += new System.EventHandler(this.FramesPerSecond_SelectedIndexChanged);
            this.FramesPerSecond.SelectionChangeCommitted += new System.EventHandler(this.FramesPerSecond_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button1.Location = new System.Drawing.Point(12, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Select Output Location";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "* If not specified, defaults";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "to initial frame\'s folder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(15, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Approx. Video Length";
            // 
            // VideoLengthLabel
            // 
            this.VideoLengthLabel.AutoSize = true;
            this.VideoLengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.VideoLengthLabel.Font = new System.Drawing.Font("Fira Code Light", 14F);
            this.VideoLengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.VideoLengthLabel.Location = new System.Drawing.Point(12, 387);
            this.VideoLengthLabel.Name = "VideoLengthLabel";
            this.VideoLengthLabel.Size = new System.Drawing.Size(142, 24);
            this.VideoLengthLabel.TabIndex = 13;
            this.VideoLengthLabel.Text = "00:00:00.00";
            // 
            // CoverPanel
            // 
            this.CoverPanel.BackColor = System.Drawing.Color.Transparent;
            this.CoverPanel.Controls.Add(this.CoverText);
            this.CoverPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CoverPanel.Location = new System.Drawing.Point(0, -1);
            this.CoverPanel.Name = "CoverPanel";
            this.CoverPanel.Size = new System.Drawing.Size(630, 10);
            this.CoverPanel.TabIndex = 14;
            // 
            // CoverText
            // 
            this.CoverText.AutoSize = true;
            this.CoverText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CoverText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CoverText.Location = new System.Drawing.Point(7, 435);
            this.CoverText.Name = "CoverText";
            this.CoverText.Size = new System.Drawing.Size(278, 29);
            this.CoverText.TabIndex = 0;
            this.CoverText.Text = "Rendering... Please Wait";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(630, 473);
            this.Controls.Add(this.CoverPanel);
            this.Controls.Add(this.VideoLengthLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FramesPerSecond);
            this.Controls.Add(this.RenderBox);
            this.Controls.Add(this.RenderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FormatType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectFramesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Frame Compiler 0.0.1a";
            ((System.ComponentModel.ISupportInitialize)(this.RenderBox)).EndInit();
            this.CoverPanel.ResumeLayout(false);
            this.CoverPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFramesButton;
        private System.Windows.Forms.OpenFileDialog FrameRangeDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FormatType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.PictureBox RenderBox;
        private System.Windows.Forms.ComboBox FramesPerSecond;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label VideoLengthLabel;
        private System.Windows.Forms.Panel CoverPanel;
        private System.Windows.Forms.Label CoverText;
    }
}

