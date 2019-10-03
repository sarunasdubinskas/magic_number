using System;
using System.Collections.Generic;
namespace Magic_number
{
    class Program
    {
        static void Main()
        {
            int magic_number;

            magic_number = FindMagicNumber();
            PrintResults(magic_number);

            Console.ReadKey();
        }

        private static void PrintResults(int magic_number)
        {
            Console.WriteLine("Magic number is:" + magic_number);
            Console.WriteLine(magic_number + "*2 = " + (magic_number * 2));
            Console.WriteLine(magic_number + "*3 = " + (magic_number * 3));
            Console.WriteLine(magic_number + "*4 = " + (magic_number * 4));
            Console.WriteLine(magic_number + "*5 = " + (magic_number * 5));
            Console.WriteLine(magic_number + "*6 = " + (magic_number * 6));
        }

        private static int FindMagicNumber()
        {
            bool isAllDifferent = false;
            int magic_number = -1;

            for (int i = 102345; i < 165432; i++)
            {
                isAllDifferent = CheckIfAllNumbersIsDifferent(Convert.ToString(i));

                if (isAllDifferent)
                {
                    if (
                        (CheckIfAllNumbersIsDifferent(Convert.ToString(i * 2)) && CheckIfHasSameNumbers(Convert.ToString(i * 2), Convert.ToString(i))) &&
                        (CheckIfAllNumbersIsDifferent(Convert.ToString(i * 3)) && CheckIfHasSameNumbers(Convert.ToString(i * 3), Convert.ToString(i))) &&
                        (CheckIfAllNumbersIsDifferent(Convert.ToString(i * 4)) && CheckIfHasSameNumbers(Convert.ToString(i * 4), Convert.ToString(i))) &&
                        (CheckIfAllNumbersIsDifferent(Convert.ToString(i * 5)) && CheckIfHasSameNumbers(Convert.ToString(i * 5), Convert.ToString(i))) &&
                        (CheckIfAllNumbersIsDifferent(Convert.ToString(i * 6)) && CheckIfHasSameNumbers(Convert.ToString(i * 6), Convert.ToString(i)))
                        )
                    {
                        return i;
                    }
                }
            }
            return magic_number;
        }

        static private bool CheckIfAllNumbersIsDifferent(string checkNumber)
        {
            char[] checkableNumberArray;
            checkableNumberArray = checkNumber.ToCharArray();
            for (int i = 0; i < checkableNumberArray.Length; i++)
            {
                for (int j = i +1 ; j < checkableNumberArray.Length; j++)
                {
                    if (checkableNumberArray[i] == checkableNumberArray[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static private bool CheckIfHasSameNumbers(string secondary, string prime)
        {
            bool hasNumber = false;
            char[] checkablePrimeNumberArray = prime.ToCharArray();
            char[] checkableSecondaryNumberArray = secondary.ToCharArray();

            for (int i = 0; i < checkablePrimeNumberArray.Length; i++)
            {
                hasNumber = false;
                for (int j = 0; j < checkableSecondaryNumberArray.Length; j++)
                {
                    if (checkablePrimeNumberArray[i]==checkableSecondaryNumberArray[j])
                    {
                        hasNumber = true;
                        break;
                    }
                }
                if (hasNumber == false)
                {
                    return false;
                }
            }
            return hasNumber;
        }
    }
}
