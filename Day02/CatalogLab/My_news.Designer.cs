namespace CatalogLab
{
    partial class My_news
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
            dgv_news = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_title = new TextBox();
            txt_bref = new TextBox();
            txt_date = new TextBox();
            txt_time = new TextBox();
            rb_desc = new RichTextBox();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_back = new Button();
            label6 = new Label();
            cb_catalog = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_news).BeginInit();
            SuspendLayout();
            // 
            // dgv_news
            // 
            dgv_news.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_news.Location = new Point(384, 12);
            dgv_news.Name = "dgv_news";
            dgv_news.Size = new Size(404, 426);
            dgv_news.TabIndex = 0;
            dgv_news.RowHeaderMouseDoubleClick += dgv_news_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 32);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 61);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "Bref";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 126);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Desc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 193);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 222);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 5;
            label5.Text = "Time";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(112, 29);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(266, 23);
            txt_title.TabIndex = 6;
            // 
            // txt_bref
            // 
            txt_bref.Location = new Point(112, 58);
            txt_bref.Name = "txt_bref";
            txt_bref.Size = new Size(266, 23);
            txt_bref.TabIndex = 7;
            // 
            // txt_date
            // 
            txt_date.Location = new Point(112, 190);
            txt_date.Name = "txt_date";
            txt_date.ReadOnly = true;
            txt_date.Size = new Size(266, 23);
            txt_date.TabIndex = 8;
            txt_date.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_time
            // 
            txt_time.Location = new Point(112, 219);
            txt_time.Name = "txt_time";
            txt_time.ReadOnly = true;
            txt_time.Size = new Size(266, 23);
            txt_time.TabIndex = 9;
            txt_time.TextAlign = HorizontalAlignment.Center;
            // 
            // rb_desc
            // 
            rb_desc.Location = new Point(112, 87);
            rb_desc.Name = "rb_desc";
            rb_desc.Size = new Size(266, 96);
            rb_desc.TabIndex = 10;
            rb_desc.Text = "";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(10, 324);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(85, 31);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(154, 324);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(85, 31);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(293, 324);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(85, 31);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(142, 388);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(117, 31);
            btn_back.TabIndex = 14;
            btn_back.Text = "To profile";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 273);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 15;
            label6.Text = "Catalog";
            // 
            // cb_catalog
            // 
            cb_catalog.FormattingEnabled = true;
            cb_catalog.Location = new Point(112, 270);
            cb_catalog.Name = "cb_catalog";
            cb_catalog.Size = new Size(266, 23);
            cb_catalog.TabIndex = 16;
            // 
            // My_news
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_catalog);
            Controls.Add(label6);
            Controls.Add(btn_back);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(rb_desc);
            Controls.Add(txt_time);
            Controls.Add(txt_date);
            Controls.Add(txt_bref);
            Controls.Add(txt_title);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_news);
            Name = "My_news";
            Text = "My news";
            Load += My_news_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_news).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_news;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_title;
        private TextBox txt_bref;
        private TextBox txt_date;
        private TextBox txt_time;
        private RichTextBox rb_desc;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_back;
        private Label label6;
        private ComboBox cb_catalog;
    }
}