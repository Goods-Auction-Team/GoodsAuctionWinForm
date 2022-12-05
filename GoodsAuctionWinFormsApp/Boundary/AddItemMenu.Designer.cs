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
            this.insertNewItemButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.ItemListViewer = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemListViewer)).BeginInit();
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
            // ItemListViewer
            // 
            this.ItemListViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemListViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.CurrentBid,
            this.CurrentLeader,
            this.EndTime});
            this.ItemListViewer.Location = new System.Drawing.Point(1, 89);
            this.ItemListViewer.Name = "ItemListViewer";
            this.ItemListViewer.RowHeadersWidth = 51;
            this.ItemListViewer.RowTemplate.Height = 29;
            this.ItemListViewer.Size = new System.Drawing.Size(654, 227);
            this.ItemListViewer.TabIndex = 12;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 125;
            // 
            // CurrentBid
            // 
            this.CurrentBid.HeaderText = "Current Bid";
            this.CurrentBid.MinimumWidth = 6;
            this.CurrentBid.Name = "CurrentBid";
            this.CurrentBid.ReadOnly = true;
            this.CurrentBid.Width = 125;
            // 
            // CurrentLeader
            // 
            this.CurrentLeader.HeaderText = "Current Leader";
            this.CurrentLeader.MinimumWidth = 6;
            this.CurrentLeader.Name = "CurrentLeader";
            this.CurrentLeader.ReadOnly = true;
            this.CurrentLeader.Width = 125;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 125;
            // 
            // AddItemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 439);
            this.Controls.Add(this.ItemListViewer);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.insertNewItemButton);
            this.Controls.Add(this.currentItemsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(685, 486);
            this.Name = "AddItemMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemMenu";
            ((System.ComponentModel.ISupportInitialize)(this.ItemListViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label currentItemsLabel;
        private Button insertNewItemButton;
        private Button logoutButton;
        private DataGridView ItemListViewer;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn CurrentBid;
        private DataGridViewTextBoxColumn CurrentLeader;
        private DataGridViewTextBoxColumn EndTime;
    }
}