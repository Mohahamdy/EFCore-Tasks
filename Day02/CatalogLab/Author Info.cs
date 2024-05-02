using CatalogLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogLab
{
    public partial class Author_Info : Form
    {
        Author Author;
        BlogContext db;
        public Author_Info(Author author)
        {
            Author = author;
            InitializeComponent();
            db = new BlogContext();
        }
        
        void showAuthorData(Author author)
        {
            txt_name.Text = author.Username;
            txt_email.Text = author.Email;
            txt_age.Text = author.Age.ToString();
            txt_address.Text = author.Adress;
        }
        private void Author_Info_Load(object sender, EventArgs e)
        {
            txt_address.Enabled = txt_age.Enabled = txt_email.Enabled = txt_name.Enabled = false;
            btn_save.Visible = false;

            showAuthorData(Author);
        }

        private void btn_showMynews_Click(object sender, EventArgs e)
        {
            My_news my_News = new My_news(Author.Author_Id);

            this.Hide();
            my_News.ShowDialog();
            this.Show();
        }

        private void btn_showallNews_Click(object sender, EventArgs e)
        {
            allNews allNews = new allNews();

            this.Hide();
            allNews.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_address.Enabled = txt_age.Enabled = txt_email.Enabled = txt_name.Enabled = true;
            btn_save.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Author author = db.Authors.Where(a => a.Author_Id == Author.Author_Id).FirstOrDefault();

            author.Username = txt_name.Text;
            author.Email = txt_email.Text;
            author.Age = int.Parse(txt_age.Text);
            author.Adress = txt_address.Text;

            db.SaveChanges();

            showAuthorData(author);

            txt_address.Enabled = txt_age.Enabled = txt_email.Enabled = txt_name.Enabled = false;
            btn_save.Visible = false;

            MessageBox.Show("Data updated successfuly", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
