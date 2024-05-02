using CatalogLab.Models;

namespace CatalogLab

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            BlogContext db = new BlogContext();
            string email = txt_email.Text;
            string pass = txt_pass.Text;

            Author? author = db.Authors.Where(author => author.Email == email && author.Password == pass).SingleOrDefault();

            if (author != null)
            {
                MessageBox.Show("You are logged successfully","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Author_Info author_Info = new Author_Info(author);

                this.Hide();
                author_Info.ShowDialog();
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Uncorrect email or password","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
