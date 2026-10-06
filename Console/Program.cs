namespace Console {
internal class Program {
  
  private static void Main(string[] args) {
    while (true) {
      System.Console.Clear();
      
      System.Console.Write(
        "1. Задание 1\n" +
        "2. Задание 2\n" +
        "3. Задание 3\n" +
        "0. Выход\n" +
        "Выберите действие: "
      );

      switch (System.Console.ReadLine()) {
        case "1":
          Task1Console.Ui.Task1Ui();
          break;
        case "2":
          Task2Console.Ui.Task2Ui();
          break;
        case "3":
          Task3Console.Ui.Task3Ui();
          break;
        case "0":
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