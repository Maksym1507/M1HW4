namespace M1HW4
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter quantity elements in array: ");
            var n = Console.ReadLine();
            var numbersArray = new int[Convert.ToInt32(n)];

            var quantityOfEvenNumbers = 0;
            var quantityOfOddNumbers = 0;

            var englishAlphabet = "abcdefghigklmnopqrstuvwxyz";

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = new Random().Next(1, 27);

                if (numbersArray[i] % 2 == 0)
                {
                    quantityOfEvenNumbers++;
                }
                else
                {
                    quantityOfOddNumbers++;
                }
            }

            Console.Write("Numbers array output: ");

            foreach (var item in numbersArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            var evenArray = new string[quantityOfEvenNumbers];
            var oddArray = new string[quantityOfOddNumbers];
            var evenArrayIndexCounter = 0;
            var oddArrayIndexCounter = 0;
            var quantityLettersInEvenArrayWithUpperCase = 0;
            var quantityLettersInOddArrayWithUpperCase = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] % 2 == 0)
                {
                    evenArray[evenArrayIndexCounter] = $"{englishAlphabet[numbersArray[i] - 1]}";
                    evenArrayIndexCounter++;
                }
                else
                {
                    oddArray[oddArrayIndexCounter] = $"{englishAlphabet[numbersArray[i] - 1]}";
                    oddArrayIndexCounter++;
                }
            }

            for (int i = 0; i < oddArray.Length; i++)
            {
                if (oddArray[i] == "a" || oddArray[i] == "e" || oddArray[i] == "i")
                {
                    oddArray[i] = oddArray[i].ToUpper();
                    quantityLettersInOddArrayWithUpperCase++;
                }
            }

            for (int i = 0; i < evenArray.Length; i++)
            {
                if (evenArray[i] == "d" || evenArray[i] == "h" || evenArray[i] == "j")
                {
                    evenArray[i] = evenArray[i].ToUpper();
                    quantityLettersInEvenArrayWithUpperCase++;
                }
            }

            Console.Write("Even array output: ");

            foreach (var item in evenArray)
            {
                Console.Write(item + " ");
            }

            Console.Write("\nOdd array output: ");

            foreach (var item in oddArray)
            {
                Console.Write(item + " ");
            }

            if (quantityLettersInEvenArrayWithUpperCase > quantityLettersInOddArrayWithUpperCase)
            {
                Console.WriteLine("\nQuantity letters with upper case more in even array");
            }
            else if (quantityLettersInOddArrayWithUpperCase > quantityLettersInEvenArrayWithUpperCase)
            {
                Console.WriteLine("\nQuantity letters with upper case more in odd array");
            }
            else
            {
                Console.WriteLine("\nQuantity letters with upper case are equal");
            }
        }
    }
}