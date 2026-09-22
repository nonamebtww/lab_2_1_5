namespace Task3 {
public static class Functions {
  // Заменить большие латинские буквы на маленькие
  public static string ReplaceUpperWithLower(string text) {
    var chars = text.ToCharArray();

    for (var i = 0; i < text.Length; i++)
      if (text[i] >= 'A' && chars[i] <= 'Z') {
        chars[i] = (char)(chars[i] + ('a' - 'A'));
      }

    return new string(chars);
  }

}
}