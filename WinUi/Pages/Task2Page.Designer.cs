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
        this.layout = new System.Windows.Forms.TableLayoutPanel();
        this.text_input = new System.Windows.Forms.TextBox();
        this.text_result = new System.Windows.Forms.TextBox();
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
        this.layout.Controls.Add(this.text_input, 2, 2);
        this.layout.Controls.Add(this.text_result, 1, 3);
        this.layout.Controls.Add(this.lbl_input, 1, 2);
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
        this.layout.Size = new System.Drawing.Size(736, 454);
        this.layout.TabIndex = 0;
        // 
        // text_input
        // 
        this.text_input.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.text_input.Location = new System.Drawing.Point(403, 216);
        this.text_input.Name = "text_input";
        this.text_input.Size = new System.Drawing.Size(135, 20);
        this.text_input.TabIndex = 2;
        this.text_input.TextChanged += new System.EventHandler(this.text_input_TextChanged);
        // 
        // text_result
        // 
        this.layout.SetColumnSpan(this.text_result, 2);
        this.text_result.Dock = System.Windows.Forms.DockStyle.Fill;
        this.text_result.Location = new System.Drawing.Point(162, 270);
        this.text_result.Multiline = true;
        this.text_result.Name = "text_result";
        this.text_result.ReadOnly = true;
        this.text_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.text_result.Size = new System.Drawing.Size(410, 77);
        this.text_result.TabIndex = 5;
        // 
        // lbl_input
        // 
        this.lbl_input.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.lbl_input.AutoSize = true;
        this.lbl_input.Location = new System.Drawing.Point(169, 220);
        this.lbl_input.Name = "lbl_input";
        this.lbl_input.Size = new System.Drawing.Size(188, 13);
        this.lbl_input.TabIndex = 1;
        this.lbl_input.Text = "Введите последовательность слов:";
        // 
        // Task2Page
        // 
        this.Controls.Add(this.layout);
        this.Name = "Task2Page";
        this.Size = new System.Drawing.Size(736, 454);
        this.layout.ResumeLayout(false);
        this.layout.PerformLayout();
        this.ResumeLayout(false);
    }
}
}