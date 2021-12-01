class Hangman
{
    static void Main()
    {
        Console.WriteLine("Bienvenido al juego del ahorcado!");
        Console.WriteLine("Ingrese una palabra para empezar:");
        string word = Console.ReadLine().ToLower();
        int length = word.Length;

        string line1 = " ╔═══╗ ";
        string line2 = " ║";
        string line3 = " ║";
        string line4 = " ║";
        string line5 = " ║";
        string line6 = " ║";
        string line7 = " ║";
        string line8 = "/║\\";

        int turns = 5;
        int count = 0;
        int score = 0;

        string spaces = "";
        for (int i = 0; i < length; i++)
        {
            spaces += "_";
        }

        while (count < turns && score < length){
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            Console.WriteLine(line4);
            Console.WriteLine(line5);
            Console.WriteLine(line6);
            Console.WriteLine(line7);
            Console.WriteLine(line8);
            Console.WriteLine("\n");
            Console.WriteLine(spaces);
            Console.WriteLine("Ingrese una letra:");
            string letter = Console.ReadLine().ToLower();
            
            bool flag = false;
            for (int i = 0; i < length; i++)
            {
                
                if (word[i] == letter[0])
                {
                    Console.WriteLine("Acertaste!");
                    spaces = spaces.Remove(i, 1).Insert(i, letter);
                    score++;
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Incorrecto!");
                count++;
            }
            if (count == 1)
            {
               line2 = " ║   |";
            }
            if (count == 2)
            {
                line3 = " ║   O";
            }
            if (count == 3)
            {
                line4 = " ║  /|\\";
            }
            if (count == 4)
            {
                line5 = " ║  /";
            }
            if (count == 5)
            {
                line5 = " ║  / \\";
                
            }
            if (count == turns)
            {
                Console.WriteLine(line1);
                Console.WriteLine(line2);
                Console.WriteLine(line3);
                Console.WriteLine(line4);
                Console.WriteLine(line5);
                Console.WriteLine(line6);
                Console.WriteLine(line7);
                Console.WriteLine(line8);
                Console.WriteLine("Perdiste!");
                Console.WriteLine("La palabra era: " + word);
            }
            if (score == length)
            {
                Console.WriteLine("Ganaste!");
            }
        }
    }
}
