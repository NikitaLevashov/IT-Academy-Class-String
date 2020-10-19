using System;


namespace ClassString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear friends in the application number 2! Let's work on the topic System.String \n");
            Console.WriteLine("Please enter text ");
            bool flag = true;
            string text = Console.ReadLine();
            while (flag)
            {
                //input text
                Console.WriteLine("Выберите пожалуйста следующее действие:\n 1 - Use split method;\n 2 - Display exclamations and questioning sentences \n 3 - Finding words in numbers;\n 4 - Finding sentences with commas;\n 5 - Replacing numbers in words with words;\n 6 - Finding words that begin and end with identical characters.\n 7 - Exit");
                bool IsMenu = Int32.TryParse(Console.ReadLine(), out int e);

                if (IsMenu == true)
                {
                    //Console.WriteLine("Выберите пожалуйста следующее действие:\n 1 - Use split method;\n 2 - Display exclamations and questioning sentences \n 3 - Finding words in numbers;\n 4 - Finding sentences with commas;\n 5 - Replacing numbers in words with words;\n 6 - Finding words that begin and end with identical characters.\n 7 - Exit");
                    switch (e)
                    {
                        case 1:
                            Console.WriteLine("Use split method: .  .  .");
                            string[] words = text.Split(new char[] { ' ', ',', '!', '?', '.', ';' }, StringSplitOptions.RemoveEmptyEntries);// Break the string into an array of substrings
                            foreach (string s in words)
                                Console.WriteLine(s + " -  your substring contains " + s.Length + " characters");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please press any key.....");
                            Console.ResetColor();

                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("Display exclamatory and interrogative sentences:.  .   .");
                            ClassForTask.ExclamationORInterrogative(text);//display exclamations and questioning sentences
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please press any key.....");
                            Console.ResetColor();
                            Console.ReadKey(true);
                            break;

                        case 3:
                            Console.WriteLine("Finding words in numbers:.  .  .");
                            ClassForTask.MethodOFfindingNumbers(text);// DISPLAY WORDS WITH NUMBERS
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please press any key.....");
                            Console.ResetColor();
                            Console.ReadKey(true);
                            break;
                        case 4:
                            Console.WriteLine("Finding sentences with commas:.  .   .");
                            ClassForTask.SearchForCommas(text);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please press any key.....");
                            Console.ResetColor();
                            Console.ReadKey(true);
                            break;
                        case 5:
                            Console.WriteLine("Replacing numbers in words with words:.   .    .");
                            ClassForTask.ReplaceNumbersWithWords(text);
                            Console.ReadKey(true);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please press any key.....");
                            Console.ResetColor();
                            break;
                        case 6:
                            Console.WriteLine("Finding words that begin and end with identical characters:.   .    .");
                            ClassForTask.PrintRepeatingWords(text);
                            Console.ReadKey(true);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please press any key.....");
                            Console.ResetColor();
                            break;
                        case 7:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("*************Exit***************");
                            Console.ResetColor();
                            flag = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You clicked an unknown letter. Press any key to repeat again");
                            Console.ResetColor();
                            break;
       
                    }
                    
                }
                
            }
        }
    }
}
