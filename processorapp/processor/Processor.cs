namespace processor;

public static class Processor {
  public static string ProcessText(string text, params Func<char, string>[] blocks) {
    static string ApplyBlock(string inputText, Func<char, string> block) {
      return string.Concat(inputText.Select(character => block(character)));
    }

    return blocks.Aggregate(text, (currentText, block) => ApplyBlock(currentText, block));
  }
}
