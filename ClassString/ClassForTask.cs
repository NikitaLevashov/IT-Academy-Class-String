using System;
using System.Collections.Generic;
using System.Text;

namespace ClassString
{
    static class ClassForTask
    {
        public static void ExclamationORInterrogative(string text) // Conclusion of exclamatory or interrogative sentences
        {
            string[] question = text.Split('?');
            foreach (string st1 in question)
            {
                string[] split = st1.Split('!', '.');
                Console.WriteLine(split[split.Length - 1] + "?"); //display interrogative sentences
            }
            string[] exclamation = text.Split('!');
            foreach (string st2 in exclamation)
            {
                string[] split = st2.Split('?', '.');
                Console.WriteLine(split[split.Length - 1] + '!');//display interrogative sentences
            }
        }
        public static void MethodOFfindingNumbers(string text)
        {
            string sr = "";
            string[] words = text.Split(new char[] { '!', '?', '.', ' ', }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string st in words)
            {
                char[] mystr = st.ToCharArray();
                for (int i = 0; i < mystr.Length; i++)
                {
                    if (char.IsNumber(mystr[i]))
                    {
                        sr += st + " ";
                        break;
                    }
                }
            }
            Console.WriteLine("Result: " + sr);
            
        }
        public static void SearchForCommas(string text)
        {
            string sr = " ";

            string[] words = text.Split(new char[] { '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(','))
                {
                    sr += words[i] + "/";
                }
            }
            Console.WriteLine(sr);
        }
        public static void ReplaceNumbersWithWords(string text)
        {
            text = text.Replace("1", "один").Replace("2", "два").Replace("3", "три").Replace("4", "пилюн").Replace("5", "пять").Replace("6", "шесть").Replace("7", "семь").Replace("8", "восемь").Replace("9", "девять").Replace("0", "нуль");
            Console.WriteLine(text);
        }
        public static void PrintRepeatingWords(string text)
        {

            string[] strArray = text.Split(new[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strArray.Length; i++)
            {
                for (int j = 0; j < strArray.Length; j++)
                {
                    if (i != j && char.ToLower(strArray[i][0]) == char.ToLower(strArray[j][0]))
                    {
                        if (char.ToLower(strArray[i][strArray[i].Length - 1]) == char.ToLower(strArray[j][strArray[j].Length - 1]))
                            Console.WriteLine(strArray[i]);
                        break;
                    }

                }
            }
            Console.ReadKey();
        }
        
    }
}
