using processor.Blocks;
using static processor.BlockSelector;

namespace processor.Tests;

public class BlockSelectorTests {
  [Test]
  public void SelectBlocks_TakesInStringLowerCaseBlock_ReturnsConvertToLowerFunction() {
    var actionResult = SelectBlocks("LowerCaseBlock");

    Assert.AreEqual(LowerCaseBlock.ConvertToLower, actionResult);
  }

  [Test]
  public void SelectBlocks_TakesInStringUpperCaseBlock_ReturnsConvertToUpperFunction() {
    var actionResult = SelectBlocks("UpperCaseBlock");

    Assert.AreEqual(UpperCaseBlock.ConvertToUpper, actionResult);
  }

  [Test]
  public void SelectBlocks_TakesInStringZLowerCaseBlockerBlock_ReturnsBlockLowerCaseZFunction() {
    var actionResult = SelectBlocks("ZLowerCaseBlockerBlock");

    Assert.AreEqual(ZLowerCaseBlockerBlock.BlockLowerCaseZ, actionResult);
  }

  [Test]
  public void SelectBlocks_TakesInStringZUpperCaseBlockerBlock_ReturnsBlockUpperCaseZFunction() {
    var actionResult = SelectBlocks("ZUpperCaseBlockerBlock");

    Assert.AreEqual(ZUpperCaseBlockerBlock.BlockUpperCaseZ, actionResult);
  }

  [Test]
  public void SelectBlocks_TakesInStringKLowerCaseBlockerBlock_ReturnsBlockLowerCaseKFunction() {
    var actionResult = SelectBlocks("KLowerCaseBlockerBlock");

    Assert.AreEqual(KLowerCaseBlockerBlock.BlockLowerCaseK, actionResult);
  }

  [Test]
  public void SelectBlocks_TakesInStringMultiplierBlock_ReturnsDoubleCharacterFunction() {
    var actionResult = SelectBlocks("MultiplierBlock");

    Assert.AreEqual(MultiplierBlock.DoubleCharacter, actionResult);
  }
}
