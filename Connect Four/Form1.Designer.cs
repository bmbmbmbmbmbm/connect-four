namespace Connect_Four
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.PlayButton = new System.Windows.Forms.Button();
            this.InstructionsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Impact", 22F);
            this.PlayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
            this.PlayButton.Location = new System.Drawing.Point(3, 538);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(200, 50);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.OpenGame);
            this.PlayButton.MouseEnter += new System.EventHandler(this.InvertPlay);
            this.PlayButton.MouseLeave += new System.EventHandler(this.InvertPlay);
            // 
            // InstructionsButton
            // 
            this.InstructionsButton.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsButton.FlatAppearance.BorderSize = 0;
            this.InstructionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstructionsButton.Font = new System.Drawing.Font("Impact", 22F);
            this.InstructionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InstructionsButton.Image = ((System.Drawing.Image)(resources.GetObject("InstructionsButton.Image")));
            this.InstructionsButton.Location = new System.Drawing.Point(3, 590);
            this.InstructionsButton.Name = "InstructionsButton";
            this.InstructionsButton.Size = new System.Drawing.Size(200, 50);
            this.InstructionsButton.TabIndex = 1;
            this.InstructionsButton.Text = "INSTRUCTIONS";
            this.InstructionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstructionsButton.UseVisualStyleBackColor = false;
            this.InstructionsButton.Click += new System.EventHandler(this.OpenInstructions);
            this.InstructionsButton.MouseEnter += new System.EventHandler(this.InvertInstructions);
            this.InstructionsButton.MouseLeave += new System.EventHandler(this.InvertInstructions);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Impact", 22F);
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(3, 642);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(200, 50);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.CloseProgram);
            this.ExitButton.MouseEnter += new System.EventHandler(this.InvertExit);
            this.ExitButton.MouseLeave += new System.EventHandler(this.InvertExit);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavigationPanel.BackgroundImage")));
            this.NavigationPanel.Controls.Add(this.PlayButton);
            this.NavigationPanel.Controls.Add(this.ExitButton);
            this.NavigationPanel.Controls.Add(this.InstructionsButton);
            this.NavigationPanel.Location = new System.Drawing.Point(1062, 12);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(206, 695);
            this.NavigationPanel.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Connect_Four.Properties.Resources.MenuBackground;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.NavigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button InstructionsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel NavigationPanel;
    }
}

