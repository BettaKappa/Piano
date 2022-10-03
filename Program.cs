namespace Piano
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Белые клавиши: Z, X, C, V, B, N, M" + "\n" +
                              "Чёрные клавиши: S, D, G, H, J" + "\n" +
                              "Октавы: F1, F2, F3, F4" + "\n" + "\n" +
                              "Выберитет октаву");
            
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.F1:
                    FirtsOctave();
                    break;
                case ConsoleKey.F2:
                    SecondOctave();
                    break;
                case ConsoleKey.F3:
                    ThirdOctave();
                    break;
                case ConsoleKey.F4:
                    ForthOctave();
                    break;
            }
        }
        static void FirtsOctave()
        {
            Console.WriteLine("Первая октава" + "\n" +
                              "Если вы хотите вернутся в меню к выбору октавы, нажмите клавишу Escape");
            int[] Octave = new int[]
                { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.Z:
                    {
                        Console.Beep(Octave[0], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.S:
                    {
                        Console.Beep(Octave[1], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.X:
                    {
                        Console.Beep(Octave[2], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.D:
                    {
                        Console.Beep(Octave[3], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.C:
                    {
                        Console.Beep(Octave[4], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.V:
                    {
                        Console.Beep(Octave[5], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.G:
                    {
                        Console.Beep(Octave[6], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.B:
                    {
                        Console.Beep(Octave[7], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.H:
                    {
                        Console.Beep(Octave[8], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.N:
                    {
                        Console.Beep(Octave[9], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.J:
                    {
                        Console.Beep(Octave[10], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.M:
                    {
                        Console.Beep(Octave[11], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.Escape:
                    {
                        Main();
                        break;
                    }
                }
            }
        }
        static void SecondOctave()
        {
            Console.WriteLine("Вторая октава" + "\n" +
                              "Если вы хотите вернутся в меню к выбору октавы, нажмите клавишу Escape");
            int[] Octave = new int[]
                { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.Z:
                    {
                        Console.Beep(Octave[0], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.S:
                    {
                        Console.Beep(Octave[1], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.X:
                    {
                        Console.Beep(Octave[2], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.D:
                    {
                        Console.Beep(Octave[3], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.C:
                    {
                        Console.Beep(Octave[4], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.V:
                    {
                        Console.Beep(Octave[5], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.G:
                    {
                        Console.Beep(Octave[6], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.B:
                    {
                        Console.Beep(Octave[7], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.H:
                    {
                        Console.Beep(Octave[8], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.N:
                    {
                        Console.Beep(Octave[9], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.J:
                    {
                        Console.Beep(Octave[10], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.M:
                    {
                        Console.Beep(Octave[11], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.Escape:
                    {
                        Main();
                        break;
                    }
                }
            }
        }
        static void ThirdOctave()
        {
            Console.WriteLine("Третья октава" + "\n" +
                              "Если вы хотите вернутся в меню к выбору октавы, нажмите клавишу Escape");
            int[] Octave = new int[]
                {1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976};
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.Z:
                    {
                        Console.Beep(Octave[0], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.S:
                    {
                        Console.Beep(Octave[1], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.X:
                    {
                        Console.Beep(Octave[2], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.D:
                    {
                        Console.Beep(Octave[3], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.C:
                    {
                        Console.Beep(Octave[4], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.V:
                    {
                        Console.Beep(Octave[5], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.G:
                    {
                        Console.Beep(Octave[6], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.B:
                    {
                        Console.Beep(Octave[7], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.H:
                    {
                        Console.Beep(Octave[8], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.N:
                    {
                        Console.Beep(Octave[9], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.J:
                    {
                        Console.Beep(Octave[10], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.M:
                    {
                        Console.Beep(Octave[11], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.Escape:
                    {
                        Main();
                        break;
                    }
                }
            }
        }
        static void ForthOctave()
        {
            Console.WriteLine("Четвёртая октава" + "\n" +
                              "Если вы хотите вернутся в меню к выбору октавы, нажмите клавишу Escape");
            int[] Octave = new int[]
                { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.Z:
                    {
                        Console.Beep(Octave[0], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.S:
                    {
                        Console.Beep(Octave[1], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.X:
                    {
                        Console.Beep(Octave[2], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.D:
                    {
                        Console.Beep(Octave[3], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.C:
                    {
                        Console.Beep(Octave[4], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.V:
                    {
                        Console.Beep(Octave[5], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.G:
                    {
                        Console.Beep(Octave[6], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.B:
                    {
                        Console.Beep(Octave[7], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.H:
                    {
                        Console.Beep(Octave[8], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.N:
                    {
                        Console.Beep(Octave[9], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.J:
                    {
                        Console.Beep(Octave[10], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.M:
                    {
                        Console.Beep(Octave[11], 500);
                        Console.Clear();
                        break;
                    }
                    case ConsoleKey.Escape:
                    {
                        Main();
                        break;
                    }
                }
            }
        }
    }
}
