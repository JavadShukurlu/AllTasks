////1 ve 100 arasinda bir eded daxil etsin istifadeci ve onu tapmaga calissin.5 defe cehd haqqi olsun eger tapsa "you won" 5 cehd bitdikden sonra "Game over " yazsin


//Random eded = new Random();
//int hide = eded.Next(1, 100);
//Console.WriteLine(hide);
//int count = 5;


//while (count > 0)
//{
//    Console.WriteLine("Ededi daxil edin:");
//    int daxil_edilen = Convert.ToInt32(Console.ReadLine());
//    if (daxil_edilen == hide)
//    {
//        Console.WriteLine("You Won");

//        break;


//    }


//    else
//    {
//        count--;
//        Console.WriteLine($"Try again! {count} chances left");
//    }


//}
//if (count == 0)
//    Console.WriteLine("Game Over");



//DIZZZ  1 ve 100 arasinda sonu 7 ve 7-e bolunen ededleri cixarmasin


//for (int i = 1; i <= 100; i++)
//{


//    if (i % 10 == 7 || i % 7 == 0)
//    {
//        Console.Write(" dizz ");
//    }
//    else
//    {
//        Console.Write(i + " ");
//    }

//}


//int[] arr = new int[] { 10, 12, 22, 10, 32,22, 16, 32, 22, 10, 11, 23, 32, 10, 10, 23, 23, 15 };
//int say = arr.Length;
//int count = 1;

//for(int i = 0; i < arr.Length; i++)
//{

//    for(int j = 1; j < arr.Length-1; j++)
//    {
//        if (arr[i] != arr[j])
//        {
//            count++;
//        }
//    }

//}
//Console.WriteLine(count);



//-----------------------------------------------------------------------------


//DetectedMax(12, 34);


// static void DetectedMax(int birinci_eded,int ikinci_eded)
//{
//    if(birinci_eded>ikinci_eded)
//        Console.WriteLine($"Birinci eded boyukdur:{birinci_eded}");

//    else if(birinci_eded==ikinci_eded)
//        Console.WriteLine("Ededler beraberdir");

//    else
//        Console.WriteLine( $"Ikinci eded boyukdur:{ikinci_eded}");
//}          


//Dividebytwo(77);
//static void Dividebytwo(int eded)
//{
//    if(eded%2==0)
//        Console.WriteLine("Eded 2-e tam bolunur");
//    else
//        Console.WriteLine("Eded 2-e bolunmur");
//}


//Console.Write("Ededi daxil edin:");
//int eded = Convert.ToInt32(Console.ReadLine());
//MoreThanOneHundred(eded);
//static void MoreThanOneHundred(int daxiledilen_eded)
//{
//    if(daxiledilen_eded>=100)
//        Console.WriteLine("Eded 100-den boyukdur");
//    else
//        Console.WriteLine("Eded 100-den kicikdir");
//}

//Console.WriteLine("Yasi daxil edin:");
//int yas = Convert.ToInt32(Console.ReadLine());
//CheckAdultorChild(yas);

//static void CheckAdultorChild(int yas)
//{
//    if(yas>=18)
//        Console.WriteLine("Adult");
//    else
//        Console.WriteLine("Child");
//}


//Console.WriteLine("Ededi daxil edin:");
//int eded = Convert.ToInt32(Console.ReadLine());
//DetectedNumberMark(eded);
//static void DetectedNumberMark(int eded)
//{
//    if(eded<0)
//        Console.WriteLine("Eded menfidir");
//    else if(eded==0)
//        Console.WriteLine("Eded 0-dir");
//    else
//        Console.WriteLine("Eded musbetdir");
//}


//Console.WriteLine("Ededi daxil edin:");
//int eded = Convert.ToInt32(Console.ReadLine());
//Detectedcubed(eded);
//static void Detectedcubed(int eded)
//{
//    int result = Convert.ToInt32(Math.Pow(eded, 3));
//    Console.WriteLine(result);
//}








