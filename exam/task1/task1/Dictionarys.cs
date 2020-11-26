using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Dictionarys
    {
        Dictionary<string, List<string>> dict;
        string word;
        public int typeOfDictionary;
        string path1 = @"C:\projects\exam\task1\Ru-En.txt";
        string path2 = @"C:\projects\exam\task1\En-Ru.txt";

        public Dictionarys() { }
        public Dictionarys(int typeOfDictionary)
        {
            dict = new Dictionary<string, List<string>>();
            this.typeOfDictionary = typeOfDictionary;

        }

        public void AddNewWord()
        {
            Console.WriteLine("Enter a word for translation: ");
            string _word = Console.ReadLine();
            word = _word;
            Console.WriteLine("Enter its translation: ");
            string _translate = Console.ReadLine();
            List<string>  translate = new List<string>();
            translate.Add(_translate);
            dict.Add(word, translate);
            Console.WriteLine("Word added");
        }

        public void AddNewTranslate()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            if (dict.ContainsKey(word))
            {
                Console.WriteLine("Enter its translation:");
                string _translate = Console.ReadLine();
                dict[word].Add(_translate);
                dict[word].Sort();
                Console.WriteLine("Translation  added");
            }
            else
            {
                Console.WriteLine("This word is not in the dictionary");
            }
        }

        public void TranslationReplacement()
        {
            Console.WriteLine("Enter a word: ");
            string _word = Console.ReadLine();
            for (int i = 0; i<dict[_word].Count;i++)
            {
                Console.WriteLine((i+1) + " - " + dict[_word][i]);
            }
            Console.WriteLine("Which translation do you want to replace?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new translation:");
            string _translate = Console.ReadLine();
            dict[_word].RemoveAt(a - 1);
            dict[_word].Insert(a - 1, _translate);
            dict[_word].Sort();
            Console.WriteLine("Translation replaced");
        }

        public void WordReplacement()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            List<string> _translate = new List<string>();
            _translate = dict[word];
            dict.Remove(word);
            Console.WriteLine("Enter new word:");
            string _word = Console.ReadLine();
            dict.Add(_word, _translate);
            Console.WriteLine("Word replaced");
        }

        public void RemoveTranslate()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            for (int i = 0; i < dict[word].Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + dict[word][i]);
            }
            if (dict[word].Count==1)
            {
                Console.WriteLine("You cannot delete a single translation");
                return;
            }
            else
            {
                Console.WriteLine("Which translation do you want to replace?");
                int a = Convert.ToInt32(Console.ReadLine());
                dict[word].RemoveAt(a-1);
                dict[word].Sort();
                Console.WriteLine("Translation deleted");
            }
            
        }

        public void RemoveWord()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            if (dict.ContainsKey(word))
            {
                dict.Remove(word);
                Console.WriteLine("Word deleted");
            }
            else
            {
                Console.WriteLine("This word is not in the dictionary");
            }
        }

        public void FindTranslate(string word)
        {
            Console.Write(word + " - " + dict[word][0]);
            if (dict[word].Count > 1)
            {
                for (int i = 1; i < dict[word].Count; i++)
                {
                    Console.Write(", ");
                    Console.Write(dict[word][i]);
                }
            }
            Console.WriteLine(".");
            Console.WriteLine("\nDo you want save find result?");
            Console.Write("Y/N: ");
            char save = Convert.ToChar(Console.ReadLine());
            if(save == 'y' || save == 'Y')
            {
                SaveOnFile(word);
            }
            else
            {
                return;
            }
        }

        public void SaveOnFile(string word)
        { 
           string text = word + " - " + dict[word][0];
                if (dict[word].Count > 1)
                {
                    for (int i = 1; i < dict[word].Count; i++)
                    {
                        text = text + ", " + dict[word][i];
                    }
                }
                text = text + ".";

            if (typeOfDictionary == 1)
            {
                using (StreamWriter sw = new StreamWriter(path1, false))
                {
                    sw.Write(text);
                    Console.WriteLine("Successfully");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path2, false))
                {
                    sw.Write(text);
                    Console.WriteLine("Successfully");
                }
            }
        }
        public void Print()
        {
            foreach (var ab in dict)
            {
                Console.Write(ab.Key + " - " + ab.Value[0]);
                if (ab.Value.Count >= 2)
                {
                    for (int i = 1; i < ab.Value.Count; i++)
                    {
                        Console.Write(", ");
                        Console.Write(ab.Value[i]);
                    }
                }
                Console.WriteLine(".");
            }
        }
    }
}
