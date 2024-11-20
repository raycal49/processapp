namespace processor.Blocks;

public static class CharacterBlocker {
  public static Func<char, string> BlockCharacter(char blockedChar) {
    return (char charInput) => charInput == blockedChar ? string.Empty : charInput.ToString();
  }
}
