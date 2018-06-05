namespace Rapunzel {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.play_story_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play_story_button
            // 
            this.play_story_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.play_story_button.BackColor = System.Drawing.Color.Transparent;
            this.play_story_button.BackgroundImage = global::Rapunzel.Properties.Resources.tile;
            this.play_story_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play_story_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_story_button.FlatAppearance.BorderSize = 0;
            this.play_story_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.play_story_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play_story_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_story_button.Font = new System.Drawing.Font("Monotype Corsiva", 20.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_story_button.ForeColor = System.Drawing.Color.White;
            this.play_story_button.Location = new System.Drawing.Point(500, 500);
            this.play_story_button.Name = "play_story_button";
            this.play_story_button.Size = new System.Drawing.Size(300, 100);
            this.play_story_button.TabIndex = 1;
            this.play_story_button.Text = "Play";
            this.play_story_button.UseVisualStyleBackColor = false;
            this.play_story_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.play_story_button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button play_story_button;
    }
}

