using System;
using System.Text;

namespace Task2 {
public static class Functions {
  // Дана последовательность, содержащая от 2 до 30 слов, в каждом из
  // которых от 2 до 10 латинских букв; между соседними словами -- не
  // менее одного пробела, за последним словом -- точка. Напечатать все
  // слова, отличные от последнего слова, предварительно преобразовав
  // каждое из них по следующему правилу: удалить из слова первую и
  // последнюю буквы;
  public static string ModifySentence(string text) {
    var words = text.Replace(".", " ").Split(
      new[] {
        ' '
      },
      StringSplitOptions.RemoveEmptyEntries
    );

    if (words.Length < 2) {
      return null;
    }

    var last_word = words[words.Length - 1];
    var result = new StringBuilder();

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

      result.Append($"{word}\n");
    }

    return result.ToString();
  }
}
}