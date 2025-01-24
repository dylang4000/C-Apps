using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("loading the book form");
            List<book> books = new List<book>();
            string[] authors = new string[10];
            book book1 = new book();
            book1.Title = "fortnie";

            book book2 = new book();
            book2.Title = "fortnie2";

            books.Add(book1);
            books.Add(book2);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateBookButton_Click(object sender, EventArgs e)
        {
            
            book newBook = new book();
            newBook.Title = BookTitleBox.Text;
            newBook.PageCount = (uint)pagesNumericUpDown.Value;
            newBook.Price = (float)pricenumericUpDown.Value;
            foreach (bookauthor author in AuthorListBox.Items)
            {
                
                newBook.Authors.Add(author);
            }
            
            BookshelfListBox.Items.Add(newBook);
            newBook.Title = "";
            newBook.PageCount = 1;
            newBook.Price = 0;
            FirstnameTextBox.Text = "";
            LastnameTextBox.Text = "";
            AuthorListBox.Items.Clear();
        }

        private void AddAuthorButton(object sender, EventArgs e)
        {
            bookauthor bookAuthor = new bookauthor();
            bookAuthor.FirstName = FirstnameTextBox.Text;
            bookAuthor.LastName = LastnameTextBox.Text;

            AuthorListBox.Items.Add(bookAuthor);
            FirstnameTextBox.Text = "";
            LastnameTextBox.Text = "";
        }

        private void Savebookshelfbutton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\Dylan Davis\\Desktop\\coding 2\\coding-2\\2024-25-02-02\\WinFormsApp1\\Bookshelf.csv");
            sw.WriteLine();
            sw.Close();
        }
    }
}
