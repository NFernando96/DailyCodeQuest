namespace DailyCodeQuest
{
    internal class Palindrome
    {
        public static void CheckPalindrome()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine()!;

            string formattedString = input.Replace(" ", "").ToLower();

            var isPalindrome = IsPalindrome(formattedString);

            if (isPalindrome)
            {
                Console.WriteLine($""" "{input}" is a Palindrome :)""");
            }
            else
            {
                Console.WriteLine($""" "{input}" is not a Palindrome :(""");
            }


        }

        private static bool IsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
