namespace StudentCRUD
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
            cb_dept = new ComboBox();
            cb_sup = new ComboBox();
            txt_address = new TextBox();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            txt_age = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            dgv_students = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            SuspendLayout();
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(518, 23);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(121, 23);
            cb_dept.TabIndex = 0;
            // 
            // cb_sup
            // 
            cb_sup.FormattingEnabled = true;
            cb_sup.Location = new Point(518, 61);
            cb_sup.Name = "cb_sup";
            cb_sup.Size = new Size(121, 23);
            cb_sup.TabIndex = 1;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(286, 110);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(121, 23);
            txt_address.TabIndex = 2;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(286, 23);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(121, 23);
            txt_fname.TabIndex = 3;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(286, 52);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(121, 23);
            txt_lname.TabIndex = 4;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(286, 81);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(121, 23);
            txt_age.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Fname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 55);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Lname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 84);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 8;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 118);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 9;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 26);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 64);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 11;
            label6.Text = "SuperVisor";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(547, 173);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(92, 29);
            btn_add.TabIndex = 12;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(383, 173);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(89, 29);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(201, 173);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(87, 29);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // dgv_students
            // 
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Location = new Point(12, 237);
            dgv_students.Name = "dgv_students";
            dgv_students.Size = new Size(776, 201);
            dgv_students.TabIndex = 15;
            dgv_students.RowHeaderMouseDoubleClick += dgv_students_RowHeaderMouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_students);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_age);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            Controls.Add(txt_address);
            Controls.Add(cb_sup);
            Controls.Add(cb_dept);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_dept;
        private ComboBox cb_sup;
        private TextBox txt_address;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private TextBox txt_age;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private DataGridView dgv_students;
    }
}
