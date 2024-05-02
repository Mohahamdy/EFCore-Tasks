namespace CatalogLab
{
    partial class allNews
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
            btn_back = new Button();
            dgv_news = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_news).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(344, 372);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(119, 35);
            btn_back.TabIndex = 0;
            btn_back.Text = "To profile";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // dgv_news
            // 
            dgv_news.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_news.Location = new Point(12, 12);
            dgv_news.Name = "dgv_news";
            dgv_news.Size = new Size(776, 335);
            dgv_news.TabIndex = 1;
            // 
            // allNews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_news);
            Controls.Add(btn_back);
            Name = "allNews";
            Text = "All news";
            Load += allNews_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_news).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
        private DataGridView dgv_news;
    }
}