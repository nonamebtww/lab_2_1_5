namespace WinUi.Pages {
partial class Task3Page {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TableLayoutPanel layout;
    private System.Windows.Forms.Label lbl_input;
    private System.Windows.Forms.TextBox text_input;
    private System.Windows.Forms.Label lbl_result_title;
    private System.Windows.Forms.Label lbl_result;

    protected override void Dispose(bool disposing) {
        if (disposing && components != null)
            components.Dispose();

        base.Dispose(disposing);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.layout = new System.Windows.Forms.TableLayoutPanel();
        this.text_input = new System.Windows.Forms.TextBox();
        this.lbl_result = new System.Windows.Forms.Label();
        this.lbl_result_title = new System.Windows.Forms.Label();
        this.lbl_input = new System.Windows.Forms.Label();
        this.layout.SuspendLayout();
        this.SuspendLayout();
        // 
        // layout
        // 
        this.layout.ColumnCount = 4;
        this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
        this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
        this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        this.layout.Controls.Add(this.text_input, 2, 1);
        this.layout.Controls.Add(this.lbl_result, 2, 2);
        this.layout.Controls.Add(this.lbl_result_title, 1, 2);
        this.layout.Controls.Add(this.lbl_input, 1, 1);
        this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
        this.layout.Location = new System.Drawing.Point(0, 0);
        this.layout.Name = "layout";
        this.layout.RowCount = 4;
        this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.layout.Size = new System.Drawing.Size(792, 437);
        this.layout.TabIndex = 0;
        // 
        // text_input
        // 
        this.text_input.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.text_input.Location = new System.Drawing.Point(442, 153);
        this.text_input.Name = "text_input";
        this.text_input.Size = new System.Drawing.Size(142, 20);
        this.text_input.TabIndex = 2;
        this.text_input.TextChanged += new System.EventHandler(this.text_input_TextChanged);
        // 
        // lbl_result
        // 
        this.lbl_result.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.lbl_result.AutoSize = true;
        this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
        this.lbl_result.Location = new System.Drawing.Point(513, 263);
        this.lbl_result.Name = "lbl_result";
        this.lbl_result.Size = new System.Drawing.Size(0, 18);
        this.lbl_result.TabIndex = 5;
        // 
        // lbl_result_title
        // 
        this.lbl_result_title.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.lbl_result_title.AutoSize = true;
        this.lbl_result_title.Location = new System.Drawing.Point(245, 266);
        this.lbl_result_title.Name = "lbl_result_title";
        this.lbl_result_title.Size = new System.Drawing.Size(62, 13);
        this.lbl_result_title.TabIndex = 4;
        this.lbl_result_title.Text = "Результат:";
        // 
        // lbl_input
        // 
        this.lbl_input.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.lbl_input.AutoSize = true;
        this.lbl_input.Location = new System.Drawing.Point(235, 157);
        this.lbl_input.Name = "lbl_input";
        this.lbl_input.Size = new System.Drawing.Size(83, 13);
        this.lbl_input.TabIndex = 1;
        this.lbl_input.Text = "Введите текст:";
        // 
        // Task3Page
        // 
        this.Controls.Add(this.layout);
        this.MinimumSize = new System.Drawing.Size(400, 225);
        this.Name = "Task3Page";
        this.Size = new System.Drawing.Size(792, 437);
        this.layout.ResumeLayout(false);
        this.layout.PerformLayout();
        this.ResumeLayout(false);
    }
}
}