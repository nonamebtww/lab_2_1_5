namespace Task3 {
public static class Functions {
  // Заменить большие латинские буквы на маленькие
  public static string ReplaceUpperWithLower(string text) {
    var chars = text.ToCharArray();

    for (var i = 0; i < chars.Length; i++)
      if (chars[i] >= 'A' && chars[i] <= 'Z') {
        chars[i] = (char)(chars[i] + ('a' - 'A'));
      }

    return new string(chars);
  }

}
}