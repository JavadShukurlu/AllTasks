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


int[] arr = new int[] { 10, 12, 22, 10, 32,22, 16, 32, 22, 10, 11, 23, 32, 10, 10, 23, 23, 15 };
int say = arr.Length;
int count = 1;

for(int i = 0; i < arr.Length; i++)
{

    for(int j = 1; j < arr.Length-1; j++)
    {
        if (arr[i] != arr[j])
        {
            count++;
        }
    }
    
}
Console.WriteLine(count);







