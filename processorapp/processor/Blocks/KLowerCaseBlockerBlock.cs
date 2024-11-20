namespace processor.Blocks;

public static class KLowerCaseBlockerBlock {
  public static Func<char, string> BlockLowerCaseK = CharacterBlocker.BlockCharacter('k');
}
