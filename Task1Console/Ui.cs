using FunctionsTask1 = Task1.Functions;

namespace Task1Console {
public class Ui {
  public static void Task1Ui() {
    System.Console.Write("Введите слово: ");

    var result = FunctionsTask1.ReplaceFirstAndLastLetters(
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