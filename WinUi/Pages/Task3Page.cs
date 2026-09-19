using System;
using System.Windows.Forms;
using FunctionsTask3 = Task3.Functions;

namespace WinUi.Pages {
public partial class Task3Page : UserControl {
  public Task3Page() {
    InitializeComponent();
  }

  private void text_input_TextChanged(object sender, EventArgs e) {
    lbl_result.Text = FunctionsTask3.ReplaceUpperWithLower(
      ((TextBox)sender).Text
    );
  }
}
}