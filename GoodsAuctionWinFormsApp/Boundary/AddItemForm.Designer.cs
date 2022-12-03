namespace GoodsAuctionWinFormsApp.Boundary
{
    partial class AddItemForm
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
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.startingBidLabel = new System.Windows.Forms.Label();
            this.StartBidBox = new System.Windows.Forms.TextBox();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.failLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(49, 29);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(127, 31);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Item Name";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(19, 66);
            this.itemNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(181, 38);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(445, 29);
            this.durationLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(103, 31);
            this.durationLabel.TabIndex = 2;
            this.durationLabel.Text = "Duration";
            // 
            // startingBidLabel
            // 
            this.startingBidLabel.AutoSize = true;
            this.startingBidLabel.Location = new System.Drawing.Point(256, 29);
            this.startingBidLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.startingBidLabel.Name = "startingBidLabel";
            this.startingBidLabel.Size = new System.Drawing.Size(133, 31);
            this.startingBidLabel.TabIndex = 3;
            this.startingBidLabel.Text = "Starting Bid";
            // 
            // StartBidBox
            // 
            this.StartBidBox.Location = new System.Drawing.Point(236, 66);
            this.StartBidBox.Margin = new System.Windows.Forms.Padding(5);
            this.StartBidBox.Name = "StartBidBox";
            this.StartBidBox.Size = new System.Drawing.Size(153, 38);
            this.StartBidBox.TabIndex = 2;
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Location = new System.Drawing.Point(207, 143);
            this.itemDescriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(183, 31);
            this.itemDescriptionLabel.TabIndex = 5;
            this.itemDescriptionLabel.Text = "Item Description";
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(104, 179);
            this.itemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.itemDescriptionTextBox.Multiline = true;
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(383, 182);
            this.itemDescriptionTextBox.TabIndex = 4;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(236, 371);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(5);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(153, 45);
            this.addItemButton.TabIndex = 5;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // durationComboBox
            // 
            this.durationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Items.AddRange(new object[] {
            "1 minute",
            "2 minutes",
            "3 minutes"});
            this.durationComboBox.Location = new System.Drawing.Point(419, 66);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(151, 39);
            this.durationComboBox.TabIndex = 3;
            // 
            // failLabel
            // 
            this.failLabel.AutoSize = true;
            this.failLabel.ForeColor = System.Drawing.Color.Red;
            this.failLabel.Location = new System.Drawing.Point(164, 108);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(279, 31);
            this.failLabel.TabIndex = 6;
            this.failLabel.Text = "Insert Failed! Check fields!";
            this.failLabel.Visible = false;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 423);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.durationComboBox);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemDescriptionTextBox);
            this.Controls.Add(this.itemDescriptionLabel);
            this.Controls.Add(this.StartBidBox);
            this.Controls.Add(this.startingBidLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.itemNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(561, 470);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        int[] timeList = { 1, 2, 5, 10, 30, 60, 120, 1440, 10080 };
        private Label itemNameLabel;
        private TextBox itemNameTextBox;
        private Label durationLabel;
        private Label startingBidLabel;
        private TextBox StartBidBox;
        private Label itemDescriptionLabel;
        private TextBox itemDescriptionTextBox;
        private Button addItemButton;
        private ComboBox durationComboBox;
        private Label failLabel;
    }
}