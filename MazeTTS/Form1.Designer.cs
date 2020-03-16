namespace MazeTTS
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
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rateBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.voiceBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rateBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.Control;
            this.play.ForeColor = System.Drawing.SystemColors.ControlText;
            this.play.Location = new System.Drawing.Point(12, 342);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(135, 342);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-1, -1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 173);
            this.textBox1.TabIndex = 2;
            // 
            // rateBar
            // 
            this.rateBar.Location = new System.Drawing.Point(12, 202);
            this.rateBar.Minimum = -6;
            this.rateBar.Name = "rateBar";
            this.rateBar.Size = new System.Drawing.Size(198, 45);
            this.rateBar.TabIndex = 3;
            this.rateBar.Scroll += new System.EventHandler(this.rateBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Speed";
            // 
            // volumeBar
            // 
            this.volumeBar.LargeChange = 10;
            this.volumeBar.Location = new System.Drawing.Point(12, 250);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(198, 45);
            this.volumeBar.SmallChange = 10;
            this.volumeBar.TabIndex = 5;
            this.volumeBar.Value = 50;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Volume";
            // 
            // voiceBox
            // 
            this.voiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voiceBox.FormattingEnabled = true;
            this.voiceBox.Location = new System.Drawing.Point(12, 301);
            this.voiceBox.Name = "voiceBox";
            this.voiceBox.Size = new System.Drawing.Size(198, 21);
            this.voiceBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Voice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(222, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.voiceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateBar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MazeTTS";
            ((System.ComponentModel.ISupportInitialize)(this.rateBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar rateBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox voiceBox;
        private System.Windows.Forms.Label label3;
    }
}

