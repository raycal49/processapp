namespace processor.Blocks;

public static class UpperCaseBlock { 
  public static string ConvertToUpper(char character) { 
    return char.ToUpper(character).ToString();
  }
}
