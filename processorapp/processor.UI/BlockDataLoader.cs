﻿using System.Runtime.InteropServices;

namespace processor.UI;

public static class BlockDataLoader {
  public static string GetBlocksConfigPath() {
    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
    string assignmentForDirectory = "";

    if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
      assignmentForDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"../../../../.."));
    }
    else {
      assignmentForDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\..\.."));
    }

    string blocksConfigPath = Path.Combine(assignmentForDirectory, "data", "blocks.config");
    
    return blocksConfigPath;
  }

  public static string[] LoadBlockNames(string configFilePath) {
    if (!File.Exists(configFilePath)) {
      Console.WriteLine($"Configuration file not found at: {configFilePath}");
      Environment.Exit(1);
    }

    var blockNames = File.ReadAllLines(configFilePath);

    return blockNames;
  }

  public static List<Func<char, string>> LoadBlocks(IEnumerable<string> blockNames) {
    var blocks = new List<Func<char, string>>();

    foreach (var blockName in blockNames) {
      blocks.Add(BlockSelector.SelectBlocks(blockName));
    }

    return blocks;
  }
}
