using static processor.Blocks.LowerCaseBlock;

namespace processor.Tests;

public class LowerCaseBlockTests { 
  [Test]
  public void ConvertToLower_TakesInLowerCaseChar_ReturnsLowerCaseChar() { 
    var expectedResult = ConvertToLower('a');

    Assert.AreEqual("a", expectedResult);
  }

  [Test]
  public void ConvertToLower_TakesInUpperCaseChar_ReturnsLowerCaseChar() { 
    var expectedResult = ConvertToLower('A');

    Assert.AreEqual("a", expectedResult);
  }

  [Test]
  public void ConvertToLower_TakesInSpecialChar_ReturnsSpecialChar() { 
    var expectedResult = ConvertToLower('!');

    Assert.AreEqual("!", expectedResult);
  }
}
