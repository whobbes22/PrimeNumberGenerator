using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumber.Models;
using System.Collections.Generic;
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
      Assert.AreEqual(typeof(PrimeGenerator),num.GetType());
    }
    [TestMethod]
    public void PrimeList_CreateList_List()
    {
      PrimeGenerator num = new PrimeGenerator(10);
      // make list
      List<int> pList = num.CreateList();
      List<int> testList = new List<int> {1,2,3,4,5,6,7,8,9,10};

      for(int i = 0; i <=9 ;i++) 
      {
        Assert.AreEqual(pList[i], testList[i]); 
      }
    }

    [TestMethod]
    public void RemoveList_RemoveNonPrimeNumbers_List()
    {
      PrimeGenerator num = new PrimeGenerator(10);
      List<int> pList = num.CreateList();
      pList = num.KeepPrimeNumbers(pList);
      List<int> testList = new List<int> {2,3,5,7};
      Assert.AreEqual(pList[2],testList[2]);
    }

    [TestMethod]
    public void RemoveList_edgeCase2_List()
    {
      PrimeGenerator num = new PrimeGenerator(2);
      List<int> pList = num.CreateList();
      pList = num.KeepPrimeNumbers(pList);
      List<int> testList = new List<int> {2};
      Assert.AreEqual(pList[0],testList[0]);
    }

    [TestMethod]
    public void RemoveList_check100_List()
    {
      PrimeGenerator num = new PrimeGenerator(100);
      List<int> pList = num.CreateList();
      pList = num.KeepPrimeNumbers(pList);
      List<int> testList = new List<int> {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};

      for(int i = 0; i < pList.Count;i++){
        Assert.AreEqual(pList[i],testList[i]);
      }
      // foreach(int element in pList)
      // {
      //   Assert.AreEqual(pList[element],testList[element]);
      // }
      
    }

  }
}

