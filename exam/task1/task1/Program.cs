using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionarys dictionarys = new Dictionarys();
            int key = 0;
            while(key != 9)
            {
                Console.WriteLine("1 - Create new dictionary");
                Console.WriteLine("2 - Add new word");
                Console.WriteLine("3 - Add translation to word");
                Console.WriteLine("4 - Remove translation");
                Console.WriteLine("5 - Remove word");
                Console.WriteLine("6 - Change translation");
                Console.WriteLine("7 - Change word");
                Console.WriteLine("8 - Find word translation");
                Console.WriteLine("9 - Exit");

                key = Convert.ToInt32(Console.ReadLine());

                switch(key)
                {
                    case 1:
                        Console.WriteLine("1 - Ru-En");
                        Console.WriteLine("2 - En-Ru");
                        Console.WriteLine("какой словарь вы хотите создать?");
                        int type = Convert.ToInt32(Console.ReadLine());
                        dictionarys = new Dictionarys(type);
                        break;
                    case 2:
                        dictionarys.AddNewWord();
                        break;
                    case 3:
                        dictionarys.AddNewTranslate();
                        break;
                    case 4:
                        dictionarys.RemoveWord();
                        break;
                    case 5:
                        dictionarys.RemoveTranslate();
                        break;
                    case 6:
                        dictionarys.TranslationReplacement();
                        break;
                    case 7:
                        dictionarys.WordReplacement();
                        break;
                    case 8:
                        Console.WriteLine("Enter a word:");
                        string word = Console.ReadLine();
                        dictionarys.FindTranslate(word);
                        break;
                }
            }
        }
    }
}
