using FunctionsTask1 = Task1.Functions;
using FunctionsTask2 = Task2.Functions;
using FunctionsTask3 = Task3.Functions;

namespace Console {
internal class Program {

  private static void Task1Ui() {
    System.Console.Write("Введите слово: ");

    var result = FunctionsTask1.ReplaceFirstAndLastLetters(
      System.Console.ReadLine() ?? string.Empty
    );
    
    if (result == null) {
      System.Console.WriteLine("Введено неверное значение!");
      return;
    }

    System.Console.WriteLine($"Результат: {result}");
  }

  private static void Task2Ui() {
    System.Console.Write("Введите последовательность слов: ");

    var result = FunctionsTask2.ModifySentence(
      System.Console.ReadLine() ?? string.Empty
    );

    if (result == null) {
      System.Console.WriteLine("Введено неверное значение!");
      return;
    }

    System.Console.WriteLine($"Результат: {result}");
  }

  private static void Task3Ui() {
    System.Console.Write("Введите текст: ");

    var result = FunctionsTask3.ReplaceUpperWithLower(
      System.Console.ReadLine() ?? string.Empty
    );

    System.Console.WriteLine($"Результат: {result}");
  }
  
  private static void Main(string[] args) {
    while (true) {
      System.Console.Clear();
      
      System.Console.Write(
        "Выберите действие\n" +
        "1. Задание 1\n" +
        "2. Задание 2\n" +
        "3. Задание 3\n" +
        "0. Выход\n" +
        "Выбор: "
      );
      
      if (!int.TryParse(System.Console.ReadLine(), out var action)) {
        System.Console.WriteLine("Введно неверное значение!");
        continue;
      }

      switch (action) {
        case 1:
          Task1Ui();
          break;
        case 2:
          Task2Ui();
          break;
        case 3:
          Task3Ui();
          break;
        case 0:
          return;
        default:
          System.Console.WriteLine("Выбрано неверное действие!");
          break;
      }
      
      System.Console.WriteLine("Нажмите любую клавишу для продолженния...");
      System.Console.ReadKey();
    }
  }
}
}