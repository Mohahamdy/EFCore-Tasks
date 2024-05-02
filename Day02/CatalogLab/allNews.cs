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
    public partial class allNews : Form
    {
        BlogContext db;
        public allNews()
        {
            InitializeComponent();

            db = new BlogContext();
        }

        private void allNews_Load(object sender, EventArgs e)
        {
            dgv_news.DataSource = db.news.Select(n => new { n.Title, n.Bref, n.Description, Catalog = n.Cat.name, Author = n.Auth.Username, n.Date, n.Time }).ToList();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
