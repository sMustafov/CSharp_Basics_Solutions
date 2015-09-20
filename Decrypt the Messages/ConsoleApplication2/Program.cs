using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            StringBuilder newInput = new StringBuilder();
            int p = 0;

            List<string> arr = new List<string>();

            int messages = 0;
            do
            {
                input = Console.ReadLine();
                if (input == "START" || input == "start")
                {
                    int lenght = input.Length;
                    p = 0;
                    newInput = new StringBuilder();

                    if (input != "end" && input != "END" && input != "start" && input != "START")
                    {
                        for (int i = 0; i < lenght; i++)
                        {
                            if (input[i] >= 'a' && input[i] <= 'm')
                            {
                                newInput.Insert(p, (char)(input[i] + 13));
                                p++;
                            }
                            else if (input[i] >= 'n' && input[i] <= 'z')
                            {
                                newInput.Insert(p, (char)(input[i] - 13));
                                p++;
                            }
                            else if (input[i] >= 'A' && input[i] <= 'M')
                            {
                                newInput.Insert(p, (char)(input[i] + 13));
                                p++;
                            }
                            else if (input[i] >= 'N' && input[i] <= 'Z')
                            {
                                newInput.Insert(p, (char)(input[i] - 13));
                                p++;
                            }
                            else if (input[i] == '+')
                            {
                                newInput.Insert(p, (char)(input[i] - 11));
                                p++;
                            }
                            else if (input[i] == '%')
                            {
                                newInput.Insert(p, (char)(input[i] + 7));
                                p++;
                            }
                            else if (input[i] == '#')
                            {
                                newInput.Insert(p, (char)(input[i] + 28));
                                p++;
                            }
                            else if (input[i] == '$')
                            {
                                newInput.Insert(p, (char)(input[i] - 3));
                                p++;
                            }
                            else if (input[i] == '&')
                            {
                                newInput.Insert(p, (char)(input[i] + 8));
                                p++;
                            }
                            else if (input[i] >= '0' && input[i] <= '9')
                            {
                                newInput.Insert(p, (char)(input[i]));
                                p++;
                            }

                        }
                        string text = newInput.ToString();
                        while ((input != "end" && input != "END") && lenght != 0)
                        {
                            arr.Add(text);
                            messages++;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            } while (input != "end" || input != "END");
            if (messages == 0)
            {
                Console.WriteLine("No message received.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}", messages);
            }

            for (int k = 0; k < arr.Count; k++)
            {
                string newInputt = arr[k].ToString();
                newInputt = Reverse(newInputt);
                Console.WriteLine(newInputt);
            }
        }
        public static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }
    }
}
