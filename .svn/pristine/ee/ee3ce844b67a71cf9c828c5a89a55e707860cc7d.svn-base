using static processor.Blocks.UpperCaseBlock;

namespace processor.Tests;

public class UpperCaseBlockTests { 
  [Test]
  public void Canary() {
    Assert.True(true);
  }

  [Test]
  public void ConvertToUpper_TakesInLowerCaseChar_ReturnsUpperCaseChar() { 
    var expectedResult = ConvertToUpper('a');

    Assert.AreEqual("A", expectedResult);
  }

  [Test]
  public void ConvertToUpper_TakesInUpperCaseChar_ReturnsUpperCaseChar() { 
    var expectedResult = ConvertToUpper('A');

    Assert.AreEqual("A", expectedResult);
  }

  [Test]
  public void ConvertToUpper_TakesInSpecialChar_ReturnsSpecialChar() { 
    var expectedResult = ConvertToUpper('!');

    Assert.AreEqual("!", expectedResult);
  }
}
