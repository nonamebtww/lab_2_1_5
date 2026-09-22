namespace Task1 {
public static class Functions {
  // Поменять в слове первую и последнюю буквы
  public static string ReplaceFirstAndLastLetters(string word) {
    if (string.IsNullOrEmpty(word) || word.Length < 2 || word.Contains(" ")) {
      return null;
    }

    var chars = word.ToCharArray();

    (chars[0], chars[chars.Length - 1]) = (chars[chars.Length - 1], chars[0]);

    return new string(chars);
  }
}
}