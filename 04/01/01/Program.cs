using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> st = new Stack<char>();
            string str = Console.ReadLine();
            int i = 0;
            bool end = false;
            while (i < str.Length && !end)
            {
                switch (str[i])
                {
                    case '(':
                        st.Push(str[i]);
                        break;
                    case ')':
                        try
                        {
                            if (st.Peek() == '(')
                                st.Pop();
                            else
                            {
                                end = true;
                                Console.WriteLine("Ошибка");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка");
                            end = true;
                        }
                        break;
                    case '[':
                        st.Push(str[i]);
                        break;
                    case ']':
                        try
                        {
                            if (st.Peek() == '[')
                                st.Pop();
                            else
                            {
                                end = true;
                                Console.WriteLine("Ошибка");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка");
                            end = true;
                        }
                        break;
                    case '{':
                        st.Push(str[i]);
                        break;
                    case '}':
                        try
                        {
                            if (st.Peek() == '{')
                                st.Pop();
                            else
                            {
                                end = true;
                                Console.WriteLine("Ошибка");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка");
                            end = true;
                        }
                        break;
                }
                i++;
            }
            if (st.Count != 0 && !end)
                Console.WriteLine("Не хватает закрывающей(-их) скобки(-ок)");
            Console.WriteLine("КОНЕЦ");
            Console.Read();
        }
    }
}
