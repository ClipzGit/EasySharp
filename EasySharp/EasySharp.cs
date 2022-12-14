using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EasySharp
{
    public class EasySharp
    {
        class Requests
        {
            public static void Get(string url)
            {

            }

            public static void PostJSON(string url, string[] json_data)
            {
                foreach (var data in json_data)
                {
                    // Echo the given data
                    Console.WriteLine(data);
                }
            }
        }
        // Set Console Title or Loop it
        public static async Task Title(string title = "Console Window", bool loop_titles = false, string title_one = "", string title_two = "", string title_three = "")
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (loop_titles == true)
            {
                string[] titles = { title, title_one, title_two, title_three };

                while (true)
                {
                    for (int i = 0; i < titles.Length; i++)
                    {
                        Console.Title = titles[i];
                        await Task.Delay(2000);
                    }
                }
                sw.Stop();
            }
            else if (loop_titles == false)
            {
                Console.Title = title;
            }
        
        }
        
        // Write basic line or 'true' for underlined effect
        public static void WriteLine(string text, bool underlined = false, char underline_icon = '=')
        {
            if (underlined == true)
            {
                Console.WriteLine(text);
                foreach (char letter in text)
                {
                    Console.Write(underline_icon);
                }
                Console.WriteLine();
            }
            else if (underlined == false)
            {
                Console.WriteLine(text);
            }
        }

        // Write a colored line with text color and option for underlined effect
        public static void WriteColoredLine(string text, ConsoleColor color, bool underlined = false, char underline_icon = '=')
        {
            if (underlined == true)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                foreach (char letter in text)
                {
                    Console.Write(underline_icon);
                }
                Console.WriteLine();
                Console.ResetColor();
            }
            else if (underlined == false)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            }
        }
    
        // Write a colored line with background color and option for underlined effect
        public static void WriteBackgroundLine(string text, ConsoleColor color, bool underlined = false, char underline_icon = '=')
        {
            if (underlined == true)
            {
                Console.BackgroundColor = color;
                Console.WriteLine(text);
                foreach (char letter in text)
                {
                    Console.Write(underline_icon);
                }
                Console.WriteLine();
                Console.ResetColor();
            }
            else if (underlined == false)
            {
                Console.BackgroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            }
        }

        // Write a custom line with text color, background color, underlined effect
        public static void WriteCustomLine(string text, ConsoleColor text_color, ConsoleColor bg_color, bool underlined = false, char underline_icon = '=')
        {
            if (underlined == true)
            {
                Console.ForegroundColor = text_color;
                Console.BackgroundColor = bg_color;
                Console.WriteLine(text);
                foreach (char letter in text)
                {
                    Console.Write(underline_icon);
                }
                Console.WriteLine();
                Console.ResetColor();
            }
            else if (underlined == false)
            {
                Console.ForegroundColor = text_color;
                Console.BackgroundColor = bg_color;
                Console.WriteLine(text);
                Console.ResetColor();
            }
        }

        // Write a rotating line | NOT USABLE ATM
        public static async Task RotatingLine(string[] rotating_lines)
        {
           for (int i = 0; i < rotating_lines.Length; i++)
             {
                Console.Write("\r{0}%   ", rotating_lines[i]);
                await Task.Delay(2000);
                    
             }
          
        }

        // Draw a menu using an array
        public static void DrawMenu(string[] menu_items, ConsoleColor text_color)
        {
            for (int i = 0; i < menu_items.Length; i++)
            {
                Console.ForegroundColor = text_color;
                Console.WriteLine("{0}# {1}", i + 1, menu_items[i]);
                Console.ResetColor();
            }
        }

        // Randomiser - Randomly choose an integer from an array
        public static void RandomNumb(double[] numbers)
        {
            Random rnd = new Random();
            int output = rnd.Next(numbers.Length);

            Console.WriteLine(output);
        }

        // Randomiser - Randomly choose a string 
        public static void RandomWord(string[] words)
        {
            Random rnd = new Random(); 
            int chosen = rnd.Next(words.Length);

            Console.WriteLine(words[chosen]);
        }

        

    
    }
}
