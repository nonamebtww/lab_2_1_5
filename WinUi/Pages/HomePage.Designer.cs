using System.ComponentModel;

namespace WinUi.Pages {
partial class HomePage {
  /// <summary> 
  /// Required designer variable.
  /// </summary>
  private IContainer components = null;

  /// <summary> 
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  #region Component Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
    this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
    this.lbl_welcome = new System.Windows.Forms.Label();
    this.tableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    // 
    // tableLayoutPanel1
    // 
    this.tableLayoutPanel1.AutoSize = true;
    this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.tableLayoutPanel1.ColumnCount = 1;
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
    this.tableLayoutPanel1.Controls.Add(this.lbl_welcome, 0, 0);
    this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
    this.tableLayoutPanel1.Name = "tableLayoutPanel1";
    this.tableLayoutPanel1.RowCount = 1;
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
    this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 225);
    this.tableLayoutPanel1.TabIndex = 0;
    // 
    // lbl_welcome
    // 
    this.lbl_welcome.Dock = System.Windows.Forms.DockStyle.Fill;
    this.lbl_welcome.Location = new System.Drawing.Point(3, 0);
    this.lbl_welcome.Name = "lbl_welcome";
    this.lbl_welcome.Size = new System.Drawing.Size(394, 225);
    this.lbl_welcome.TabIndex = 0;
    this.lbl_welcome.Text = "Выберите одно из задание, в левом верхнем углу!";
    this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // HomePage
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.AutoSize = true;
    this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.Controls.Add(this.tableLayoutPanel1);
    this.MinimumSize = new System.Drawing.Size(400, 225);
    this.Name = "HomePage";
    this.Size = new System.Drawing.Size(400, 225);
    this.tableLayoutPanel1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
  private System.Windows.Forms.Label lbl_welcome;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

  #endregion
}
}