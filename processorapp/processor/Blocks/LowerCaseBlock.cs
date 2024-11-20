namespace processor.Blocks;

public static class LowerCaseBlock { 
  public static string ConvertToLower(char character) { 
    return char.ToLower(character).ToString();
  }
}
