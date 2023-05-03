using System.Collections.Generic;

namespace PrimeNumber.Models
{
  public class PrimeGenerator
  {
    public PrimeGenerator(int stop)
    {
      
    }
  }
}


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