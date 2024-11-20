namespace processor.Blocks;

public static class ZUpperCaseBlockerBlock {
  public static Func<char, string> BlockUpperCaseZ = CharacterBlocker.BlockCharacter('Z');
}
