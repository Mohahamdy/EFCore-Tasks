using Castle.Components.DictionaryAdapter;
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
    public partial class My_news : Form
    {
        int authorId = 0;
        int newsId = 0;
        BlogContext db;
        public My_news(int authorid)
        {
            InitializeComponent();
            authorId = authorid;
            db = new BlogContext();
        }

        private void My_news_Load(object sender, EventArgs e)
        {
            getNews();

            cb_catalog.DataSource = db.Catalogs.ToList();
            cb_catalog.DisplayMember = "name";
            cb_catalog.ValueMember = "Catalog_Id";
            cb_catalog.SelectedIndex = -1;

            btn_delete.Visible = false;
            btn_update.Visible = false;
        }

        void getNews()
        {
            dgv_news.DataSource = db.news.
                Where(n => n.AuthId == authorId).
                Select(n => new { n.News_Id, n.Title, n.Bref, n.Description, Catalog = n.Cat.name, n.Date, n.Time, n.CatId }).
                ToList();
            dgv_news.Columns[0].Visible = false;
            dgv_news.Columns[7].Visible = false;
        }

        private void dgv_news_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            newsId = (int)dgv_news.SelectedRows[0].Cells[0].Value;
            txt_title.Text = dgv_news.SelectedRows[0].Cells[1].Value.ToString();
            txt_bref.Text = dgv_news.SelectedRows[0].Cells["Bref"].Value.ToString();
            txt_date.Text = dgv_news.SelectedRows[0].Cells["Date"].Value.ToString();
            txt_time.Text = dgv_news.SelectedRows[0].Cells["Time"].Value.ToString();
            rb_desc.Text = dgv_news.SelectedRows[0].Cells["Description"].Value.ToString();
            cb_catalog.SelectedValue = dgv_news.SelectedRows[0].Cells["CatId"].Value;

            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void resetControls()
        {
            txt_bref.Text = txt_date.Text = txt_time.Text = txt_title.Text = rb_desc.Text = "";
            cb_catalog.SelectedIndex = -1;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                News newNews = new News()
                {
                    Title = txt_title.Text,
                    Description = rb_desc.Text,
                    Bref = txt_bref.Text,
                    Date = DateOnly.FromDateTime(DateTime.Now),
                    Time = TimeOnly.FromDateTime(DateTime.Now),
                    AuthId = authorId,
                    CatId = (int)cb_catalog.SelectedValue
                };

                db.news.Add(newNews);
                db.SaveChanges();

                resetControls();
                getNews();

                MessageBox.Show("News has been added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please check data first befor adding !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                News news = db.news.Where(n => n.News_Id == newsId).SingleOrDefault();

                news.Title = txt_title.Text;
                news.Description = rb_desc.Text;
                news.Bref = txt_bref.Text;
                news.Date = DateOnly.FromDateTime(DateTime.Now);
                news.Time = TimeOnly.FromDateTime(DateTime.Now);
                news.CatId = (int)cb_catalog.SelectedValue;

                db.SaveChanges();

                resetControls();
                getNews();

                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;

                MessageBox.Show("News has been updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please check data first befor updating !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                News news = db.news.Where(n => n.News_Id == newsId).SingleOrDefault();
                DialogResult result =MessageBox.Show($"Are sure you want to delete this news {news.Title} !", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    db.news.Remove(news);
                    db.SaveChanges();

                    resetControls();
                    getNews();

                    btn_add.Visible = true;
                    btn_delete.Visible = false;
                    btn_update.Visible = false;

                    MessageBox.Show("News has been deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch
            {
                MessageBox.Show("Please check data first befor deleting !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
