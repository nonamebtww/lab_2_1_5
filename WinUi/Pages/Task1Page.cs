using System;
using System.Windows.Forms;

namespace WinUi.Pages {
public partial class Task1Page : UserControl {
  public Task1Page() {
    InitializeComponent();
  }

  private string Task1(string word) {
    if (string.IsNullOrEmpty(word) || word.Length < 2) {
      return word;
    }

    var chars = word.ToCharArray();

    (chars[0], chars[chars.Length - 1]) = (chars[chars.Length - 1], chars[0]);

    return new string(chars);
  }

  private void word_textbox_TextChanged(object sender, EventArgs e) {
    lbl_result.Text = Task1(
      ((TextBox)sender).Text
    );
  }
}
}