namespace Connect_Four
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.InstructionsButton = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EscapeLabel = new System.Windows.Forms.Label();
            this.CurrentPlayerLabel = new System.Windows.Forms.Label();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavigationPanel.BackgroundImage")));
            this.NavigationPanel.Controls.Add(this.ResumeButton);
            this.NavigationPanel.Controls.Add(this.InstructionsButton);
            this.NavigationPanel.Controls.Add(this.MainMenuButton);
            this.NavigationPanel.Controls.Add(this.ExitButton);
            this.NavigationPanel.Enabled = false;
            this.NavigationPanel.Location = new System.Drawing.Point(1062, 12);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(206, 695);
            this.NavigationPanel.TabIndex = 5;
            this.NavigationPanel.Visible = false;
            // 
            // ResumeButton
            // 
            this.ResumeButton.BackColor = System.Drawing.Color.Transparent;
            this.ResumeButton.FlatAppearance.BorderSize = 0;
            this.ResumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResumeButton.Font = new System.Drawing.Font("Impact", 22F);
            this.ResumeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResumeButton.Image = ((System.Drawing.Image)(resources.GetObject("ResumeButton.Image")));
            this.ResumeButton.Location = new System.Drawing.Point(3, 486);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(200, 50);
            this.ResumeButton.TabIndex = 5;
            this.ResumeButton.Text = "RESUME";
            this.ResumeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResumeButton.UseVisualStyleBackColor = false;
            this.ResumeButton.Click += new System.EventHandler(this.ClosePause);
            this.ResumeButton.MouseEnter += new System.EventHandler(this.InvertResume);
            this.ResumeButton.MouseLeave += new System.EventHandler(this.InvertResume);
            // 
            // InstructionsButton
            // 
            this.InstructionsButton.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsButton.FlatAppearance.BorderSize = 0;
            this.InstructionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstructionsButton.Font = new System.Drawing.Font("Impact", 22F);
            this.InstructionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InstructionsButton.Image = ((System.Drawing.Image)(resources.GetObject("InstructionsButton.Image")));
            this.InstructionsButton.Location = new System.Drawing.Point(3, 538);
            this.InstructionsButton.Name = "InstructionsButton";
            this.InstructionsButton.Size = new System.Drawing.Size(200, 50);
            this.InstructionsButton.TabIndex = 4;
            this.InstructionsButton.Text = "INSTRUCTIONS";
            this.InstructionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstructionsButton.UseVisualStyleBackColor = false;
            this.InstructionsButton.Click += new System.EventHandler(this.OpenInstructions);
            this.InstructionsButton.MouseEnter += new System.EventHandler(this.InvertInstructions);
            this.InstructionsButton.MouseLeave += new System.EventHandler(this.InvertInstructions);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuButton.FlatAppearance.BorderSize = 0;
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButton.Font = new System.Drawing.Font("Impact", 22F);
            this.MainMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MainMenuButton.Image")));
            this.MainMenuButton.Location = new System.Drawing.Point(3, 590);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(200, 50);
            this.MainMenuButton.TabIndex = 3;
            this.MainMenuButton.Text = "MAIN MENU";
            this.MainMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.OpenMainMenu);
            this.MainMenuButton.MouseEnter += new System.EventHandler(this.InvertMainMenu);
            this.MainMenuButton.MouseLeave += new System.EventHandler(this.InvertMainMenu);
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
            // EscapeLabel
            // 
            this.EscapeLabel.AutoSize = true;
            this.EscapeLabel.BackColor = System.Drawing.Color.Transparent;
            this.EscapeLabel.Font = new System.Drawing.Font("Impact", 22F);
            this.EscapeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EscapeLabel.Location = new System.Drawing.Point(12, 12);
            this.EscapeLabel.Name = "EscapeLabel";
            this.EscapeLabel.Size = new System.Drawing.Size(62, 37);
            this.EscapeLabel.TabIndex = 6;
            this.EscapeLabel.Text = "ESC";
            // 
            // CurrentPlayerLabel
            // 
            this.CurrentPlayerLabel.AutoSize = true;
            this.CurrentPlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentPlayerLabel.Font = new System.Drawing.Font("Impact", 22F);
            this.CurrentPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CurrentPlayerLabel.Location = new System.Drawing.Point(12, 674);
            this.CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            this.CurrentPlayerLabel.Size = new System.Drawing.Size(217, 37);
            this.CurrentPlayerLabel.TabIndex = 7;
            this.CurrentPlayerLabel.Text = "CURRENT PLAYER:";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Connect_Four.Properties.Resources.GameBackground;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.CurrentPlayerLabel);
            this.Controls.Add(this.EscapeLabel);
            this.Controls.Add(this.NavigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "OriginalGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TogglePause);
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button InstructionsButton;
        private System.Windows.Forms.Label EscapeLabel;
        private System.Windows.Forms.Label CurrentPlayerLabel;
    }
}