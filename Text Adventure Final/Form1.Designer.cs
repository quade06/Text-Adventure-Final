namespace Text_Adventure_Final
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
            this.NarratorLabel = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.Button();
            this.Option2 = new System.Windows.Forms.Button();
            this.timerLable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // NarratorLabel
            // 
            this.NarratorLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NarratorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NarratorLabel.Location = new System.Drawing.Point(-3, -2);
            this.NarratorLabel.Name = "NarratorLabel";
            this.NarratorLabel.Size = new System.Drawing.Size(803, 78);
            this.NarratorLabel.TabIndex = 0;
            this.NarratorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Option1
            // 
            this.Option1.Location = new System.Drawing.Point(0, 346);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(800, 57);
            this.Option1.TabIndex = 1;
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.Click += new System.EventHandler(this.Option1_Click);
            // 
            // Option2
            // 
            this.Option2.Location = new System.Drawing.Point(0, 400);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(800, 51);
            this.Option2.TabIndex = 2;
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.Click += new System.EventHandler(this.Option2_Click);
            // 
            // timerLable
            // 
            this.timerLable.BackColor = System.Drawing.Color.Transparent;
            this.timerLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timerLable.Location = new System.Drawing.Point(700, 86);
            this.timerLable.Name = "timerLable";
            this.timerLable.Size = new System.Drawing.Size(100, 83);
            this.timerLable.TabIndex = 3;
            this.timerLable.Click += new System.EventHandler(this.timerLable_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Text_Adventure_Final.Properties.Resources.jungle_backround;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timerLable);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.NarratorLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NarratorLabel;
        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button Option2;
        private System.Windows.Forms.Label timerLable;
        private System.Windows.Forms.Timer timer1;
    }
}

