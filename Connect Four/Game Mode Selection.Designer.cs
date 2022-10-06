namespace Connect_Four
{
    partial class Game_Mode_Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Mode_Selection));
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.TwoPlayerButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.OnePlayerButton = new System.Windows.Forms.Button();
            this.GameModeLabel = new System.Windows.Forms.Label();
            this.RedButton = new System.Windows.Forms.Button();
            this.OrangeButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.AquaButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.PinkButton = new System.Windows.Forms.Button();
            this.WhiteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Player2RadioButton = new System.Windows.Forms.RadioButton();
            this.Player1RadioButton = new System.Windows.Forms.RadioButton();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavigationPanel.BackgroundImage")));
            this.NavigationPanel.Controls.Add(this.TwoPlayerButton);
            this.NavigationPanel.Controls.Add(this.BackButton);
            this.NavigationPanel.Controls.Add(this.OnePlayerButton);
            this.NavigationPanel.Location = new System.Drawing.Point(1062, 12);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(206, 695);
            this.NavigationPanel.TabIndex = 5;
            // 
            // TwoPlayerButton
            // 
            this.TwoPlayerButton.BackColor = System.Drawing.Color.Transparent;
            this.TwoPlayerButton.FlatAppearance.BorderSize = 0;
            this.TwoPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoPlayerButton.Font = new System.Drawing.Font("Impact", 22F);
            this.TwoPlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TwoPlayerButton.Image = ((System.Drawing.Image)(resources.GetObject("TwoPlayerButton.Image")));
            this.TwoPlayerButton.Location = new System.Drawing.Point(3, 590);
            this.TwoPlayerButton.Name = "TwoPlayerButton";
            this.TwoPlayerButton.Size = new System.Drawing.Size(200, 50);
            this.TwoPlayerButton.TabIndex = 8;
            this.TwoPlayerButton.Text = "TWO PLAYER";
            this.TwoPlayerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TwoPlayerButton.UseVisualStyleBackColor = false;
            this.TwoPlayerButton.Click += new System.EventHandler(this.TwoPlayerSelected);
            this.TwoPlayerButton.MouseEnter += new System.EventHandler(this.InvertTwoPlayerButton);
            this.TwoPlayerButton.MouseLeave += new System.EventHandler(this.InvertTwoPlayerButton);
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
            // OnePlayerButton
            // 
            this.OnePlayerButton.BackColor = System.Drawing.Color.Transparent;
            this.OnePlayerButton.FlatAppearance.BorderSize = 0;
            this.OnePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnePlayerButton.Font = new System.Drawing.Font("Impact", 22F);
            this.OnePlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OnePlayerButton.Image = ((System.Drawing.Image)(resources.GetObject("OnePlayerButton.Image")));
            this.OnePlayerButton.Location = new System.Drawing.Point(3, 538);
            this.OnePlayerButton.Name = "OnePlayerButton";
            this.OnePlayerButton.Size = new System.Drawing.Size(200, 50);
            this.OnePlayerButton.TabIndex = 7;
            this.OnePlayerButton.Text = "ONE PLAYER";
            this.OnePlayerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OnePlayerButton.UseVisualStyleBackColor = false;
            this.OnePlayerButton.Click += new System.EventHandler(this.OnePlayerSelected);
            this.OnePlayerButton.MouseEnter += new System.EventHandler(this.InvertOnePlayerButton);
            this.OnePlayerButton.MouseLeave += new System.EventHandler(this.InvertOnePlayerButton);
            // 
            // GameModeLabel
            // 
            this.GameModeLabel.AutoSize = true;
            this.GameModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameModeLabel.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameModeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GameModeLabel.Location = new System.Drawing.Point(1, 12);
            this.GameModeLabel.Name = "GameModeLabel";
            this.GameModeLabel.Size = new System.Drawing.Size(449, 80);
            this.GameModeLabel.TabIndex = 6;
            this.GameModeLabel.Text = "GAME SELECTION";
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.Red;
            this.RedButton.Location = new System.Drawing.Point(15, 624);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(75, 75);
            this.RedButton.TabIndex = 10;
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.ColourSelect);
            // 
            // OrangeButton
            // 
            this.OrangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OrangeButton.Location = new System.Drawing.Point(96, 624);
            this.OrangeButton.Name = "OrangeButton";
            this.OrangeButton.Size = new System.Drawing.Size(75, 75);
            this.OrangeButton.TabIndex = 11;
            this.OrangeButton.UseVisualStyleBackColor = false;
            this.OrangeButton.Click += new System.EventHandler(this.ColourSelect);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton.Location = new System.Drawing.Point(177, 624);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(75, 75);
            this.YellowButton.TabIndex = 12;
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.Click += new System.EventHandler(this.ColourSelect);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.Lime;
            this.GreenButton.Location = new System.Drawing.Point(258, 624);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(75, 75);
            this.GreenButton.TabIndex = 13;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.ColourSelect);
            // 
            // AquaButton
            // 
            this.AquaButton.BackColor = System.Drawing.Color.Aqua;
            this.AquaButton.Location = new System.Drawing.Point(339, 624);
            this.AquaButton.Name = "AquaButton";
            this.AquaButton.Size = new System.Drawing.Size(75, 75);
            this.AquaButton.TabIndex = 14;
            this.AquaButton.UseVisualStyleBackColor = false;
            this.AquaButton.Click += new System.EventHandler(this.ColourSelect);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.Blue;
            this.BlueButton.Location = new System.Drawing.Point(420, 624);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(75, 75);
            this.BlueButton.TabIndex = 15;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.ColourSelect);
            // 
            // PinkButton
            // 
            this.PinkButton.BackColor = System.Drawing.Color.Fuchsia;
            this.PinkButton.Location = new System.Drawing.Point(501, 624);
            this.PinkButton.Name = "PinkButton";
            this.PinkButton.Size = new System.Drawing.Size(75, 75);
            this.PinkButton.TabIndex = 16;
            this.PinkButton.UseVisualStyleBackColor = false;
            this.PinkButton.Click += new System.EventHandler(this.ColourSelect);
            // 
            // WhiteButton
            // 
            this.WhiteButton.BackColor = System.Drawing.Color.White;
            this.WhiteButton.Location = new System.Drawing.Point(582, 624);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(75, 75);
            this.WhiteButton.TabIndex = 18;
            this.WhiteButton.UseVisualStyleBackColor = false;
            this.WhiteButton.Click += new System.EventHandler(this.ColourSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 80);
            this.label1.TabIndex = 19;
            this.label1.Text = "DISK COLOURS:";
            // 
            // Player2RadioButton
            // 
            this.Player2RadioButton.AutoSize = true;
            this.Player2RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.Player2RadioButton.Font = new System.Drawing.Font("Impact", 30F);
            this.Player2RadioButton.ForeColor = System.Drawing.Color.Blue;
            this.Player2RadioButton.Location = new System.Drawing.Point(18, 566);
            this.Player2RadioButton.Name = "Player2RadioButton";
            this.Player2RadioButton.Size = new System.Drawing.Size(178, 52);
            this.Player2RadioButton.TabIndex = 20;
            this.Player2RadioButton.TabStop = true;
            this.Player2RadioButton.Text = "PLAYER 2";
            this.Player2RadioButton.UseVisualStyleBackColor = false;
            // 
            // Player1RadioButton
            // 
            this.Player1RadioButton.AutoSize = true;
            this.Player1RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.Player1RadioButton.Font = new System.Drawing.Font("Impact", 30F);
            this.Player1RadioButton.ForeColor = System.Drawing.Color.Red;
            this.Player1RadioButton.Location = new System.Drawing.Point(18, 508);
            this.Player1RadioButton.Name = "Player1RadioButton";
            this.Player1RadioButton.Size = new System.Drawing.Size(173, 52);
            this.Player1RadioButton.TabIndex = 21;
            this.Player1RadioButton.TabStop = true;
            this.Player1RadioButton.Text = "PLAYER 1";
            this.Player1RadioButton.UseVisualStyleBackColor = false;
            // 
            // Game_Mode_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Connect_Four.Properties.Resources.MenuBackground;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Player1RadioButton);
            this.Controls.Add(this.Player2RadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WhiteButton);
            this.Controls.Add(this.PinkButton);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.AquaButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.OrangeButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.GameModeLabel);
            this.Controls.Add(this.NavigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game_Mode_Selection";
            this.Text = "Game_Mode_Selection";
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label GameModeLabel;
        private System.Windows.Forms.Button OnePlayerButton;
        private System.Windows.Forms.Button TwoPlayerButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button OrangeButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button AquaButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button PinkButton;
        private System.Windows.Forms.Button WhiteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Player2RadioButton;
        private System.Windows.Forms.RadioButton Player1RadioButton;
    }
}