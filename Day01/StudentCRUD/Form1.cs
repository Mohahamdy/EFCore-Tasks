using StudentCRUD.Models;

namespace StudentCRUD
{
    public partial class Form1 : Form
    {
        ItiContext DB;
        public Form1()
        {
            InitializeComponent();
            DB = new ItiContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_students.DataSource = DB.Students.Select(s => new { s.StId, s.StFname, s.StLname, s.StAge, s.StAddress, sup_fname = s.StSuperNavigation.StFname, s.Dept.DeptName, s.Dept.DeptLocation }).ToList();
            dgv_students.Columns[0].Visible = false;

            cb_dept.DataSource = DB.Departments.ToList();
            cb_dept.DisplayMember = "DeptName";
            cb_dept.ValueMember = "DeptId";

            cb_sup.DataSource = DB.Students.ToList();
            cb_sup.DisplayMember = "StFname";
            cb_sup.ValueMember = "StId";

            cb_dept.SelectedIndex = -1;
            cb_sup.SelectedIndex = -1;

            btn_delete.Visible = false;
            btn_update.Visible = false;
        }

        void Update_dgv(string message, string caption)
        {
            dgv_students.DataSource = DB.Students.Select(s => new { s.StId, s.StFname, s.StLname, s.StAge, s.StAddress, sup_fname = s.StSuperNavigation.StFname, s.Dept.DeptName, s.Dept.DeptLocation }).ToList();
            dgv_students.Columns[0].Visible = false;

            txt_fname.Text = txt_lname.Text = txt_address.Text = txt_age.Text = "";
            cb_dept.SelectedIndex = cb_sup.SelectedIndex = -1;

            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student()
                {
                    StFname = txt_fname.Text,
                    StLname = txt_lname.Text,
                    StAddress = txt_address.Text,
                    StAge = int.Parse(txt_age.Text),
                    StSuper = (int)cb_sup.SelectedValue,
                    DeptId = (int)cb_dept.SelectedValue,
                };

                DB.Students.Add(s);
                DB.SaveChanges();
                Update_dgv("Data added successfully", "ADD");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.InnerException);
            }

        }

        int id = 0;
        private void dgv_students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_students.SelectedRows[0].Cells[0].Value;

            Student s = DB.Students.Where(s => s.StId == id).FirstOrDefault();

            txt_fname.Text = s.StFname;
            txt_lname.Text = s.StLname;
            txt_age.Text = s.StAge.ToString();
            txt_address.Text = s.StAddress;
            if (s.StSuper == null)
                cb_sup.SelectedIndex = -1;
            else
                cb_sup.SelectedValue = s.StSuper;

            if (s.DeptId == null)
                cb_dept.SelectedIndex = -1;
            else
                cb_dept.SelectedValue = s.DeptId;

            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = DB.Students.Where(s => s.StId == id).FirstOrDefault();

                s.StFname = txt_fname.Text;
                s.StLname = txt_lname.Text;
                s.StAge = int.Parse(txt_age.Text);
                s.StAddress = txt_address.Text;
                s.DeptId = (int)cb_dept.SelectedValue;
                if (cb_sup.SelectedValue == null)
                    s.StSuper = null;
                else
                    s.StSuper = (int)cb_sup.SelectedValue;

                DB.SaveChanges();
                Update_dgv("Data updated successfully", "Update");

                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message+" "+ex.InnerException);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = DB.Students.Where(s => s.StId == id).FirstOrDefault();

                DB.Remove(s);
                DB.SaveChanges();
                Update_dgv("Data deleted successfully", "Delete");

                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.InnerException);
            }
        }
    }
}
