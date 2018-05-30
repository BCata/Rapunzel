namespace Rapunzel
{
    partial class VideoQuiz
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
            this.play_button = new System.Windows.Forms.Button();
            this.speaker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play_button
            // 
            this.play_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.play_button.BackColor = System.Drawing.Color.Transparent;
            this.play_button.BackgroundImage = global::Rapunzel.Properties.Resources.play_button;
            this.play_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_button.FlatAppearance.BorderSize = 0;
            this.play_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.play_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.ForeColor = System.Drawing.Color.White;
            this.play_button.Location = new System.Drawing.Point(1100, 550);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(150, 150);
            this.play_button.TabIndex = 0;
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Visible = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // speaker
            // 
            this.speaker.BackColor = System.Drawing.Color.Transparent;
            this.speaker.BackgroundImage = global::Rapunzel.Properties.Resources.speaker;
            this.speaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.speaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speaker.FlatAppearance.BorderSize = 0;
            this.speaker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.speaker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.speaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speaker.Location = new System.Drawing.Point(100, 50);
            this.speaker.Name = "speaker";
            this.speaker.Size = new System.Drawing.Size(200, 200);
            this.speaker.TabIndex = 0;
            this.speaker.UseVisualStyleBackColor = true;
            this.speaker.Click += new System.EventHandler(this.speaker_Click);
            // 
            // VideoQuiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.speaker);
            this.Controls.Add(this.play_button);
            this.Name = "VideoQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoQuiz";
            this.Load += new System.EventHandler(this.VideoQuiz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button speaker;
    }
}