//////////////////////////
//// 1.1. uzd.
//////////////////////////

//int[,] masivs = new int[10, 10];
//Random random = new Random();
//int pilnaSumma = 0;
//int[] summas = new int[masivs.GetLength(1)];

//for (int i = 0; i < masivs.GetLength(0); i++)
//{
//    int rindasSumma = 0;
//    for (int j = 0; j < masivs.GetLength(1); j++)
//    {
//        masivs[i, j] = random.Next(0, 10);
//        Console.Write(masivs[i, j] + "\t");
//        rindasSumma += masivs[i, j];
//    }
//    Console.WriteLine();
//    summas[i] = rindasSumma;
//    pilnaSumma += rindasSumma;
//}

//for (int i = 0; i < summas.Length; i++)
//{
//    Console.WriteLine($"{i + 1} rindas skaitļu summa ir {summas[i]}");
//}
//Console.WriteLine($"Masīva skaitļu summa ir {pilnaSumma}");


//////////////////////////
//// 1.2. uzd.
//////////////////////////

//int[,] masivs = new int[10, 10];
//Random random = new Random();

//for (int i = 0; i < masivs.GetLength(0); i++)
//{
//    for (int j = 0; j < masivs.GetLength(1); j++)
//    {
//        masivs[i, j] = random.Next(0, 10);
//        Console.Write(masivs[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//int globalMax = masivs[0, 0];
//int globalMin = masivs[0, 0];
//for (int i = 0; i < masivs.GetLength(0); i++)
//{
//    int rindasMax = masivs[i, 0];
//    int rindasMin = masivs[i, 0];

//    for (int j = 0; j < masivs.GetLength(1); j++)
//    {
//        if (masivs[i, j] > rindasMax)
//        {
//            rindasMax = masivs[i, j];
//        }
//        if (masivs[i, j] < rindasMin)
//        {
//            rindasMin = masivs[i, j];
//        }

//        if (masivs[i, j] > globalMax)
//        {
//            globalMax = masivs[i, j];
//        }
//        if (masivs[i, j] < globalMin)
//        {
//            globalMin = masivs[i, j];
//        }
//    }

//    Console.WriteLine($"{i + 1}. rindas max vērtība: {rindasMax}, rindas min vērtība: {rindasMin}");
//}


//Console.WriteLine($"Visa masīva max vērtība: {globalMax}, visa masīva min vērtība: {globalMin}");


//////////////////////////
//// 1.3. uzd.
//////////////////////////

//int[,] masivs = new int[10, 10];
//Random random = new Random();

//for (int i = 0; i < masivs.GetLength(0); i++)
//{
//    for (int j = 0; j < masivs.GetLength(1); j++)
//    {
//        masivs[i, j] = random.Next(0, 10);
//        Console.Write(masivs[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();

//for (int j = 0; j < masivs.GetLength(1); j++)
//{
//    for (int i = 0; i < masivs.GetLength(0); i++)
//    {
//        Console.Write(masivs[i, j] + "\t");
//    }
//    Console.WriteLine();
//}


//////////////////////////
//// 1.4. uzd.
//////////////////////////

//int[,] masivs = new int[10, 10];
//Random random = new Random();

//for (int i = 0; i < masivs.GetLength(0); i++)
//{
//    for (int j = 0; j < masivs.GetLength(1); j++)
//    {
//        masivs[i, j] = random.Next(0, 10);
//        Console.Write(masivs[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();

//for (int j = 0; j < masivs.GetLength(1); j++)
//{
//    for (int i = 0; i < masivs.GetLength(0); i++)
//    {
//        if (j < i)
//        {
//            Console.Write("0\t");
//        }
//        else
//        {
//            Console.Write(masivs[i, j] + "\t");
//        }
//    }
//    Console.WriteLine();
//}


//////////////////////////
//// 2.1. uzd.
//////////////////////////

//Console.Write("Ievadiet rindu skaitu: ");
//int x = Convert.ToInt32(Console.ReadLine());

//Console.Write("Ievadiet kolonnu skaitu: ");
//int y = Convert.ToInt32(Console.ReadLine());

//int[,] masivs = new int[x, y];
//Random random = new Random();
//int pari = 0;

//for (int i = 0; i < masivs.GetLength(0); i++)
//{
//    for (int j = 0; j < masivs.GetLength(1); j++)
//    {
//        masivs[i, j] = random.Next(0, 101);
//        Console.Write(masivs[i, j] + "\t");

//        if (masivs[i, j] % 2 == 0)
//        {
//            pari++;
//        }
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();
//Console.WriteLine($"{(double)pari / (x * y) * 100}% no masiva elementiem ir para skaitli!");
//Console.WriteLine();

//for (int i = 0; i < masivs.GetLength(0); i++)
//{
//    for (int j = 0; j < masivs.GetLength(1); j++)
//    {
//        if (masivs[i, j] % 2 == 0)
//        {
//            Console.Write((masivs[i, j] + 1) + "\t");
//        }
//        else
//        {
//            Console.Write(masivs[i, j] + "\t");
//        }
//    }
//    Console.WriteLine();
//}



//////////////////////////
//// 2.2. uzd.
//////////////////////////

//Console.Write("Ievadiet rindu skaitu: ");
//int x = Convert.ToInt32(Console.ReadLine());

//Console.Write("Ievadiet kolonnu skaitu: ");
//int y = Convert.ToInt32(Console.ReadLine());

//int[,] masivs = new int[x, y];
//Random random = new Random();
//int pari = 0;

//for (int i = 0; i < masivs.GetLength(0); i++)
//{
//    for (int j = 0; j < masivs.GetLength(1); j++)
//    {
//        masivs[i, j] = random.Next(0, 101);
//        Console.Write(masivs[i, j] + "\t");

//        if (masivs[i, j] % 2 == 0)
//        {
//            pari++;
//        }
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();
//Console.WriteLine("Katrs otrais elements - 0");
//Console.WriteLine();

//for (int i = 0; i < masivs.GetLength(0); i++)
//{
//    for (int j = 0; j < masivs.GetLength(1); j++)
//    {
//        if (i % 2 == 0)
//        {
//            if (j % 2 == 0)
//            {
//                Console.Write("0\t");
//            }
//            else
//            {
//                Console.Write(masivs[i, j] + "\t");
//            }

//        }
//        else
//        {
//            if (j % 2 == 1)
//            {
//                Console.Write("0\t");
//            }
//            else
//            {
//                Console.Write(masivs[i, j] + "\t");
//            }
//        }
//    }
//    Console.WriteLine();
//}