namespace processor.UI;

public static class TextProcessor {
  public static string GetInputText() {
    Console.WriteLine("""
    
    Enter text to process: 
    """);
    return Console.ReadLine() ?? string.Empty;
  }

  public static string ProcessInputText(string inputText, IEnumerable<Func<char, string>> blocks) {
    return Processor.ProcessText(inputText, blocks.ToArray());
  }
}
