namespace MagazinOnlineUI
{
    partial class ProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPage));
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.LogoButton = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ProductDescription = new System.Windows.Forms.RichTextBox();
            this.PageDevider = new System.Windows.Forms.Label();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.OfferPriceBox = new System.Windows.Forms.TextBox();
            this.OfferLabel = new System.Windows.Forms.Label();
            this.OfferButton = new System.Windows.Forms.Button();
            this.ronLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductGenre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductSeller = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductAuthor = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.ProductPrice = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ProductCover = new System.Windows.Forms.PictureBox();
            this.ProductTitle = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.Label();
            this.NavigationPanel.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCover)).BeginInit();
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
            this.NavigationPanel.Size = new System.Drawing.Size(1085, 60);
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
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(477, 234);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(120, 24);
            this.DescriptionLabel.TabIndex = 24;
            this.DescriptionLabel.Text = "Description:";
            // 
            // ProductDescription
            // 
            this.ProductDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.ProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDescription.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDescription.Location = new System.Drawing.Point(482, 265);
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ProductDescription.Size = new System.Drawing.Size(451, 33);
            this.ProductDescription.TabIndex = 25;
            this.ProductDescription.Text = resources.GetString("ProductDescription.Text");
            // 
            // PageDevider
            // 
            this.PageDevider.AutoSize = true;
            this.PageDevider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PageDevider.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDevider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.PageDevider.Location = new System.Drawing.Point(471, 67);
            this.PageDevider.Name = "PageDevider";
            this.PageDevider.Size = new System.Drawing.Size(512, 26);
            this.PageDevider.TabIndex = 22;
            this.PageDevider.Text = "__________________________________________________";
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.ProductId);
            this.ProductPanel.Controls.Add(this.OfferPriceBox);
            this.ProductPanel.Controls.Add(this.OfferLabel);
            this.ProductPanel.Controls.Add(this.OfferButton);
            this.ProductPanel.Controls.Add(this.ronLabel);
            this.ProductPanel.Controls.Add(this.label4);
            this.ProductPanel.Controls.Add(this.ProductGenre);
            this.ProductPanel.Controls.Add(this.label2);
            this.ProductPanel.Controls.Add(this.ProductSeller);
            this.ProductPanel.Controls.Add(this.label1);
            this.ProductPanel.Controls.Add(this.ProductAuthor);
            this.ProductPanel.Controls.Add(this.BackButton);
            this.ProductPanel.Controls.Add(this.BuyButton);
            this.ProductPanel.Controls.Add(this.ProductPrice);
            this.ProductPanel.Controls.Add(this.PriceLabel);
            this.ProductPanel.Controls.Add(this.PageDevider);
            this.ProductPanel.Controls.Add(this.ProductDescription);
            this.ProductPanel.Controls.Add(this.DescriptionLabel);
            this.ProductPanel.Controls.Add(this.ProductCover);
            this.ProductPanel.Controls.Add(this.ProductTitle);
            this.ProductPanel.Location = new System.Drawing.Point(61, 90);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(988, 548);
            this.ProductPanel.TabIndex = 23;
            // 
            // OfferPriceBox
            // 
            this.OfferPriceBox.Location = new System.Drawing.Point(596, 381);
            this.OfferPriceBox.Name = "OfferPriceBox";
            this.OfferPriceBox.Size = new System.Drawing.Size(107, 22);
            this.OfferPriceBox.TabIndex = 44;
            // 
            // OfferLabel
            // 
            this.OfferLabel.AutoSize = true;
            this.OfferLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OfferLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfferLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.OfferLabel.Location = new System.Drawing.Point(478, 382);
            this.OfferLabel.Name = "OfferLabel";
            this.OfferLabel.Size = new System.Drawing.Size(116, 24);
            this.OfferLabel.TabIndex = 43;
            this.OfferLabel.Text = "Offer Price:";
            // 
            // OfferButton
            // 
            this.OfferButton.BackColor = System.Drawing.Color.Indigo;
            this.OfferButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OfferButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.OfferButton.FlatAppearance.BorderSize = 0;
            this.OfferButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OfferButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfferButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.OfferButton.Location = new System.Drawing.Point(735, 368);
            this.OfferButton.Name = "OfferButton";
            this.OfferButton.Size = new System.Drawing.Size(91, 42);
            this.OfferButton.TabIndex = 42;
            this.OfferButton.Text = "Offer";
            this.OfferButton.UseVisualStyleBackColor = false;
            this.OfferButton.Click += new System.EventHandler(this.OfferButton_Click);
            // 
            // ronLabel
            // 
            this.ronLabel.AutoSize = true;
            this.ronLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ronLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ronLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.ronLabel.Location = new System.Drawing.Point(663, 329);
            this.ronLabel.Name = "ronLabel";
            this.ronLabel.Size = new System.Drawing.Size(41, 24);
            this.ronLabel.TabIndex = 41;
            this.ronLabel.Text = "ron";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(477, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Genre:";
            // 
            // ProductGenre
            // 
            this.ProductGenre.AutoSize = true;
            this.ProductGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductGenre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.ProductGenre.Location = new System.Drawing.Point(605, 151);
            this.ProductGenre.Name = "ProductGenre";
            this.ProductGenre.Size = new System.Drawing.Size(129, 24);
            this.ProductGenre.TabIndex = 40;
            this.ProductGenre.Text = "Genere Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(477, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Seller:";
            // 
            // ProductSeller
            // 
            this.ProductSeller.AutoSize = true;
            this.ProductSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductSeller.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.ProductSeller.Location = new System.Drawing.Point(605, 191);
            this.ProductSeller.Name = "ProductSeller";
            this.ProductSeller.Size = new System.Drawing.Size(119, 24);
            this.ProductSeller.TabIndex = 38;
            this.ProductSeller.Text = "Seller Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(476, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Author:";
            // 
            // ProductAuthor
            // 
            this.ProductAuthor.AutoSize = true;
            this.ProductAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductAuthor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.ProductAuthor.Location = new System.Drawing.Point(605, 112);
            this.ProductAuthor.Name = "ProductAuthor";
            this.ProductAuthor.Size = new System.Drawing.Size(130, 24);
            this.ProductAuthor.TabIndex = 36;
            this.ProductAuthor.Text = "Author Name";
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
            this.BackButton.Location = new System.Drawing.Point(21, 506);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(48, 32);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "🡰";
            this.BackButton.UseCompatibleTextRendering = true;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.Indigo;
            this.BuyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.BuyButton.FlatAppearance.BorderSize = 0;
            this.BuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuyButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.BuyButton.Location = new System.Drawing.Point(732, 318);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(93, 41);
            this.BuyButton.TabIndex = 34;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSize = true;
            this.ProductPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductPrice.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.ProductPrice.Location = new System.Drawing.Point(620, 329);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(45, 24);
            this.ProductPrice.TabIndex = 33;
            this.ProductPrice.Text = "0.00";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriceLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.PriceLabel.Location = new System.Drawing.Point(477, 329);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(142, 24);
            this.PriceLabel.TabIndex = 32;
            this.PriceLabel.Text = "Starting Price:";
            // 
            // ProductCover
            // 
            this.ProductCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCover.Location = new System.Drawing.Point(21, 26);
            this.ProductCover.Name = "ProductCover";
            this.ProductCover.Size = new System.Drawing.Size(372, 474);
            this.ProductCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductCover.TabIndex = 16;
            this.ProductCover.TabStop = false;
            // 
            // ProductTitle
            // 
            this.ProductTitle.AutoSize = true;
            this.ProductTitle.Font = new System.Drawing.Font("Onyx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.ProductTitle.Location = new System.Drawing.Point(468, 26);
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.Size = new System.Drawing.Size(224, 45);
            this.ProductTitle.TabIndex = 0;
            this.ProductTitle.Text = "P r o d u c t   T i t l e";
            // 
            // ProductId
            // 
            this.ProductId.AutoSize = true;
            this.ProductId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductId.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.ProductId.Location = new System.Drawing.Point(821, 26);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(35, 24);
            this.ProductId.TabIndex = 45;
            this.ProductId.Text = "ID";
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1085, 650);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.ProductPanel);
            this.Name = "ProductPage";
            this.ShowIcon = false;
            this.Text = "ProductPage";
            this.Load += new System.EventHandler(this.ProductPage_Load);
            this.NavigationPanel.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button LogoButton;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.RichTextBox ProductDescription;
        private System.Windows.Forms.Label PageDevider;
        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.PictureBox ProductCover;
        private System.Windows.Forms.Label ProductTitle;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Label ProductPrice;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductSeller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ProductGenre;
        private System.Windows.Forms.Label ronLabel;
        private System.Windows.Forms.TextBox OfferPriceBox;
        private System.Windows.Forms.Label OfferLabel;
        private System.Windows.Forms.Button OfferButton;
        private System.Windows.Forms.Label ProductId;
    }
}