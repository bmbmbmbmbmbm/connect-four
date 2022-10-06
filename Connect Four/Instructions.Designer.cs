namespace Connect_Four
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.GameModeLabel = new System.Windows.Forms.Label();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsLabel.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InstructionsLabel.Location = new System.Drawing.Point(19, 92);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(94, 39);
            this.InstructionsLabel.TabIndex = 0;
            this.InstructionsLabel.Text = "label1";
            // 
            // GameModeLabel
            // 
            this.GameModeLabel.AutoSize = true;
            this.GameModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameModeLabel.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameModeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GameModeLabel.Location = new System.Drawing.Point(12, 12);
            this.GameModeLabel.Name = "GameModeLabel";
            this.GameModeLabel.Size = new System.Drawing.Size(190, 80);
            this.GameModeLabel.TabIndex = 1;
            this.GameModeLabel.Text = "label1";
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavigationPanel.BackgroundImage")));
            this.NavigationPanel.Controls.Add(this.BackButton);
            this.NavigationPanel.Location = new System.Drawing.Point(1062, 12);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(206, 695);
            this.NavigationPanel.TabIndex = 4;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Impact", 22F);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(3, 642);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(200, 50);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "BACK";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.PreviousMenu);
            this.BackButton.MouseEnter += new System.EventHandler(this.InvertBackButton);
            this.BackButton.MouseLeave += new System.EventHandler(this.InvertBackButton);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Connect_Four.Properties.Resources.MenuBackground;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.GameModeLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label GameModeLabel;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button BackButton;
    }
}