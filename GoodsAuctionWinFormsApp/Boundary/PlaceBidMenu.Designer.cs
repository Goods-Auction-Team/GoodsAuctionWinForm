namespace GoodsAuctionWinFormsApp.Boundary
{
    partial class PlaceBidMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentItemsListView = new System.Windows.Forms.ListView();
            this.ItemIDHeader = new System.Windows.Forms.ColumnHeader();
            this.itemNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.currentBidColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.currentLeaderColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.timeRemainingColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.selectItemLabel = new System.Windows.Forms.Label();
            this.selectedDescriptionLabel = new System.Windows.Forms.Label();
            this.newBidTextBox = new System.Windows.Forms.TextBox();
            this.newBidLabel = new System.Windows.Forms.Label();
            this.placeBidButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.itemSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bid Away! Go Win Some STUFF!";
            // 
            // currentItemsListView
            // 
            this.currentItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemIDHeader,
            this.itemNameColumnHeader,
            this.currentBidColumnHeader,
            this.currentLeaderColumnHeader,
            this.timeRemainingColumnHeader});
            this.currentItemsListView.FullRowSelect = true;
            this.currentItemsListView.GridLines = true;
            this.currentItemsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.currentItemsListView.Location = new System.Drawing.Point(12, 88);
            this.currentItemsListView.Name = "currentItemsListView";
            this.currentItemsListView.Size = new System.Drawing.Size(638, 245);
            this.currentItemsListView.TabIndex = 2;
            this.currentItemsListView.UseCompatibleStateImageBehavior = false;
            this.currentItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // ItemIDHeader
            // 
            this.ItemIDHeader.Text = "Item ID";
            this.ItemIDHeader.Width = 90;
            // 
            // itemNameColumnHeader
            // 
            this.itemNameColumnHeader.Text = "Item Name";
            this.itemNameColumnHeader.Width = 150;
            // 
            // currentBidColumnHeader
            // 
            this.currentBidColumnHeader.Text = "Current Bid";
            this.currentBidColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentBidColumnHeader.Width = 130;
            // 
            // currentLeaderColumnHeader
            // 
            this.currentLeaderColumnHeader.Text = "Current Leader";
            this.currentLeaderColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentLeaderColumnHeader.Width = 170;
            // 
            // timeRemainingColumnHeader
            // 
            this.timeRemainingColumnHeader.Text = "Time Remaining";
            this.timeRemainingColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeRemainingColumnHeader.Width = 180;
            // 
            // selectItemLabel
            // 
            this.selectItemLabel.AutoSize = true;
            this.selectItemLabel.Location = new System.Drawing.Point(413, 355);
            this.selectItemLabel.Name = "selectItemLabel";
            this.selectItemLabel.Size = new System.Drawing.Size(234, 31);
            this.selectItemLabel.TabIndex = 3;
            this.selectItemLabel.Text = "[Selected Item Name]";
            // 
            // selectedDescriptionLabel
            // 
            this.selectedDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedDescriptionLabel.Location = new System.Drawing.Point(87, 404);
            this.selectedDescriptionLabel.Name = "selectedDescriptionLabel";
            this.selectedDescriptionLabel.Size = new System.Drawing.Size(451, 183);
            this.selectedDescriptionLabel.TabIndex = 4;
            this.selectedDescriptionLabel.Text = "[Selected Item Description]";
            // 
            // newBidTextBox
            // 
            this.newBidTextBox.Location = new System.Drawing.Point(200, 610);
            this.newBidTextBox.Name = "newBidTextBox";
            this.newBidTextBox.Size = new System.Drawing.Size(240, 38);
            this.newBidTextBox.TabIndex = 5;
            // 
            // newBidLabel
            // 
            this.newBidLabel.AutoSize = true;
            this.newBidLabel.Location = new System.Drawing.Point(27, 613);
            this.newBidLabel.Name = "newBidLabel";
            this.newBidLabel.Size = new System.Drawing.Size(167, 31);
            this.newBidLabel.TabIndex = 6;
            this.newBidLabel.Text = "Insert New Bid:";
            // 
            // placeBidButton
            // 
            this.placeBidButton.Location = new System.Drawing.Point(446, 610);
            this.placeBidButton.Name = "placeBidButton";
            this.placeBidButton.Size = new System.Drawing.Size(133, 38);
            this.placeBidButton.TabIndex = 7;
            this.placeBidButton.Text = "Place Bid";
            this.placeBidButton.UseVisualStyleBackColor = true;
            this.placeBidButton.Click += new System.EventHandler(this.placeBidButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.Location = new System.Drawing.Point(571, 654);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(79, 35);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // itemSelector
            // 
            this.itemSelector.FormattingEnabled = true;
            this.itemSelector.Location = new System.Drawing.Point(242, 352);
            this.itemSelector.Name = "itemSelector";
            this.itemSelector.Size = new System.Drawing.Size(151, 39);
            this.itemSelector.TabIndex = 9;
            this.itemSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select an Item ID:";
            // 
            // PlaceBidMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 701);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemSelector);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.placeBidButton);
            this.Controls.Add(this.newBidLabel);
            this.Controls.Add(this.newBidTextBox);
            this.Controls.Add(this.selectedDescriptionLabel);
            this.Controls.Add(this.selectItemLabel);
            this.Controls.Add(this.currentItemsListView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(677, 748);
            this.Name = "PlaceBidMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaceBidMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView currentItemsListView;
        private ColumnHeader itemNameColumnHeader;
        private ColumnHeader currentBidColumnHeader;
        private ColumnHeader currentLeaderColumnHeader;
        private ColumnHeader timeRemainingColumnHeader;
        private Label selectItemLabel;
        private Label selectedDescriptionLabel;
        private TextBox newBidTextBox;
        private Label newBidLabel;
        private Button placeBidButton;
        private Button logoutButton;
        private ColumnHeader ItemIDHeader;
        private ComboBox itemSelector;
        private Label label2;
    }
}