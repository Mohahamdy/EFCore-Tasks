namespace CatalogLab
{
    partial class Author_Info
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_name = new TextBox();
            txt_email = new TextBox();
            txt_age = new TextBox();
            txt_address = new TextBox();
            btn_showMynews = new Button();
            btn_showallNews = new Button();
            btn_edit = new Button();
            btn_save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 42);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(244, 108);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(244, 172);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Age :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(244, 238);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Address :";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(352, 39);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(199, 23);
            txt_name.TabIndex = 4;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(352, 105);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(199, 23);
            txt_email.TabIndex = 5;
            // 
            // txt_age
            // 
            txt_age.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_age.Location = new Point(352, 169);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(199, 23);
            txt_age.TabIndex = 6;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_address.Location = new Point(352, 235);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(199, 23);
            txt_address.TabIndex = 7;
            // 
            // btn_showMynews
            // 
            btn_showMynews.Location = new Point(244, 386);
            btn_showMynews.Name = "btn_showMynews";
            btn_showMynews.Size = new Size(117, 33);
            btn_showMynews.TabIndex = 8;
            btn_showMynews.Text = "My news";
            btn_showMynews.UseVisualStyleBackColor = true;
            btn_showMynews.Click += btn_showMynews_Click;
            // 
            // btn_showallNews
            // 
            btn_showallNews.Location = new Point(434, 386);
            btn_showallNews.Name = "btn_showallNews";
            btn_showallNews.Size = new Size(117, 33);
            btn_showallNews.TabIndex = 9;
            btn_showallNews.Text = "All news";
            btn_showallNews.UseVisualStyleBackColor = true;
            btn_showallNews.Click += btn_showallNews_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(286, 302);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 31);
            btn_edit.TabIndex = 10;
            btn_edit.Text = "Edit profile";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += button1_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(434, 302);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 31);
            btn_save.TabIndex = 11;
            btn_save.Text = "Save ";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += button2_Click;
            // 
            // Author_Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_save);
            Controls.Add(btn_edit);
            Controls.Add(btn_showallNews);
            Controls.Add(btn_showMynews);
            Controls.Add(txt_address);
            Controls.Add(txt_age);
            Controls.Add(txt_email);
            Controls.Add(txt_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Author_Info";
            Text = "Profile";
            Load += Author_Info_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_name;
        private TextBox txt_email;
        private TextBox txt_age;
        private TextBox txt_address;
        private Button btn_showMynews;
        private Button btn_showallNews;
        private Button btn_edit;
        private Button btn_save;
    }
}