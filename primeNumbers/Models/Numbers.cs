using System;
using System.Collections.Generic;

namespace PrimeNumber.Models
{
  public class PrimeGenerator
  {
    private int _stopIndex;
    private List<int> _primeList = new List<int>{};
    public PrimeGenerator(int stop)
    {
      _stopIndex = stop;
    }

    public List<int> CreateList()
    {
      List<int> numberList = new List<int> {};
      for(int i = 1; i <= _stopIndex; i++)
      {
        numberList.Add(i);
        //Console.WriteLine(i);
      }
      return numberList;
    }

    public List<int> KeepPrimeNumbers(List<int> theList)
    {
      // 
      theList.Remove(1);

      if (_stopIndex == 2)
      {
        //return list with 2
        //return list with 2
      }

      int index = 2;

    // 1- 10
    // input is 3
    // get rid of 6 9 but DO NOT GET RID OF 3

    // for loop, 
    // the plan was to count the amount of things in the list
      while(index < _stopIndex)
      {
        if(theList.Contains(index))
        {
          // i = 4; 4< 10; 3, 6,9..; 2, 4, 6, 8...;

          // bool doNotDelete = true;
          // really get rid of the first


          //loop 2 skil 2 go to 4
          //loop 3 skip 3 go to 6

        //   2 cross all 2*  ; 3 all *3 ;4 index ++
          for(int i = 2 * index; i <= _stopIndex; i = i + index)

          {
            // if(doNotDelete){
            //   doNotDelete = false;
            // }    <-get rid of the first loop which means the first number to be kept
            // else{
            Console.WriteLine($" i to be removed from list {i}, current multiple of {index}");
            theList.Remove(i);          
          }
        }
        index++;
      }

      foreach(int element in theList)
      {
        Console.WriteLine($"Current prime numbers in list {element}");
      }
      return theList;
    }
  }
}


// list of prime numbers under 100
//2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97

// current output
//2, 3, 4, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 


/*

finding prime numbers up to given input


2 loops

outer Loop controls index of number we are currently checking

inner loop all numbers from 2 to current number? 
if % and previous numbers = 0 they are a direct factor exit loop that and continue to next number

could take a long time especially if looking at very large numbers.

1 and 2 will be hard coded as exceptions


list apporach
generate all numbers to desiered input into a list.
remove all remiaining multiples of each number until it is greater then the actuall number.
go down the list?

ex 10

list 1,2,3,4,5,6,7,8,9,10

2 will remove all even
1,2,3,5,7,9
then 3 will remove 9 so list will get smaller

*/