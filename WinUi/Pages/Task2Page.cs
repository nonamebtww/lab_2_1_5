using System;
using System.Windows.Forms;

namespace WinUi.Pages {
public partial class Task2Page : UserControl {
  public Task2Page() {
    InitializeComponent();
  }

  private string Task2(string text) {
    var words = text.TrimEnd('.').Split(
      new[] {
        ' '
      },
      StringSplitOptions.RemoveEmptyEntries
    );

    if (words.Length < 2) {
      return string.Empty;
    }

    var last_word = words[words.Length - 1];
    var result = string.Empty;

    for (var i = 0; i < words.Length - 1; i++) {
      if (words[i] == last_word) {
        continue;
      }

      if (words[i].Length <= 2) {
        continue;
      }

      var word = words[i].Substring(
        1,
        words[i].Length - 2
      );

      result += word + Environment.NewLine;
    }

    return result.TrimEnd();
  }

  private void text_input_TextChanged(object sender, EventArgs e) {
    text_result.Text = Task2(
      ((TextBox)sender).Text
    );
  }
}
}