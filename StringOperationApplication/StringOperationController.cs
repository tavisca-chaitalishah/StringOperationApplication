using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperationApplication
{
    class StringOperationController
    {
        public string userString;
        public void StringOperation()
        {
            int choice;
            string stringToFind;
            char variableToFind;
            string userChoiceToContinue;
            Console.WriteLine("Stack MENU \n1. Substring()\n2. Contains()\n3. EndsWith()\n4. IndexOf()\n5.Enter New String\n6. Exit");
            ReadString();
            do
            {
                Console.WriteLine("Select Your Choice :");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Enter the index of string to create subString");
                        int index = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine(" Sub-String is : " + SubString(userString, index));


                        break;
                    case 2:

                        Console.WriteLine("Enter the String To find");
                        stringToFind = Console.ReadLine();
                        Contains(userString, stringToFind);
                        break;
                    case 3:

                        Console.WriteLine("Enter the String To find");
                        stringToFind = Console.ReadLine();

                        if (EndsWith(userString, stringToFind))
                        {
                            Console.WriteLine("String Ends With {0}", stringToFind);
                        }
                        else
                        {
                            Console.WriteLine("String Does not ends with {0}", stringToFind);
                        }

                        break;
                    case 4:

                        Console.WriteLine("Enter the Character To find");
                        variableToFind = Convert.ToChar(Console.Read());
                        int result = IndexOf(userString, variableToFind);
                        if (result >= 0)
                        {
                            Console.WriteLine(" Character {0} found At {1} in String {2}", variableToFind, IndexOf(userString, variableToFind), userString);

                        }
                        else
                        {
                            Console.WriteLine(" Character {0} is not found in String {1}", variableToFind, userString);
                        }
                            break;
                    case 5:
                        ReadString();
                        break;

                    case 6:
                        Console.WriteLine("Thankyou");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.WriteLine("Enter Y to continue");
                userChoiceToContinue = Console.ReadLine();



            } while (userChoiceToContinue == "Y");
        }


        public void ReadString()
        {
            Console.WriteLine("Enter the String");
            userString = Console.ReadLine();
        }
        public string SubString(String userString, int index)
        {
            int iterator = 0;

            string resultantString = "";

            for (iterator = index - 1; iterator < userString.Length; iterator++)
            {
                resultantString += userString[iterator];

            }
            return resultantString;


        }
        public void Contains(String firstString, String secondString)
        {
            int index = 0, iterator = 0;
            int lengthOriginalString, lengtOfCheckString;
            lengthOriginalString = firstString.Length;
            lengtOfCheckString = secondString.Length;
            char[] originalString = firstString.ToCharArray();
            char[] checkString = secondString.ToCharArray();

            while (index < lengthOriginalString)
            {

                if ((iterator < lengtOfCheckString) && (originalString[index] == checkString[iterator]))
                {
                    iterator++;
                }
                index++;
            }
            if (iterator == lengtOfCheckString)
            {
                Console.WriteLine("substring exist");
            }
            else
            {
                Console.WriteLine("substring doesnot exist");
            }

        }

        public bool EndsWith(String userString, string stringToFind)
        {
            int iterator, secondIterator;
            int userStringLength = userString.Length;
            int stringToFindLength = stringToFind.Length;
            int searchFrom = userStringLength - stringToFindLength;
            for (iterator = searchFrom, secondIterator = 0; iterator < userStringLength; iterator++)
            {
                if (userString[iterator] != stringToFind[secondIterator])
                {
                    return false;

                }
                secondIterator++;
            }
            if (iterator == userStringLength)
            {
                return true;
            }

            return false;
        }
        public int IndexOf(String userString, Char toFind)
        {
            
            for (int iterator = 0; iterator < userString.Length; iterator++)
            {
                if (userString[iterator] == toFind)
                {
                    
                    return iterator;

                   
                }
            }
            return -1;

        }
       
    }
}


