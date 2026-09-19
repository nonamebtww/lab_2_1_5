using System;
using System.Windows.Forms;
using FunctionsTask1 = Task1.Functions;

namespace WinUi.Pages {
public partial class Task1Page : UserControl {
  public Task1Page() {
    InitializeComponent();
  }

  private void word_textbox_TextChanged(object sender, EventArgs e) {
    lbl_result.Text = FunctionsTask1.ReplaceFirstAndLastLetters(
      ((TextBox)sender).Text
    ) ?? "Неверное значение!";
  }
}
}