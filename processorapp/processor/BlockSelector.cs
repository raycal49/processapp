﻿using System.Reflection;

namespace processor;

public static class BlockSelector {
  public static Func<char, string> SelectBlocks(string block) {
    var blockType = Type.GetType($"processor.Blocks.{block}");

    var blockMethod = blockType.GetMethods(BindingFlags.Public|BindingFlags.Static).FirstOrDefault();

    if (blockMethod != null) {
      return (Func<char, string>)Delegate.CreateDelegate(typeof(Func<char, string>), blockMethod);
    }

    var field = blockType.GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault();

    return (Func<char, string>)field.GetValue(null);
  }
}
