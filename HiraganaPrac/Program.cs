using System;

namespace HiraganaPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            var hira = new Hiragana();
            var kata = new Katakana();
            var ran = new CharSelect();
            var scoreTotal = 0;
            var correct = 0;
            var wrong = 0;

            Console.Write("Hiragana or Katakana: ");
            var hOrK = Console.ReadLine().ToLower();

            do
            {
                switch (hOrK)
                {
                    case "hiragana":
                       int x = ran.RanSelect(1, 46);
                        break;
                    case "katakana":
                        break;
                    default:
                        break;
                }
            } while (scoreTotal <= 46);


        }
    }
}
