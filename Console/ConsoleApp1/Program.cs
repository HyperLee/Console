// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace ConsoleApp1
{
    internal class Program
    {
 
        static void Main(string[] args)
        {   
            string[] input = { "2", "1", "+", "3", "*" };
            Console.WriteLine("res: " + EvalRPN(input));        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public static int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            int length = tokens.Length;

            for(int i = 0; i < length; i++)
            {
                string token = tokens[i];
                if(IsNumber(token) == true)
                {
                    stack.Push(int.Parse(token));
                }
                else
                {
                    int num2 = stack.Pop();
                    int num1 = stack.Pop();

                    switch(token)
                    {
                        case "+":
                            stack.Push(num1 + num2);
                            break;
                        case "-":
                            stack.Push(num1 - num2);
                            break;
                        case "*":
                            stack.Push(num1 * num2);
                            break;
                        case "/":
                            stack.Push(num1 / num2);
                            break;
                        default:
                            break;
                    }
                }
            }

            return stack.Pop();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static bool IsNumber(string token)
        {
            return char.IsNumber(token[token.Length - 1]);
        }

    }
}

