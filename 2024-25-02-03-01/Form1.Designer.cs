namespace _2024_25_02_03_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InventoryTreeView = new TreeView();
            ItemsBox = new CheckedListBox();
            AddBoxButton = new Button();
            AddItemsButton = new Button();
            BoxRenameTextbox = new TextBox();
            BoxRenameButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // InventoryTreeView
            // 
            InventoryTreeView.BackColor = SystemColors.ControlDarkDark;
            InventoryTreeView.ForeColor = SystemColors.ButtonFace;
            InventoryTreeView.Location = new Point(12, 85);
            InventoryTreeView.Name = "InventoryTreeView";
            InventoryTreeView.Size = new Size(204, 247);
            InventoryTreeView.TabIndex = 0;
            InventoryTreeView.NodeMouseDoubleClick += InventoryTreeView_NodeMouseDoubleClick;
            // 
            // ItemsBox
            // 
            ItemsBox.BackColor = SystemColors.ControlDarkDark;
            ItemsBox.ForeColor = SystemColors.ControlLightLight;
            ItemsBox.FormattingEnabled = true;
            ItemsBox.Items.AddRange(new object[] { "item1", "item2", "item3", "item4", "item5", "item6", "item7", "item8", "item9", "item10", "item11", "item12" });
            ItemsBox.Location = new Point(352, 85);
            ItemsBox.Name = "ItemsBox";
            ItemsBox.Size = new Size(205, 256);
            ItemsBox.TabIndex = 1;
            ItemsBox.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // AddBoxButton
            // 
            AddBoxButton.BackColor = SystemColors.ControlDarkDark;
            AddBoxButton.Location = new Point(242, 85);
            AddBoxButton.Name = "AddBoxButton";
            AddBoxButton.Size = new Size(75, 66);
            AddBoxButton.TabIndex = 2;
            AddBoxButton.Text = "Add Box";
            AddBoxButton.UseVisualStyleBackColor = false;
            AddBoxButton.Click += AddBoxButton_Click;
            // 
            // AddItemsButton
            // 
            AddItemsButton.BackColor = SystemColors.ControlDarkDark;
            AddItemsButton.Location = new Point(242, 266);
            AddItemsButton.Name = "AddItemsButton";
            AddItemsButton.Size = new Size(75, 66);
            AddItemsButton.TabIndex = 3;
            AddItemsButton.Text = "Add Items";
            AddItemsButton.UseVisualStyleBackColor = false;
            AddItemsButton.Click += AddItemsButton_Click;
            // 
            // BoxRenameTextbox
            // 
            BoxRenameTextbox.Location = new Point(12, 56);
            BoxRenameTextbox.Name = "BoxRenameTextbox";
            BoxRenameTextbox.Size = new Size(100, 23);
            BoxRenameTextbox.TabIndex = 4;
            BoxRenameTextbox.Visible = false;
            // 
            // BoxRenameButton
            // 
            BoxRenameButton.BackColor = SystemColors.ControlDarkDark;
            BoxRenameButton.ForeColor = SystemColors.ButtonFace;
            BoxRenameButton.Location = new Point(127, 56);
            BoxRenameButton.Name = "BoxRenameButton";
            BoxRenameButton.Size = new Size(75, 23);
            BoxRenameButton.TabIndex = 5;
            BoxRenameButton.Text = "Rename";
            BoxRenameButton.UseVisualStyleBackColor = false;
            BoxRenameButton.Visible = false;
            BoxRenameButton.Click += BoxRenameButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 6;
            label1.Text = "Inventory:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(352, 58);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 7;
            label2.Text = "Items to add:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(577, 360);
            Controls.Add(label2);
            Controls.Add(BoxRenameTextbox);
            Controls.Add(label1);
            Controls.Add(BoxRenameButton);
            Controls.Add(AddItemsButton);
            Controls.Add(AddBoxButton);
            Controls.Add(ItemsBox);
            Controls.Add(InventoryTreeView);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView InventoryTreeView;
        private CheckedListBox ItemsBox;
        private Button AddBoxButton;
        private Button AddItemsButton;
        private TextBox BoxRenameTextbox;
        private Button BoxRenameButton;
        private Label label1;
        private Label label2;
    }
}
