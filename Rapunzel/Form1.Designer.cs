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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit_button = new System.Windows.Forms.Button();
            this.play_story_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.BackgroundImage = global::Rapunzel.Properties.Resources.tile;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Monotype Corsiva", 20.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(500, 550);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(300, 100);
            this.exit_button.TabIndex = 0;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // play_story_button
            // 
            this.play_story_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.play_story_button.BackColor = System.Drawing.Color.Transparent;
            this.play_story_button.BackgroundImage = global::Rapunzel.Properties.Resources.tile;
            this.play_story_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play_story_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_story_button.FlatAppearance.BorderSize = 0;
            this.play_story_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play_story_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.play_story_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_story_button.Font = new System.Drawing.Font("Monotype Corsiva", 20.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_story_button.ForeColor = System.Drawing.Color.White;
            this.play_story_button.Location = new System.Drawing.Point(500, 400);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.play_story_button);
            this.Controls.Add(this.exit_button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button play_story_button;
    }
}

