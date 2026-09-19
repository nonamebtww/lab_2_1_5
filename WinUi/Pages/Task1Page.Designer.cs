namespace WinUi.Pages
{
    partial class Task1Page
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.Label lbl_result_title;
        private System.Windows.Forms.Label lbl_result;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_input = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_result_title = new System.Windows.Forms.Label();
            this.text_input = new System.Windows.Forms.TextBox();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_task = new System.Windows.Forms.Label();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_input.Location = new System.Drawing.Point(123, 90);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(74, 45);
            this.lbl_input.TabIndex = 1;
            this.lbl_input.Text = "Введите слово:";
            this.lbl_input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_result
            // 
            this.lbl_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_result.Location = new System.Drawing.Point(203, 135);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(74, 45);
            this.lbl_result.TabIndex = 5;
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_result_title
            // 
            this.lbl_result_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_result_title.AutoSize = true;
            this.lbl_result_title.Location = new System.Drawing.Point(129, 151);
            this.lbl_result_title.Name = "lbl_result_title";
            this.lbl_result_title.Size = new System.Drawing.Size(62, 13);
            this.lbl_result_title.TabIndex = 4;
            this.lbl_result_title.Text = "Результат:";
            // 
            // text_input
            // 
            this.text_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_input.Location = new System.Drawing.Point(203, 102);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(74, 20);
            this.text_input.TabIndex = 2;
            this.text_input.TextChanged += new System.EventHandler(this.word_textbox_TextChanged);
            // 
            // layout
            // 
            this.layout.ColumnCount = 4;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layout.Controls.Add(this.lbl_result_title, 1, 3);
            this.layout.Controls.Add(this.lbl_result, 2, 3);
            this.layout.Controls.Add(this.lbl_input, 1, 2);
            this.layout.Controls.Add(this.text_input, 2, 2);
            this.layout.Controls.Add(this.lbl_task, 1, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 5;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.Size = new System.Drawing.Size(400, 225);
            this.layout.TabIndex = 0;
            // 
            // lbl_task
            // 
            this.layout.SetColumnSpan(this.lbl_task, 2);
            this.lbl_task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_task.Location = new System.Drawing.Point(123, 45);
            this.lbl_task.Name = "lbl_task";
            this.lbl_task.Size = new System.Drawing.Size(154, 45);
            this.lbl_task.TabIndex = 6;
            this.lbl_task.Text = "Поменять в слове первую и последнюю буквы";
            this.lbl_task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Task1Page
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.layout);
            this.MinimumSize = new System.Drawing.Size(400, 225);
            this.Name = "Task1Page";
            this.Size = new System.Drawing.Size(400, 225);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lbl_task;
    }
}