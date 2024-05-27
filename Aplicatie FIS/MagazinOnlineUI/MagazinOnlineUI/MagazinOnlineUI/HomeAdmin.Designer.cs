namespace MagazinOnlineUI
{
    partial class HomeAdmin
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
            this.RequestsPanel = new System.Windows.Forms.Panel();
            this.AllowedGridView = new System.Windows.Forms.DataGridView();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xSellerGridView = new System.Windows.Forms.DataGridView();
            this.DenyButton = new System.Windows.Forms.Button();
            this.AllowButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NavigationPanel.SuspendLayout();
            this.RequestsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllowedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSellerGridView)).BeginInit();
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
            this.NavigationPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(1851, 75);
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
            this.LogoButton.Location = new System.Drawing.Point(14, 16);
            this.LogoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoButton.Name = "LogoButton";
            this.LogoButton.Size = new System.Drawing.Size(84, 40);
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
            this.SupportButton.Location = new System.Drawing.Point(183, 16);
            this.SupportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(110, 40);
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
            this.AboutButton.Location = new System.Drawing.Point(92, 16);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(84, 40);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click_1);
            // 
            // RequestsPanel
            // 
            this.RequestsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RequestsPanel.Controls.Add(this.AllowedGridView);
            this.RequestsPanel.Controls.Add(this.AdminLabel);
            this.RequestsPanel.Controls.Add(this.label1);
            this.RequestsPanel.Controls.Add(this.xSellerGridView);
            this.RequestsPanel.Controls.Add(this.DenyButton);
            this.RequestsPanel.Controls.Add(this.AllowButton);
            this.RequestsPanel.Controls.Add(this.SearchLabel);
            this.RequestsPanel.Controls.Add(this.SearchBox);
            this.RequestsPanel.Controls.Add(this.SearchButton);
            this.RequestsPanel.Location = new System.Drawing.Point(46, 182);
            this.RequestsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RequestsPanel.Name = "RequestsPanel";
            this.RequestsPanel.Size = new System.Drawing.Size(1736, 880);
            this.RequestsPanel.TabIndex = 28;
            // 
            // AllowedGridView
            // 
            this.AllowedGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllowedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllowedGridView.Location = new System.Drawing.Point(872, 155);
            this.AllowedGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllowedGridView.Name = "AllowedGridView";
            this.AllowedGridView.RowHeadersWidth = 51;
            this.AllowedGridView.RowTemplate.Height = 24;
            this.AllowedGridView.Size = new System.Drawing.Size(792, 645);
            this.AllowedGridView.TabIndex = 32;
            this.AllowedGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("Onyx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.AdminLabel.Location = new System.Drawing.Point(69, 2);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(276, 49);
            this.AdminLabel.TabIndex = 30;
            this.AdminLabel.Text = "S e l l e r   R e q u e s t s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(72, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "_________________________";
            // 
            // xSellerGridView
            // 
            this.xSellerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.xSellerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xSellerGridView.Location = new System.Drawing.Point(76, 155);
            this.xSellerGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xSellerGridView.Name = "xSellerGridView";
            this.xSellerGridView.RowHeadersWidth = 51;
            this.xSellerGridView.RowTemplate.Height = 24;
            this.xSellerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.xSellerGridView.Size = new System.Drawing.Size(752, 645);
            this.xSellerGridView.TabIndex = 15;
            this.xSellerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.DenyButton.Location = new System.Drawing.Point(1474, 80);
            this.DenyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DenyButton.Name = "DenyButton";
            this.DenyButton.Size = new System.Drawing.Size(190, 56);
            this.DenyButton.TabIndex = 14;
            this.DenyButton.Text = "Deny Seller";
            this.DenyButton.UseVisualStyleBackColor = false;
            this.DenyButton.Click += new System.EventHandler(this.DenyButton_Click);
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
            this.AllowButton.Location = new System.Drawing.Point(638, 80);
            this.AllowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllowButton.Name = "AllowButton";
            this.AllowButton.Size = new System.Drawing.Size(190, 56);
            this.AllowButton.TabIndex = 13;
            this.AllowButton.Text = "Allow Seller";
            this.AllowButton.UseVisualStyleBackColor = false;
            this.AllowButton.Click += new System.EventHandler(this.AllowButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.SearchLabel.Location = new System.Drawing.Point(72, 95);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(134, 25);
            this.SearchLabel.TabIndex = 12;
            this.SearchLabel.Text = "Search User:";
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchBox.Location = new System.Drawing.Point(205, 98);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(284, 26);
            this.SearchBox.TabIndex = 11;
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
            this.SearchButton.Location = new System.Drawing.Point(507, 91);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(54, 40);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "⌕";
            this.SearchButton.UseCompatibleTextRendering = true;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1851, 1078);
            this.Controls.Add(this.RequestsPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeAdmin";
            this.ShowIcon = false;
            this.Text = "HomeAdmin";
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            this.NavigationPanel.ResumeLayout(false);
            this.RequestsPanel.ResumeLayout(false);
            this.RequestsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllowedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSellerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button LogoButton;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel RequestsPanel;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView xSellerGridView;
        private System.Windows.Forms.Button DenyButton;
        private System.Windows.Forms.Button AllowButton;
        private System.Windows.Forms.DataGridView AllowedGridView;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
    }
}