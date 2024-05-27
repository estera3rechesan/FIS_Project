namespace MagazinOnlineUI
{
    partial class SignIn
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
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.LogoButton = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.SignAdminButton = new System.Windows.Forms.Button();
            this.SignSellerButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SignCustumerButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.NavigationPanel.SuspendLayout();
            this.SignInPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.NavigationPanel.Size = new System.Drawing.Size(1108, 60);
            this.NavigationPanel.TabIndex = 15;
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
            // SignUpButton
            // 
            this.SignUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignUpButton.BackColor = System.Drawing.Color.Salmon;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SignUpButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.SignUpButton.Location = new System.Drawing.Point(324, 495);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(462, 42);
            this.SignUpButton.TabIndex = 14;
            this.SignUpButton.Text = "Don\'t have an account? Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignInPanel
            // 
            this.SignInPanel.BackColor = System.Drawing.Color.Transparent;
            this.SignInPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SignInPanel.Controls.Add(this.SignAdminButton);
            this.SignInPanel.Controls.Add(this.SignSellerButton);
            this.SignInPanel.Controls.Add(this.textBox4);
            this.SignInPanel.Controls.Add(this.textBox2);
            this.SignInPanel.Controls.Add(this.SignCustumerButton);
            this.SignInPanel.Controls.Add(this.PasswordLabel);
            this.SignInPanel.Controls.Add(this.EmailLabel);
            this.SignInPanel.Controls.Add(this.SignUpLabel);
            this.SignInPanel.Location = new System.Drawing.Point(242, 103);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(630, 371);
            this.SignInPanel.TabIndex = 13;
            // 
            // SignAdminButton
            // 
            this.SignAdminButton.BackColor = System.Drawing.Color.Indigo;
            this.SignAdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignAdminButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.SignAdminButton.FlatAppearance.BorderSize = 0;
            this.SignAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignAdminButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignAdminButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.SignAdminButton.Location = new System.Drawing.Point(411, 282);
            this.SignAdminButton.Name = "SignAdminButton";
            this.SignAdminButton.Size = new System.Drawing.Size(140, 66);
            this.SignAdminButton.TabIndex = 11;
            this.SignAdminButton.Text = "Sign In as Admin";
            this.SignAdminButton.UseVisualStyleBackColor = false;
            this.SignAdminButton.Click += new System.EventHandler(this.SignAdminButton_Click);
            // 
            // SignSellerButton
            // 
            this.SignSellerButton.BackColor = System.Drawing.Color.Indigo;
            this.SignSellerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignSellerButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.SignSellerButton.FlatAppearance.BorderSize = 0;
            this.SignSellerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignSellerButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignSellerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.SignSellerButton.Location = new System.Drawing.Point(245, 282);
            this.SignSellerButton.Name = "SignSellerButton";
            this.SignSellerButton.Size = new System.Drawing.Size(140, 66);
            this.SignSellerButton.TabIndex = 10;
            this.SignSellerButton.Text = "Sign In as Seller";
            this.SignSellerButton.UseVisualStyleBackColor = false;
            this.SignSellerButton.Click += new System.EventHandler(this.SignSellerButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(289, 147);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(253, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(289, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(253, 22);
            this.textBox2.TabIndex = 7;
            // 
            // SignCustumerButton
            // 
            this.SignCustumerButton.BackColor = System.Drawing.Color.Indigo;
            this.SignCustumerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignCustumerButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.SignCustumerButton.FlatAppearance.BorderSize = 0;
            this.SignCustumerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignCustumerButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignCustumerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.SignCustumerButton.Location = new System.Drawing.Point(70, 282);
            this.SignCustumerButton.Name = "SignCustumerButton";
            this.SignCustumerButton.Size = new System.Drawing.Size(140, 66);
            this.SignCustumerButton.TabIndex = 5;
            this.SignCustumerButton.Text = "Sign In as Customer";
            this.SignCustumerButton.UseVisualStyleBackColor = false;
            this.SignCustumerButton.Click += new System.EventHandler(this.SignCustumerButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.PasswordLabel.Location = new System.Drawing.Point(76, 190);
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
            this.EmailLabel.Location = new System.Drawing.Point(76, 147);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(72, 22);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "E-mail:";
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Onyx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.SignUpLabel.Location = new System.Drawing.Point(249, 17);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(110, 41);
            this.SignUpLabel.TabIndex = 0;
            this.SignUpLabel.Text = "S i g n   I n";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1108, 548);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.SignInPanel);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "SignIn";
            this.ShowIcon = false;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.NavigationPanel.ResumeLayout(false);
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button LogoButton;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Panel SignInPanel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SignCustumerButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button SignAdminButton;
        private System.Windows.Forms.Button SignSellerButton;
    }
}