namespace MagazinOnlineUI
{
    partial class Offers
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
            this.OffersPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.OffersLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OffersGridView = new System.Windows.Forms.DataGridView();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.LogoButton = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.OffersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OffersGridView)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OffersPanel
            // 
            this.OffersPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OffersPanel.Controls.Add(this.BackButton);
            this.OffersPanel.Controls.Add(this.OffersLabel);
            this.OffersPanel.Controls.Add(this.label1);
            this.OffersPanel.Controls.Add(this.OffersGridView);
            this.OffersPanel.Location = new System.Drawing.Point(74, 152);
            this.OffersPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OffersPanel.Name = "OffersPanel";
            this.OffersPanel.Size = new System.Drawing.Size(1490, 645);
            this.OffersPanel.TabIndex = 32;
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
            this.BackButton.Location = new System.Drawing.Point(3, 12);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(54, 40);
            this.BackButton.TabIndex = 31;
            this.BackButton.Text = "🡰";
            this.BackButton.UseCompatibleTextRendering = true;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OffersLabel
            // 
            this.OffersLabel.AutoSize = true;
            this.OffersLabel.Font = new System.Drawing.Font("Onyx", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.OffersLabel.Location = new System.Drawing.Point(69, 2);
            this.OffersLabel.Name = "OffersLabel";
            this.OffersLabel.Size = new System.Drawing.Size(120, 49);
            this.OffersLabel.TabIndex = 30;
            this.OffersLabel.Text = "O f f e r s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(72, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "_______________";
            // 
            // OffersGridView
            // 
            this.OffersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OffersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OffersGridView.Location = new System.Drawing.Point(76, 81);
            this.OffersGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OffersGridView.Name = "OffersGridView";
            this.OffersGridView.RowHeadersWidth = 51;
            this.OffersGridView.RowTemplate.Height = 24;
            this.OffersGridView.Size = new System.Drawing.Size(1299, 495);
            this.OffersGridView.TabIndex = 15;
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
            this.NavigationPanel.Size = new System.Drawing.Size(1623, 75);
            this.NavigationPanel.TabIndex = 33;
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
            // Offers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 893);
            this.Controls.Add(this.OffersPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Name = "Offers";
            this.ShowIcon = false;
            this.Text = "Offers";
            this.Load += new System.EventHandler(this.Offers_Load);
            this.OffersPanel.ResumeLayout(false);
            this.OffersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OffersGridView)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OffersPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label OffersLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OffersGridView;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button LogoButton;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Button AboutButton;
    }
}