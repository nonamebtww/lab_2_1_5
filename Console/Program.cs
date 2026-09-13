using System;

namespace Console {
internal class Program {
  
  #region Task 1

  // Поменять в слове первую и последнюю буквы
  private static string Task1(string word) {
    if (string.IsNullOrEmpty(word) || word.Length < 2) {
      return word;
    }

    var chars = word.ToCharArray();

    (chars[0], chars[chars.Length - 1]) = (chars[chars.Length - 1], chars[0]);

    return new string(chars);
  }

  private static void Task1Ui() {
    System.Console.Write("Введите слово: ");
    var word = System.Console.ReadLine();

    var result = Task1(word);

    System.Console.WriteLine("Результат: " + result);
  }

  #endregion

  #region Task 2

  // Удалить первую и последнюю буквы у слов,
  // отличных от последнего слова
  private static string Task2(string text) {
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

  // Заменить большие латинские буквы на маленькие
  private static void Task2Ui() {
    System.Console.Write("Введите последовательность слов: ");
    var text = System.Console.ReadLine();

    var result = Task2(text);

    System.Console.WriteLine("Результат:");
    System.Console.WriteLine(result);
  }

  #endregion

  #region Task 3

  private static string Task3(string text) {
    var chars = text.ToCharArray();

    for (var i = 0; i < chars.Length; i++)
      if (chars[i] >= 'A' && chars[i] <= 'Z') {
        chars[i] = (char)(chars[i] + ('a' - 'A'));
      }

    return new string(chars);
  }

  private static void Task3Ui() {
    System.Console.Write("Введите текст: ");
    var text = System.Console.ReadLine();

    var result = Task3(text);

    System.Console.WriteLine("Результат: " + result);
  }

  #endregion
  
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
      
      var raw_action = System.Console.ReadLine();

      if (!int.TryParse(raw_action, out var action)) {
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