﻿using processor.Blocks;
using static processor.Processor;

namespace processor.Tests;

public class ProcessorTests {
  [Test]
  public void ProcessText_TakesInStringAndAppliesNoBlocks_ReturnsSameString() {
    var expectedResult = ProcessText("test");

    Assert.AreEqual("test", expectedResult);
  }

  [Test]
  public void ProcessText_TakesInStringAndAppliesLowerCaseBlock_ReturnsLowerCaseString() {
    var expectedResult = ProcessText("TEST", LowerCaseBlock.ConvertToLower);

    Assert.AreEqual("test", expectedResult);
  }

  [Test]
  public void
  ProcessText_TakesInStringAndAppliesUpperCaseBlock_ReturnsUpperCaseString() {
    var expectedResult = ProcessText("test", UpperCaseBlock.ConvertToUpper);

    Assert.AreEqual("TEST", expectedResult);
  }

  [Test]
  public void
  ProcessText_TakesInStringAndAppliesMultiplierBlock_ReturnsStringWithLettersRepeated() {
    var expectedResult = ProcessText("test", MultiplierBlock.DoubleCharacter);

    Assert.AreEqual("tteesstt", expectedResult);
  }

  [Test]
  public void
  ProcessText_TakesInStringAndAppliesLowerCaseAndUpperCaseBlock_ReturnsStringWithLowerCaseAndUpperCaseLetters() {
    var expectedResult = ProcessText("tEsT", UpperCaseBlock.ConvertToUpper, LowerCaseBlock.ConvertToLower);

    Assert.AreEqual("test", expectedResult);
  }

  [Test]
  public void
  ProcessText_TakesInString_abzde_AndAppliesUppercaseAndZBlock_ReturnsStringWithUppercaseAndZBlocked() {
    var expectedResult = ProcessText("abzde", UpperCaseBlock.ConvertToUpper, ZUpperCaseBlockerBlock.BlockUpperCaseZ);

    Assert.AreEqual("ABDE", expectedResult);
  }

  [Test]
  public void
  ProcessText_TakesInsString_abzde_AndAppliesZBlockAndUppercase_ReturnsStringWithZBlockedAndUppercase() {
    var expectedResult = ProcessText("abzde", ZUpperCaseBlockerBlock.BlockUpperCaseZ, UpperCaseBlock.ConvertToUpper);

    Assert.AreEqual("ABZDE", expectedResult);
  }

  [Test]
  public void
  ProcessText_TakesInString_abzde_AndAppliesUpperAndMultiplierBlock_ReturnsStringWithUppercaseAndMultiplied() {
    var expectedResult = ProcessText("abzde", UpperCaseBlock.ConvertToUpper, MultiplierBlock.DoubleCharacter);

    Assert.AreEqual("AABBZZDDEE", expectedResult);
  }

  [Test]
  public void
  ProcessText_TakesInString_abzde_AndAppliesZAndUppercaseAndMultiplierBlock_ReturnsStringWithZBlockedAndUppercaseAndMultiplied() {
    var expectedResult = ProcessText("abzde", ZUpperCaseBlockerBlock.BlockUpperCaseZ, UpperCaseBlock.ConvertToUpper, MultiplierBlock.DoubleCharacter);

    Assert.AreEqual("AABBZZDDEE", expectedResult);
  }
}
