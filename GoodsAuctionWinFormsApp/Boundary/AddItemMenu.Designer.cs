namespace GoodsAuctionWinFormsApp.Boundary
{
    partial class AddItemMenu
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
            this.currentItemsLabel = new System.Windows.Forms.Label();
            this.currentItemsListView = new System.Windows.Forms.ListView();
            this.itemNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.currentBidColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.currentLeaderColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.timeRemainingColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.insertNewItemButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.ItemIDColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // currentItemsLabel
            // 
            this.currentItemsLabel.AutoSize = true;
            this.currentItemsLabel.Location = new System.Drawing.Point(215, 30);
            this.currentItemsLabel.Name = "currentItemsLabel";
            this.currentItemsLabel.Size = new System.Drawing.Size(237, 31);
            this.currentItemsLabel.TabIndex = 0;
            this.currentItemsLabel.Text = "Current Auction Items";
            // 
            // currentItemsListView
            // 
            this.currentItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemNameColumnHeader,
            this.currentBidColumnHeader,
            this.currentLeaderColumnHeader,
            this.timeRemainingColumnHeader,
            this.ItemIDColumnHeader});
            this.currentItemsListView.FullRowSelect = true;
            this.currentItemsListView.GridLines = true;
            this.currentItemsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.currentItemsListView.Location = new System.Drawing.Point(12, 80);
            this.currentItemsListView.Name = "currentItemsListView";
            this.currentItemsListView.Size = new System.Drawing.Size(637, 245);
            this.currentItemsListView.TabIndex = 1;
            this.currentItemsListView.UseCompatibleStateImageBehavior = false;
            this.currentItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // itemNameColumnHeader
            // 
            this.itemNameColumnHeader.DisplayIndex = 1;
            this.itemNameColumnHeader.Text = "Item Name";
            this.itemNameColumnHeader.Width = 150;
            // 
            // currentBidColumnHeader
            // 
            this.currentBidColumnHeader.DisplayIndex = 2;
            this.currentBidColumnHeader.Text = "Current Bid";
            this.currentBidColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentBidColumnHeader.Width = 130;
            // 
            // currentLeaderColumnHeader
            // 
            this.currentLeaderColumnHeader.DisplayIndex = 3;
            this.currentLeaderColumnHeader.Text = "Current Leader";
            this.currentLeaderColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentLeaderColumnHeader.Width = 170;
            // 
            // timeRemainingColumnHeader
            // 
            this.timeRemainingColumnHeader.DisplayIndex = 4;
            this.timeRemainingColumnHeader.Text = "Time Remaining";
            this.timeRemainingColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeRemainingColumnHeader.Width = 180;
            // 
            // insertNewItemButton
            // 
            this.insertNewItemButton.Location = new System.Drawing.Point(234, 342);
            this.insertNewItemButton.Name = "insertNewItemButton";
            this.insertNewItemButton.Size = new System.Drawing.Size(194, 55);
            this.insertNewItemButton.TabIndex = 2;
            this.insertNewItemButton.Text = "Insert New Item";
            this.insertNewItemButton.UseVisualStyleBackColor = true;
            this.insertNewItemButton.Click += new System.EventHandler(this.insertNewItemButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.Location = new System.Drawing.Point(554, 393);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(77, 34);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ItemIDColumnHeader
            // 
            this.ItemIDColumnHeader.DisplayIndex = 0;
            this.ItemIDColumnHeader.Text = "Item ID";
            this.ItemIDColumnHeader.Width = 90;
            // 
            // AddItemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 439);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.insertNewItemButton);
            this.Controls.Add(this.currentItemsListView);
            this.Controls.Add(this.currentItemsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(685, 486);
            this.Name = "AddItemMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label currentItemsLabel;
        private ListView currentItemsListView;
        private ColumnHeader itemNameColumnHeader;
        private ColumnHeader currentBidColumnHeader;
        private ColumnHeader currentLeaderColumnHeader;
        private ColumnHeader timeRemainingColumnHeader;
        private Button insertNewItemButton;
        private Button logoutButton;
        private ColumnHeader ItemIDColumnHeader;
    }
}