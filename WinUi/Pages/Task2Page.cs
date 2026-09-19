using System;
using System.Windows.Forms;
using FunctionsTask2 = Task2.Functions;

namespace WinUi.Pages {
public partial class Task2Page : UserControl {
  public Task2Page() {
    InitializeComponent();
  }

  private void text_input_TextChanged(object sender, EventArgs e) {
    var sentence = FunctionsTask2.ModifySentence(
      ((TextBox)sender).Text
    ) ?? "Введено неверное значение!";

    text_result.Text = string.Empty;
    
    foreach (var word in sentence.Split('\n')) {
      text_result.Text += word + Environment.NewLine;
    }
  }
}
}