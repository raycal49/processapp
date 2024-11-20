using static processor.Blocks.ZLowerCaseBlockerBlock;

namespace processor.Tests;

public class ZLowerCaseBlockerBlockTests {
  [Test]
  public void BlockLowerCaseZ_TakesInLowerCaseNonZChar_ReturnsLowerCaseNonZString() {
    var expectedResult = BlockLowerCaseZ('a');

    Assert.AreEqual("a", expectedResult);
  }

  [Test]
  public void BlockLowerCaseZ_TakesInLowerCaseZ_ReturnsEmptyString() {
    var expectedResult = BlockLowerCaseZ('z');

    Assert.AreEqual("", expectedResult);
  }

  [Test]
  public void BlockLowerCaseZ_TakesInUpperCaseZ_ReturnsUpperCaseZString() {
    var expectedResult = BlockLowerCaseZ('Z');

    Assert.AreEqual("Z", expectedResult);
  }

  [Test]
  public void BlockLowerCaseZ_TakesInSpecialChar_ReturnsSpecialString() {
    var expectedResult = BlockLowerCaseZ('!');

    Assert.AreEqual("!", expectedResult);
  }
}
