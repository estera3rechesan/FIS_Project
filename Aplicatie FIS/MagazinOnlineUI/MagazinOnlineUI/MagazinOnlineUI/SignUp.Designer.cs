namespace MagazinOnlineUI
{
    partial class SignUp
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
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.SellerButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmationTextBox = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.ConfirmationLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.LogoButton = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SignUpPanel.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Onyx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.SignUpLabel.Location = new System.Drawing.Point(245, 15);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(116, 41);
            this.SignUpLabel.TabIndex = 0;
            this.SignUpLabel.Text = "S i g n   U p";
            this.SignUpLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BackColor = System.Drawing.Color.Transparent;
            this.SignUpPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SignUpPanel.Controls.Add(this.SellerButton);
            this.SignUpPanel.Controls.Add(this.EmailTextBox);
            this.SignUpPanel.Controls.Add(this.PasswordTextBox);
            this.SignUpPanel.Controls.Add(this.ConfirmationTextBox);
            this.SignUpPanel.Controls.Add(this.SignUpButton);
            this.SignUpPanel.Controls.Add(this.ConfirmationLabel);
            this.SignUpPanel.Controls.Add(this.PasswordLabel);
            this.SignUpPanel.Controls.Add(this.EmailLabel);
            this.SignUpPanel.Controls.Add(this.SignUpLabel);
            this.SignUpPanel.Location = new System.Drawing.Point(227, 78);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(630, 371);
            this.SignUpPanel.TabIndex = 1;
            this.SignUpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SignUpPannel_Paint);
            // 
            // SellerButton
            // 
            this.SellerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SellerButton.BackColor = System.Drawing.Color.Indigo;
            this.SellerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellerButton.FlatAppearance.BorderSize = 0;
            this.SellerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SellerButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.SellerButton.Location = new System.Drawing.Point(216, 287);
            this.SellerButton.Name = "SellerButton";
            this.SellerButton.Size = new System.Drawing.Size(326, 45);
            this.SellerButton.TabIndex = 10;
            this.SellerButton.Text = "Sign Up as a Seller Account";
            this.SellerButton.UseVisualStyleBackColor = false;
            this.SellerButton.Click += new System.EventHandler(this.SellerButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(289, 102);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(253, 22);
            this.EmailTextBox.TabIndex = 8;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(289, 166);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.Size = new System.Drawing.Size(253, 22);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // ConfirmationTextBox
            // 
            this.ConfirmationTextBox.Location = new System.Drawing.Point(289, 235);
            this.ConfirmationTextBox.Name = "ConfirmationTextBox";
            this.ConfirmationTextBox.PasswordChar = '●';
            this.ConfirmationTextBox.Size = new System.Drawing.Size(253, 22);
            this.ConfirmationTextBox.TabIndex = 6;
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Indigo;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUpButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.SignUpButton.Location = new System.Drawing.Point(80, 287);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(110, 45);
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click_1);
            // 
            // ConfirmationLabel
            // 
            this.ConfirmationLabel.AutoSize = true;
            this.ConfirmationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmationLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.ConfirmationLabel.Location = new System.Drawing.Point(76, 235);
            this.ConfirmationLabel.Name = "ConfirmationLabel";
            this.ConfirmationLabel.Size = new System.Drawing.Size(201, 22);
            this.ConfirmationLabel.TabIndex = 4;
            this.ConfirmationLabel.Text = "Password confirmation:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.PasswordLabel.Location = new System.Drawing.Point(76, 166);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(91, 22);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmailLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.EmailLabel.Location = new System.Drawing.Point(76, 102);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(72, 22);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "E-mail:";
            // 
            // SignInButton
            // 
            this.SignInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignInButton.BackColor = System.Drawing.Color.Salmon;
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SignInButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.SignInButton.Location = new System.Drawing.Point(309, 470);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(462, 42);
            this.SignInButton.TabIndex = 11;
            this.SignInButton.Text = "Already have an account? Sign in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.Indigo;
            this.NavigationPanel.Controls.Add(this.LogoButton);
            this.NavigationPanel.Controls.Add(this.SupportButton);
            this.NavigationPanel.Controls.Add(this.AboutButton);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(1062, 60);
            this.NavigationPanel.TabIndex = 12;
            // 
            // LogoButton
            // 
            this.LogoButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoButton.FlatAppearance.BorderSize = 0;
            this.LogoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.LogoButton.Location = new System.Drawing.Point(12, 13);
            this.LogoButton.Name = "LogoButton";
            this.LogoButton.Size = new System.Drawing.Size(75, 32);
            this.LogoButton.TabIndex = 2;
            this.LogoButton.Text = "📖";
            this.LogoButton.UseVisualStyleBackColor = false;
            this.LogoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SupportButton
            // 
            this.SupportButton.BackColor = System.Drawing.Color.Transparent;
            this.SupportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupportButton.FlatAppearance.BorderSize = 0;
            this.SupportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupportButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.SupportButton.Location = new System.Drawing.Point(163, 13);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(98, 32);
            this.SupportButton.TabIndex = 1;
            this.SupportButton.Text = "Support";
            this.SupportButton.UseVisualStyleBackColor = false;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click_1);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.AboutButton.Location = new System.Drawing.Point(82, 13);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 32);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click_1);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1062, 936);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.SignUpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.Label ConfirmationLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmationTextBox;
        private System.Windows.Forms.Button SellerButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button LogoButton;
    }
}

