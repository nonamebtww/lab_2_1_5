namespace WinUi.Pages {
partial class Task2Page {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TableLayoutPanel layout;
    private System.Windows.Forms.Label lbl_input;
    private System.Windows.Forms.TextBox text_input;
    private System.Windows.Forms.TextBox text_result;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task2Page));
        this.layout = new System.Windows.Forms.TableLayoutPanel();
        this.text_input = new System.Windows.Forms.TextBox();
        this.text_result = new System.Windows.Forms.TextBox();
        this.lbl_input = new System.Windows.Forms.Label();
        this.lbl_task = new System.Windows.Forms.Label();
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
        this.layout.Controls.Add(this.text_input, 2, 2);
        this.layout.Controls.Add(this.text_result, 1, 3);
        this.layout.Controls.Add(this.lbl_input, 1, 2);
        this.layout.Controls.Add(this.lbl_task, 0, 0);
        this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
        this.layout.Location = new System.Drawing.Point(0, 0);
        this.layout.Name = "layout";
        this.layout.Padding = new System.Windows.Forms.Padding(20);
        this.layout.RowCount = 5;
        this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.56522F));
        this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04831F));
        this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        this.layout.Size = new System.Drawing.Size(400, 225);
        this.layout.TabIndex = 0;
        // 
        // text_input
        // 
        this.text_input.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.text_input.Location = new System.Drawing.Point(203, 102);
        this.text_input.Name = "text_input";
        this.text_input.Size = new System.Drawing.Size(102, 20);
        this.text_input.TabIndex = 2;
        this.text_input.TextChanged += new System.EventHandler(this.text_input_TextChanged);
        // 
        // text_result
        // 
        this.layout.SetColumnSpan(this.text_result, 2);
        this.text_result.Dock = System.Windows.Forms.DockStyle.Fill;
        this.text_result.Location = new System.Drawing.Point(95, 133);
        this.text_result.Multiline = true;
        this.text_result.Name = "text_result";
        this.text_result.ReadOnly = true;
        this.text_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.text_result.Size = new System.Drawing.Size(210, 31);
        this.text_result.TabIndex = 5;
        // 
        // lbl_input
        // 
        this.lbl_input.AutoSize = true;
        this.lbl_input.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lbl_input.Location = new System.Drawing.Point(95, 94);
        this.lbl_input.Name = "lbl_input";
        this.lbl_input.Size = new System.Drawing.Size(102, 36);
        this.lbl_input.TabIndex = 1;
        this.lbl_input.Text = "Введите последовательность слов:";
        this.lbl_input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lbl_task
        // 
        this.layout.SetColumnSpan(this.lbl_task, 4);
        this.lbl_task.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lbl_task.Location = new System.Drawing.Point(23, 20);
        this.lbl_task.Name = "lbl_task";
        this.layout.SetRowSpan(this.lbl_task, 2);
        this.lbl_task.Size = new System.Drawing.Size(354, 74);
        this.lbl_task.TabIndex = 6;
        this.lbl_task.Text = resources.GetString("lbl_task.Text");
        this.lbl_task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Task2Page
        // 
        this.AutoSize = true;
        this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.Controls.Add(this.layout);
        this.MinimumSize = new System.Drawing.Size(400, 225);
        this.Name = "Task2Page";
        this.Size = new System.Drawing.Size(400, 225);
        this.layout.ResumeLayout(false);
        this.layout.PerformLayout();
        this.ResumeLayout(false);
    }
    private System.Windows.Forms.Label lbl_task;
}
}