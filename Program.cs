Console.Clear();
Console.WriteLine("Какую задачу вы хотите проверить (1/2/3/4)? ");
int Task = Convert.ToInt32(Console.ReadLine());

if(Task == 1){
    Task1();
}
else if(Task == 2){
    Task2();
}
else if(Task == 3){
    Task3();
}

else if(Task == 4){
    Task4();
}

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//12821 -> да
//14212 -> нет
void Task1()
{
    Console.Clear();
    Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

    Console.WriteLine("Введите пятизначное число");
    int num = Convert.ToInt32(Console.ReadLine());
    //string number = num.ToString();

    if (num.ToString()[0] == num.ToString()[4] && num.ToString()[1]== num.ToString()[3])
    {
     Console.WriteLine($"Число  {num} является палиндромом. " );
    }
    else {
    Console.WriteLine($"Число  {num} не является палиндромом. " );
    }
}

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
void Task2()
{
    Console.Clear();
    Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

    Console.WriteLine("Введите Координату х1 : ");
    int x1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите Координату y1 : ");
    int y1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите Координату z1 : ");
    int z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите Координату х2 : ");
    int x2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите Координату y2 : ");
    int y2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите Координату z2 : ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    double Len = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)+ Math.Pow((z1 - z2), 2));
    Console.WriteLine("Длина отрезка равна " + Math.Round(Len,2));
}

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void Task3()
{
    Console.Clear();
    Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

    Console.WriteLine("Введите N: ");

    int num = Convert.ToInt32(Console.ReadLine ());

    for (int i =1; i<=num; i++)
    Console.Write(Math.Pow(i, 3)+" ");
}


// Напишите программу, которая на вход принимает радиус круга и находит его площадь 
//округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
//10 -> 4
//20 -> 7
//30 -> 8
void Task4()
{
    Console.Clear();
    Console.WriteLine("Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.");

    Console.WriteLine("Введите Радиус круга (R): ");
    int R = Convert.ToInt32(Console.ReadLine ());
    double S = Math.PI*Math.Pow(R, 2);
    double S1 = Math.Round(S,0);
    string str = S1.ToString();
    int max = int.Parse(str[0].ToString());
 
            for (int i = 1; i < str.Length; i++)
            {
                if (max < int.Parse(str[i].ToString()))
                    max = int.Parse(str[i].ToString());
            }
                Console.WriteLine("Наибольшей цифрой в округленном числе найденной площади ( S = " + S1 + " ) является " + max);
   }