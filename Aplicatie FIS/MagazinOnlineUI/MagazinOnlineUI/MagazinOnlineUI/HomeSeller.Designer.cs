namespace MagazinOnlineUI
{
    partial class HomeSeller
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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LogoButton = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.OffersPanel = new System.Windows.Forms.Panel();
            this.DenyFixed = new System.Windows.Forms.Button();
            this.AllowFixed = new System.Windows.Forms.Button();
            this.FixedPriceGrid = new System.Windows.Forms.DataGridView();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DenyButton = new System.Windows.Forms.Button();
            this.OffersGridView = new System.Windows.Forms.DataGridView();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.SellerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.AllowButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NavigationPanel.SuspendLayout();
            this.OffersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FixedPriceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.Indigo;
            this.NavigationPanel.Controls.Add(this.RefreshButton);
            this.NavigationPanel.Controls.Add(this.LogoButton);
            this.NavigationPanel.Controls.Add(this.SupportButton);
            this.NavigationPanel.Controls.Add(this.AboutButton);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(1623, 60);
            this.NavigationPanel.TabIndex = 26;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RefreshButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.RefreshButton.Location = new System.Drawing.Point(1564, 13);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(48, 32);
            this.RefreshButton.TabIndex = 14;
            this.RefreshButton.Text = "↺";
            this.RefreshButton.UseCompatibleTextRendering = true;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
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
            // OffersPanel
            // 
            this.OffersPanel.Controls.Add(this.DenyFixed);
            this.OffersPanel.Controls.Add(this.AllowFixed);
            this.OffersPanel.Controls.Add(this.FixedPriceGrid);
            this.OffersPanel.Controls.Add(this.HistoryButton);
            this.OffersPanel.Controls.Add(this.label2);
            this.OffersPanel.Controls.Add(this.label3);
            this.OffersPanel.Controls.Add(this.DenyButton);
            this.OffersPanel.Controls.Add(this.OffersGridView);
            this.OffersPanel.Controls.Add(this.AddProductButton);
            this.OffersPanel.Controls.Add(this.SellerLabel);
            this.OffersPanel.Controls.Add(this.label1);
            this.OffersPanel.Controls.Add(this.ProductsGridView);
            this.OffersPanel.Controls.Add(this.AllowButton);
            this.OffersPanel.Controls.Add(this.SearchLabel);
            this.OffersPanel.Controls.Add(this.textBox1);
            this.OffersPanel.Controls.Add(this.SearchButton);
            this.OffersPanel.Location = new System.Drawing.Point(40, 128);
            this.OffersPanel.Name = "OffersPanel";
            this.OffersPanel.Size = new System.Drawing.Size(1543, 797);
            this.OffersPanel.TabIndex = 29;
            this.OffersPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OffersPanel_Paint);
            // 
            // DenyFixed
            // 
            this.DenyFixed.BackColor = System.Drawing.Color.Indigo;
            this.DenyFixed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DenyFixed.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.DenyFixed.FlatAppearance.BorderSize = 0;
            this.DenyFixed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DenyFixed.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenyFixed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.DenyFixed.Location = new System.Drawing.Point(244, 68);
            this.DenyFixed.Name = "DenyFixed";
            this.DenyFixed.Size = new System.Drawing.Size(169, 45);
            this.DenyFixed.TabIndex = 39;
            this.DenyFixed.Text = "Deny";
            this.DenyFixed.UseVisualStyleBackColor = false;
            this.DenyFixed.Click += new System.EventHandler(this.DenyFixed_Click);
            // 
            // AllowFixed
            // 
            this.AllowFixed.BackColor = System.Drawing.Color.Indigo;
            this.AllowFixed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllowFixed.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.AllowFixed.FlatAppearance.BorderSize = 0;
            this.AllowFixed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllowFixed.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllowFixed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.AllowFixed.Location = new System.Drawing.Point(69, 68);
            this.AllowFixed.Name = "AllowFixed";
            this.AllowFixed.Size = new System.Drawing.Size(169, 45);
            this.AllowFixed.TabIndex = 38;
            this.AllowFixed.Text = "Allow";
            this.AllowFixed.UseVisualStyleBackColor = false;
            this.AllowFixed.Click += new System.EventHandler(this.AllowFixed_Click);
            // 
            // FixedPriceGrid
            // 
            this.FixedPriceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FixedPriceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FixedPriceGrid.Location = new System.Drawing.Point(69, 124);
            this.FixedPriceGrid.Name = "FixedPriceGrid";
            this.FixedPriceGrid.RowHeadersWidth = 51;
            this.FixedPriceGrid.RowTemplate.Height = 24;
            this.FixedPriceGrid.Size = new System.Drawing.Size(668, 317);
            this.FixedPriceGrid.TabIndex = 37;
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.Indigo;
            this.HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.HistoryButton.FlatAppearance.BorderSize = 0;
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HistoryButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.HistoryButton.Location = new System.Drawing.Point(754, 65);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(169, 45);
            this.HistoryButton.TabIndex = 36;
            this.HistoryButton.Text = "Sales History";
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Onyx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(745, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 45);
            this.label2.TabIndex = 34;
            this.label2.Text = "P r o d u c t   O f f e r s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(749, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "_____________________";
            // 
            // DenyButton
            // 
            this.DenyButton.BackColor = System.Drawing.Color.Indigo;
            this.DenyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DenyButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.DenyButton.FlatAppearance.BorderSize = 0;
            this.DenyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DenyButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.DenyButton.Location = new System.Drawing.Point(1103, 65);
            this.DenyButton.Name = "DenyButton";
            this.DenyButton.Size = new System.Drawing.Size(169, 45);
            this.DenyButton.TabIndex = 14;
            this.DenyButton.Text = "Deny Offer";
            this.DenyButton.UseVisualStyleBackColor = false;
            this.DenyButton.Click += new System.EventHandler(this.DenyButton_Click);
            // 
            // OffersGridView
            // 
            this.OffersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OffersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OffersGridView.Location = new System.Drawing.Point(753, 124);
            this.OffersGridView.Name = "OffersGridView";
            this.OffersGridView.RowHeadersWidth = 51;
            this.OffersGridView.RowTemplate.Height = 24;
            this.OffersGridView.Size = new System.Drawing.Size(649, 317);
            this.OffersGridView.TabIndex = 33;
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.Indigo;
            this.AddProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddProductButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.AddProductButton.Location = new System.Drawing.Point(69, 540);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(169, 45);
            this.AddProductButton.TabIndex = 32;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // SellerLabel
            // 
            this.SellerLabel.AutoSize = true;
            this.SellerLabel.Font = new System.Drawing.Font("Onyx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.SellerLabel.Location = new System.Drawing.Point(61, 2);
            this.SellerLabel.Name = "SellerLabel";
            this.SellerLabel.Size = new System.Drawing.Size(152, 45);
            this.SellerLabel.TabIndex = 30;
            this.SellerLabel.Text = "P r o d u c t s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "_____________________";
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Location = new System.Drawing.Point(400, 460);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.RowHeadersWidth = 51;
            this.ProductsGridView.RowTemplate.Height = 24;
            this.ProductsGridView.Size = new System.Drawing.Size(1002, 313);
            this.ProductsGridView.TabIndex = 15;
            // 
            // AllowButton
            // 
            this.AllowButton.BackColor = System.Drawing.Color.Indigo;
            this.AllowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllowButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.AllowButton.FlatAppearance.BorderSize = 0;
            this.AllowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllowButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.AllowButton.Location = new System.Drawing.Point(928, 65);
            this.AllowButton.Name = "AllowButton";
            this.AllowButton.Size = new System.Drawing.Size(169, 45);
            this.AllowButton.TabIndex = 13;
            this.AllowButton.Text = "Allow Offer";
            this.AllowButton.UseVisualStyleBackColor = false;
            this.AllowButton.Click += new System.EventHandler(this.AllowButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.SearchLabel.Location = new System.Drawing.Point(65, 460);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(152, 24);
            this.SearchLabel.TabIndex = 12;
            this.SearchLabel.Text = "Search Product:";
            this.SearchLabel.Click += new System.EventHandler(this.SearchLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Location = new System.Drawing.Point(69, 490);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 24);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.SearchButton.Location = new System.Drawing.Point(328, 482);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(48, 37);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "⌕";
            this.SearchButton.UseCompatibleTextRendering = true;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HomeSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1623, 976);
            this.Controls.Add(this.OffersPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Name = "HomeSeller";
            this.ShowIcon = false;
            this.Text = "HomeSeller";
            this.Load += new System.EventHandler(this.HomeSeller_Load);
            this.NavigationPanel.ResumeLayout(false);
            this.OffersPanel.ResumeLayout(false);
            this.OffersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FixedPriceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button LogoButton;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel OffersPanel;
        private System.Windows.Forms.Label SellerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Button DenyButton;
        private System.Windows.Forms.Button AllowButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView OffersGridView;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView FixedPriceGrid;
        private System.Windows.Forms.Button DenyFixed;
        private System.Windows.Forms.Button AllowFixed;
    }
}