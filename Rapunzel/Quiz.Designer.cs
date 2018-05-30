namespace Rapunzel
{
    partial class Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.speaker = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.answer1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.speaker.Location = new System.Drawing.Point(550, 50);
            this.speaker.Name = "speaker";
            this.speaker.Size = new System.Drawing.Size(200, 200);
            this.speaker.TabIndex = 0;
            this.speaker.UseVisualStyleBackColor = true;
            this.speaker.Click += new System.EventHandler(this.speaker_Click);
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
            // answer1
            // 
            this.answer1.BackColor = System.Drawing.Color.Transparent;
            this.answer1.BackgroundImage = global::Rapunzel.Properties.Resources.speaker;
            this.answer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer1.FlatAppearance.BorderSize = 0;
            this.answer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answer1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer1.Location = new System.Drawing.Point(200, 300);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(250, 250);
            this.answer1.TabIndex = 1;
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.Click += new System.EventHandler(this.answer_Click);
            // 
            // answer2
            // 
            this.answer2.BackColor = System.Drawing.Color.Transparent;
            this.answer2.BackgroundImage = global::Rapunzel.Properties.Resources.speaker;
            this.answer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer2.FlatAppearance.BorderSize = 0;
            this.answer2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answer2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer2.Location = new System.Drawing.Point(520, 300);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(250, 250);
            this.answer2.TabIndex = 2;
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.Click += new System.EventHandler(this.answer_Click);
            // 
            // answer3
            // 
            this.answer3.BackColor = System.Drawing.Color.Transparent;
            this.answer3.BackgroundImage = global::Rapunzel.Properties.Resources.speaker;
            this.answer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answer3.FlatAppearance.BorderSize = 0;
            this.answer3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answer3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer3.Location = new System.Drawing.Point(840, 300);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(250, 250);
            this.answer3.TabIndex = 3;
            this.answer3.UseVisualStyleBackColor = true;
            this.answer3.Click += new System.EventHandler(this.answer_Click);
            // 
            // Quiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.speaker);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button speaker;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer3;
    }
}