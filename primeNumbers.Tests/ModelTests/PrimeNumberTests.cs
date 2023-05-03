using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumber.Models;
using System;

namespace PrimeNumber.Tests
{
  [TestClass]
  public class NumberTests
  {
    [TestMethod]
    public void PrimeConstructor_CreateInstanceOfPrimeGenerator_PrimeGenerator()
    {
      PrimeGenerator num = new PrimeGenerator(300);
    }
  }
}