using FunctionsTask3 = Task3.Functions;

namespace Task3Console {
public class Ui {
  public static void Task3Ui() {
    System.Console.Write("Введите текст: ");

    var result = FunctionsTask3.ReplaceUpperWithLower(
      System.Console.ReadLine() ?? string.Empty
    );

    System.Console.WriteLine($"Результат: {result}");
  }
}
}