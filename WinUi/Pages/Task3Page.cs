using System;
using System.Windows.Forms;

namespace WinUi.Pages {
public partial class Task3Page : UserControl {
  public Task3Page() {
    InitializeComponent();
  }

  private string Task3(string text) {
    var chars = text.ToCharArray();

    for (var i = 0; i < chars.Length; i++)
      if (chars[i] >= 'A' && chars[i] <= 'Z') {
        chars[i] = (char)(chars[i] + ('a' - 'A'));
      }

    return new string(chars);
  }

  private void text_input_TextChanged(object sender, EventArgs e) {
    lbl_result.Text = Task3(
      ((TextBox)sender).Text
    );
  }
}
}