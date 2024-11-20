using static processor.UI.BlockDataLoader;
using static processor.UI.TextProcessor;

namespace processor.UI;

class CharacterBlockApp {
  static void Main(string[] args) {
    Console.WriteLine("Welcome to the Processor App!");

    var blocksConfigPath = GetBlocksConfigPath();
    var blockNames = LoadBlockNames(blocksConfigPath);
    var blocks = LoadBlocks(blockNames);

    Console.WriteLine("""

    Blocks to be applied:
    """);

    foreach (var blockName in blockNames) {
      Console.WriteLine($"- {blockName}");
    }

    string inputText = GetInputText();

    if (string.IsNullOrEmpty(inputText)) {
      Console.WriteLine("No text entered.");
      return;
    }

    string result = ProcessInputText(inputText, blocks);

    Console.WriteLine($"""

    Processed text: {result}
    """);
  }
}
