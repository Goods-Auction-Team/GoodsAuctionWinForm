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
            this.selectItemLabel = new System.Windows.Forms.Label();
            this.selectedDescriptionLabel = new System.Windows.Forms.Label();
            this.newBidTextBox = new System.Windows.Forms.TextBox();
            this.newBidLabel = new System.Windows.Forms.Label();
            this.placeBidButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.itemSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemListViewer = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemListViewer)).BeginInit();
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
            // selectItemLabel
            // 
            this.selectItemLabel.AutoSize = true;
            this.selectItemLabel.Location = new System.Drawing.Point(655, 355);
            this.selectItemLabel.Name = "selectItemLabel";
            this.selectItemLabel.Size = new System.Drawing.Size(234, 31);
            this.selectItemLabel.TabIndex = 3;
            this.selectItemLabel.Text = "[Selected Item Name]";
            // 
            // selectedDescriptionLabel
            // 
            this.selectedDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedDescriptionLabel.Location = new System.Drawing.Point(258, 410);
            this.selectedDescriptionLabel.Name = "selectedDescriptionLabel";
            this.selectedDescriptionLabel.Size = new System.Drawing.Size(451, 183);
            this.selectedDescriptionLabel.TabIndex = 4;
            this.selectedDescriptionLabel.Text = "[Selected Item Description]";
            // 
            // newBidTextBox
            // 
            this.newBidTextBox.Location = new System.Drawing.Point(344, 611);
            this.newBidTextBox.Name = "newBidTextBox";
            this.newBidTextBox.Size = new System.Drawing.Size(240, 38);
            this.newBidTextBox.TabIndex = 5;
            // 
            // newBidLabel
            // 
            this.newBidLabel.AutoSize = true;
            this.newBidLabel.Location = new System.Drawing.Point(84, 613);
            this.newBidLabel.Name = "newBidLabel";
            this.newBidLabel.Size = new System.Drawing.Size(167, 31);
            this.newBidLabel.TabIndex = 6;
            this.newBidLabel.Text = "Insert New Bid:";
            // 
            // placeBidButton
            // 
            this.placeBidButton.Location = new System.Drawing.Point(702, 610);
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
            this.logoutButton.Location = new System.Drawing.Point(810, 654);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(79, 35);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // itemSelector
            // 
            this.itemSelector.FormattingEnabled = true;
            this.itemSelector.Location = new System.Drawing.Point(397, 352);
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
            // ItemListViewer
            // 
            this.ItemListViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemListViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemListViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.CurrentBid,
            this.CurrentLeader,
            this.EndTime});
            this.ItemListViewer.Location = new System.Drawing.Point(12, 75);
            this.ItemListViewer.Name = "ItemListViewer";
            this.ItemListViewer.ReadOnly = true;
            this.ItemListViewer.RowHeadersWidth = 51;
            this.ItemListViewer.RowTemplate.Height = 29;
            this.ItemListViewer.Size = new System.Drawing.Size(972, 227);
            this.ItemListViewer.TabIndex = 11;
            this.ItemListViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // CurrentBid
            // 
            this.CurrentBid.HeaderText = "Current Bid";
            this.CurrentBid.MinimumWidth = 6;
            this.CurrentBid.Name = "CurrentBid";
            this.CurrentBid.ReadOnly = true;
            // 
            // CurrentLeader
            // 
            this.CurrentLeader.HeaderText = "Current Leader";
            this.CurrentLeader.MinimumWidth = 6;
            this.CurrentLeader.Name = "CurrentLeader";
            this.CurrentLeader.ReadOnly = true;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            // 
            // PlaceBidMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 701);
            this.Controls.Add(this.ItemListViewer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemSelector);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.placeBidButton);
            this.Controls.Add(this.newBidLabel);
            this.Controls.Add(this.newBidTextBox);
            this.Controls.Add(this.selectedDescriptionLabel);
            this.Controls.Add(this.selectItemLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(677, 748);
            this.Name = "PlaceBidMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaceBidMenu";
            ((System.ComponentModel.ISupportInitialize)(this.ItemListViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label selectItemLabel;
        private Label selectedDescriptionLabel;
        private TextBox newBidTextBox;
        private Label newBidLabel;
        private Button placeBidButton;
        private Button logoutButton;
        private ComboBox itemSelector;
        private Label label2;
        private DataGridView ItemListViewer;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn CurrentBid;
        private DataGridViewTextBoxColumn CurrentLeader;
        private DataGridViewTextBoxColumn EndTime;
    }
}