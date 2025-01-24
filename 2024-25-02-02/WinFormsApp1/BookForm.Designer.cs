namespace WinFormsApp1
{
    partial class BookForm
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
            BookTitleLabel = new Label();
            BookTitleBox = new TextBox();
            PagesLabel = new Label();
            pagesNumericUpDown = new NumericUpDown();
            pricenumericUpDown = new NumericUpDown();
            Pricelabel = new Label();
            AuthorListBox = new ListBox();
            FirstnameLabel = new Label();
            AuthorOanel = new Panel();
            AddauthorButton = new Button();
            LastnameTextBox = new TextBox();
            Lastnamelabel = new Label();
            FirstnameTextBox = new TextBox();
            CreateBookButton = new Button();
            BookshelfListBox = new ListBox();
            Savebookshelfbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pagesNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pricenumericUpDown).BeginInit();
            AuthorOanel.SuspendLayout();
            SuspendLayout();
            // 
            // BookTitleLabel
            // 
            BookTitleLabel.AutoSize = true;
            BookTitleLabel.Location = new Point(25, 26);
            BookTitleLabel.Name = "BookTitleLabel";
            BookTitleLabel.Size = new Size(48, 25);
            BookTitleLabel.TabIndex = 0;
            BookTitleLabel.Text = "Title:";
            // 
            // BookTitleBox
            // 
            BookTitleBox.Location = new Point(25, 67);
            BookTitleBox.Name = "BookTitleBox";
            BookTitleBox.PlaceholderText = "Enter a Book titel";
            BookTitleBox.Size = new Size(324, 31);
            BookTitleBox.TabIndex = 1;
            // 
            // PagesLabel
            // 
            PagesLabel.AutoSize = true;
            PagesLabel.Location = new Point(25, 112);
            PagesLabel.Name = "PagesLabel";
            PagesLabel.Size = new Size(62, 25);
            PagesLabel.TabIndex = 2;
            PagesLabel.Text = "Pages:";
            // 
            // pagesNumericUpDown
            // 
            pagesNumericUpDown.Location = new Point(25, 150);
            pagesNumericUpDown.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            pagesNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            pagesNumericUpDown.Name = "pagesNumericUpDown";
            pagesNumericUpDown.Size = new Size(180, 31);
            pagesNumericUpDown.TabIndex = 3;
            pagesNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pricenumericUpDown
            // 
            pricenumericUpDown.DecimalPlaces = 2;
            pricenumericUpDown.Location = new Point(229, 150);
            pricenumericUpDown.Name = "pricenumericUpDown";
            pricenumericUpDown.Size = new Size(120, 31);
            pricenumericUpDown.TabIndex = 5;
            // 
            // Pricelabel
            // 
            Pricelabel.AutoSize = true;
            Pricelabel.Location = new Point(229, 112);
            Pricelabel.Name = "Pricelabel";
            Pricelabel.Size = new Size(53, 25);
            Pricelabel.TabIndex = 4;
            Pricelabel.Text = "Price:";
            // 
            // AuthorListBox
            // 
            AuthorListBox.FormattingEnabled = true;
            AuthorListBox.ItemHeight = 25;
            AuthorListBox.Location = new Point(369, 26);
            AuthorListBox.Name = "AuthorListBox";
            AuthorListBox.Size = new Size(259, 304);
            AuthorListBox.TabIndex = 6;
            AuthorListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FirstnameLabel
            // 
            FirstnameLabel.AutoSize = true;
            FirstnameLabel.Location = new Point(13, 18);
            FirstnameLabel.Name = "FirstnameLabel";
            FirstnameLabel.Size = new Size(89, 25);
            FirstnameLabel.TabIndex = 7;
            FirstnameLabel.Text = "Firstname";
            // 
            // AuthorOanel
            // 
            AuthorOanel.Controls.Add(AddauthorButton);
            AuthorOanel.Controls.Add(LastnameTextBox);
            AuthorOanel.Controls.Add(Lastnamelabel);
            AuthorOanel.Controls.Add(FirstnameTextBox);
            AuthorOanel.Controls.Add(FirstnameLabel);
            AuthorOanel.Location = new Point(25, 212);
            AuthorOanel.Name = "AuthorOanel";
            AuthorOanel.Size = new Size(298, 226);
            AuthorOanel.TabIndex = 8;
            // 
            // AddauthorButton
            // 
            AddauthorButton.Location = new Point(20, 166);
            AddauthorButton.Name = "AddauthorButton";
            AddauthorButton.Size = new Size(144, 34);
            AddauthorButton.TabIndex = 11;
            AddauthorButton.Text = "Add Author";
            AddauthorButton.UseVisualStyleBackColor = true;
            AddauthorButton.Click += AddAuthorButton;
            // 
            // LastnameTextBox
            // 
            LastnameTextBox.Location = new Point(20, 129);
            LastnameTextBox.Name = "LastnameTextBox";
            LastnameTextBox.PlaceholderText = "Enter the authors first name";
            LastnameTextBox.Size = new Size(232, 31);
            LastnameTextBox.TabIndex = 10;
            LastnameTextBox.TextChanged += textBox2_TextChanged;
            // 
            // Lastnamelabel
            // 
            Lastnamelabel.AutoSize = true;
            Lastnamelabel.Location = new Point(20, 101);
            Lastnamelabel.Name = "Lastnamelabel";
            Lastnamelabel.Size = new Size(87, 25);
            Lastnamelabel.TabIndex = 9;
            Lastnamelabel.Text = "Lastname";
            // 
            // FirstnameTextBox
            // 
            FirstnameTextBox.Location = new Point(13, 46);
            FirstnameTextBox.Name = "FirstnameTextBox";
            FirstnameTextBox.PlaceholderText = "Enter the authors first name";
            FirstnameTextBox.Size = new Size(232, 31);
            FirstnameTextBox.TabIndex = 8;
            // 
            // CreateBookButton
            // 
            CreateBookButton.Location = new Point(395, 338);
            CreateBookButton.Name = "CreateBookButton";
            CreateBookButton.Size = new Size(201, 92);
            CreateBookButton.TabIndex = 9;
            CreateBookButton.Text = "Create Book";
            CreateBookButton.UseVisualStyleBackColor = true;
            CreateBookButton.Click += CreateBookButton_Click;
            // 
            // BookshelfListBox
            // 
            BookshelfListBox.FormattingEnabled = true;
            BookshelfListBox.ItemHeight = 25;
            BookshelfListBox.Location = new Point(738, 26);
            BookshelfListBox.Name = "BookshelfListBox";
            BookshelfListBox.Size = new Size(529, 304);
            BookshelfListBox.TabIndex = 10;
            // 
            // Savebookshelfbutton
            // 
            Savebookshelfbutton.Location = new Point(818, 349);
            Savebookshelfbutton.Name = "Savebookshelfbutton";
            Savebookshelfbutton.Size = new Size(190, 71);
            Savebookshelfbutton.TabIndex = 11;
            Savebookshelfbutton.Text = "Save Book shelf";
            Savebookshelfbutton.UseVisualStyleBackColor = true;
            Savebookshelfbutton.Click += Savebookshelfbutton_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 450);
            Controls.Add(Savebookshelfbutton);
            Controls.Add(BookshelfListBox);
            Controls.Add(CreateBookButton);
            Controls.Add(AuthorOanel);
            Controls.Add(AuthorListBox);
            Controls.Add(pricenumericUpDown);
            Controls.Add(Pricelabel);
            Controls.Add(pagesNumericUpDown);
            Controls.Add(PagesLabel);
            Controls.Add(BookTitleBox);
            Controls.Add(BookTitleLabel);
            Name = "BookForm";
            Text = "BookForm";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)pagesNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pricenumericUpDown).EndInit();
            AuthorOanel.ResumeLayout(false);
            AuthorOanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BookTitleLabel;
        private TextBox BookTitleBox;
        private Label PagesLabel;
        private NumericUpDown pagesNumericUpDown;
        private NumericUpDown pricenumericUpDown;
        private Label Pricelabel;
        private ListBox AuthorListBox;
        private Label FirstnameLabel;
        private Panel AuthorOanel;
        private TextBox LastnameTextBox;
        private Label Lastnamelabel;
        private TextBox FirstnameTextBox;
        private Button AddauthorButton;
        private Button CreateBookButton;
        private ListBox BookshelfListBox;
        private Button Savebookshelfbutton;
    }
}