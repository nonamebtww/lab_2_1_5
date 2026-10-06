using FunctionsTask2 = Task2.Functions;

namespace Task2Console {
public class Ui {
  public static void Task2Ui() {
    System.Console.Write("Введите последовательность слов: ");

    var result = FunctionsTask2.ModifySentence(
      System.Console.ReadLine() ?? string.Empty
    );

    if (string.IsNullOrEmpty(result)) {
      System.Console.WriteLine("Введено неверное значение!");
      return;
    }

    System.Console.WriteLine($"Результат: {result}");
  }
}
}