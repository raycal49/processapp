using static processor.Blocks.MultiplierBlock;

namespace processor.Tests;

public class MultiplierBlockTests {
  [Test]
  public void DoubleCharacter_TakesInLowerCaseChar_ReturnsTwoOfSameLowerCaseChar() {
    var expectedResult = DoubleCharacter('a');

    CollectionAssert.AreEqual("aa", expectedResult);
  }

  [Test]
  public void DoubleCharacter_TakesInUpperCaseChar_ReturnsTwoOfSameUpperCaseChar() {
    var expectedResult = DoubleCharacter('A');

    CollectionAssert.AreEqual("AA", expectedResult);
  }

  [Test]
  public void DoubleCharacter_TakesInSpecialChar_ReturnsTwoOfSameSpecialChar() {
    var expectedResult = DoubleCharacter('!');

    CollectionAssert.AreEqual("!!", expectedResult);
  }
}
