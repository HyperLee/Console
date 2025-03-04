namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string s = " +-9x9";
            int result = MyAtoi(s);
            Console.WriteLine(result);
        }

        public static int MyAtoi(string s)
        {
            int i = 0;
            while(i < s.Length && s[i] == ' ')
            {
                i++;
            }
            
            bool isNegative = false;
            if (i < s.Length && s[i] == '-')
            {
                isNegative = s[i] == '-';
                i++;
            }
            else if(s[i] == '+')
            {
                i++;
            }
            else if(char.IsLetter(s[i]))
            {
                return 0;
            }

            int result = 0;
            while(i < s.Length && s[i] >= '0' && s[i] <= '9')
            {
                int digit = s[i] - '0';
                if (result > (Int32.MaxValue - digit) / 10)
                {
                    return isNegative ? Int32.MinValue : Int32.MaxValue;
                }
                result = result * 10 + digit;
                i++;
            }

            return isNegative ? -result : result;
        }

    }
}

