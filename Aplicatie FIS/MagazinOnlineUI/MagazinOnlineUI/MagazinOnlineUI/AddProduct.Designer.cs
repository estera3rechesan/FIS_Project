namespace MagazinOnlineUI
{
    partial class AddProduct
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
            this.AddProductPanel = new System.Windows.Forms.Panel();
            this.MinPriceLabel = new System.Windows.Forms.Label();
            this.MinPriceTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SellLabel = new System.Windows.Forms.Label();
            this.FixedButton = new System.Windows.Forms.Button();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.NegotiableButton = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.CoverTextBox = new System.Windows.Forms.TextBox();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AddProductLabel = new System.Windows.Forms.Label();
            this.NavigationPanel.SuspendLayout();
            this.AddProductPanel.SuspendLayout();
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
            this.NavigationPanel.Size = new System.Drawing.Size(1206, 60);
            this.NavigationPanel.TabIndex = 27;
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
            this.LogoButton.Click += new System.EventHandler(this.LogoButton_Click);
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
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
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
            // AddProductPanel
            // 
            this.AddProductPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddProductPanel.Controls.Add(this.MinPriceLabel);
            this.AddProductPanel.Controls.Add(this.MinPriceTextBox);
            this.AddProductPanel.Controls.Add(this.GenreLabel);
            this.AddProductPanel.Controls.Add(this.GenreTextBox);
            this.AddProductPanel.Controls.Add(this.BackButton);
            this.AddProductPanel.Controls.Add(this.SellLabel);
            this.AddProductPanel.Controls.Add(this.FixedButton);
            this.AddProductPanel.Controls.Add(this.DescriptionTextBox);
            this.AddProductPanel.Controls.Add(this.DescriptionLabel);
            this.AddProductPanel.Controls.Add(this.PriceTextBox);
            this.AddProductPanel.Controls.Add(this.PriceLabel);
            this.AddProductPanel.Controls.Add(this.NegotiableButton);
            this.AddProductPanel.Controls.Add(this.TitleTextBox);
            this.AddProductPanel.Controls.Add(this.AuthorTextBox);
            this.AddProductPanel.Controls.Add(this.CoverTextBox);
            this.AddProductPanel.Controls.Add(this.PictureLabel);
            this.AddProductPanel.Controls.Add(this.PasswordLabel);
            this.AddProductPanel.Controls.Add(this.TitleLabel);
            this.AddProductPanel.Controls.Add(this.AddProductLabel);
            this.AddProductPanel.Location = new System.Drawing.Point(153, 142);
            this.AddProductPanel.Name = "AddProductPanel";
            this.AddProductPanel.Size = new System.Drawing.Size(976, 464);
            this.AddProductPanel.TabIndex = 28;
            // 
            // MinPriceLabel
            // 
            this.MinPriceLabel.AutoSize = true;
            this.MinPriceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinPriceLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.MinPriceLabel.Location = new System.Drawing.Point(709, 401);
            this.MinPriceLabel.Name = "MinPriceLabel";
            this.MinPriceLabel.Size = new System.Drawing.Size(0, 22);
            this.MinPriceLabel.TabIndex = 21;
            this.MinPriceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MinPriceTextBox
            // 
            this.MinPriceTextBox.Location = new System.Drawing.Point(790, 424);
            this.MinPriceTextBox.Name = "MinPriceTextBox";
            this.MinPriceTextBox.Size = new System.Drawing.Size(78, 22);
            this.MinPriceTextBox.TabIndex = 20;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenreLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.GenreLabel.Location = new System.Drawing.Point(70, 317);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(63, 22);
            this.GenreLabel.TabIndex = 19;
            this.GenreLabel.Text = "Genre:";
            this.GenreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(161, 316);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(253, 22);
            this.GenreTextBox.TabIndex = 18;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BackButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.BackButton.Location = new System.Drawing.Point(80, 29);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(48, 32);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "🡰";
            this.BackButton.UseCompatibleTextRendering = true;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // SellLabel
            // 
            this.SellLabel.AutoSize = true;
            this.SellLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.SellLabel.Location = new System.Drawing.Point(399, 376);
            this.SellLabel.Name = "SellLabel";
            this.SellLabel.Size = new System.Drawing.Size(156, 22);
            this.SellLabel.TabIndex = 16;
            this.SellLabel.Text = "Sell Product with:";
            // 
            // FixedButton
            // 
            this.FixedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FixedButton.BackColor = System.Drawing.Color.Indigo;
            this.FixedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FixedButton.FlatAppearance.BorderSize = 0;
            this.FixedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FixedButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.FixedButton.Location = new System.Drawing.Point(270, 401);
            this.FixedButton.Name = "FixedButton";
            this.FixedButton.Size = new System.Drawing.Size(205, 45);
            this.FixedButton.TabIndex = 15;
            this.FixedButton.Text = "Fixed Price";
            this.FixedButton.UseVisualStyleBackColor = false;
            this.FixedButton.Click += new System.EventHandler(this.FixedButton_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(539, 225);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(357, 113);
            this.DescriptionTextBox.TabIndex = 14;
            this.DescriptionTextBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(535, 199);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(109, 22);
            this.DescriptionLabel.TabIndex = 13;
            this.DescriptionLabel.Text = "Description:";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(620, 139);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(78, 22);
            this.PriceTextBox.TabIndex = 12;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriceLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.PriceLabel.Location = new System.Drawing.Point(535, 139);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(58, 22);
            this.PriceLabel.TabIndex = 11;
            this.PriceLabel.Text = "Price:";
            // 
            // NegotiableButton
            // 
            this.NegotiableButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NegotiableButton.BackColor = System.Drawing.Color.Indigo;
            this.NegotiableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NegotiableButton.FlatAppearance.BorderSize = 0;
            this.NegotiableButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NegotiableButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegotiableButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.NegotiableButton.Location = new System.Drawing.Point(481, 401);
            this.NegotiableButton.Name = "NegotiableButton";
            this.NegotiableButton.Size = new System.Drawing.Size(205, 45);
            this.NegotiableButton.TabIndex = 10;
            this.NegotiableButton.Text = "Negotiable Price";
            this.NegotiableButton.UseVisualStyleBackColor = false;
            this.NegotiableButton.Click += new System.EventHandler(this.NegotiableButton_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(161, 137);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(253, 22);
            this.TitleTextBox.TabIndex = 8;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(159, 199);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(253, 22);
            this.AuthorTextBox.TabIndex = 7;
            // 
            // CoverTextBox
            // 
            this.CoverTextBox.Location = new System.Drawing.Point(161, 253);
            this.CoverTextBox.Name = "CoverTextBox";
            this.CoverTextBox.Size = new System.Drawing.Size(253, 22);
            this.CoverTextBox.TabIndex = 6;
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PictureLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.PictureLabel.Location = new System.Drawing.Point(74, 254);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(74, 22);
            this.PictureLabel.TabIndex = 4;
            this.PictureLabel.Text = "Picture:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.PasswordLabel.Location = new System.Drawing.Point(74, 198);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 22);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Author:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.TitleLabel.Location = new System.Drawing.Point(70, 139);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(53, 22);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title:";
            // 
            // AddProductLabel
            // 
            this.AddProductLabel.AutoSize = true;
            this.AddProductLabel.Font = new System.Drawing.Font("Onyx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.AddProductLabel.Location = new System.Drawing.Point(405, 20);
            this.AddProductLabel.Name = "AddProductLabel";
            this.AddProductLabel.Size = new System.Drawing.Size(178, 41);
            this.AddProductLabel.TabIndex = 0;
            this.AddProductLabel.Text = "A d d   P r o d u c t";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1206, 653);
            this.Controls.Add(this.AddProductPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Name = "AddProduct";
            this.ShowIcon = false;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.NavigationPanel.ResumeLayout(false);
            this.AddProductPanel.ResumeLayout(false);
            this.AddProductPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button LogoButton;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel AddProductPanel;
        private System.Windows.Forms.Button NegotiableButton;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox CoverTextBox;
        private System.Windows.Forms.Label PictureLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AddProductLabel;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button FixedButton;
        private System.Windows.Forms.Label SellLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label MinPriceLabel;
        private System.Windows.Forms.TextBox MinPriceTextBox;
    }
}