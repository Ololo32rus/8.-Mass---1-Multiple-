// дан массив. 1) Сумм нечетных 2) Сумму, кратных заданному 3) Сумму элементов кратных, а или b

int SumOdd = 0;
int SumMultiple = 0;
int SumMultipleTwo1 = 0;
int SumMultipleTwo2 = 0;
int a, b;
int mas;

Random rnd = new Random();

Console.Write($" Введите любое число = ");
mas = int.Parse(Console.ReadLine());

int [] Allmas = new int[mas];


for (int i = 0; i < Allmas.Length; i++)
{
    {
        Allmas[i] = rnd.Next(1, 100);
    }
    
    Console.WriteLine($"{Allmas[i]}");

    if (Allmas[i] %2 == 1)
    {
        SumOdd += Allmas[i];
    }
 
}

Console.WriteLine($" Сумма нечетных чисел из массива = {SumOdd} ");

Console.WriteLine($" Введите число 'a' : " );
   a = int.Parse(Console.ReadLine());

for (int i = 0; i < Allmas.Length; i++)

    if (Allmas[i] % a == 0)   // не понятно как идя по индексам, найти кратное числу
    {
        SumMultiple += Allmas[i];
    }

Console.WriteLine($"Сумма кратных числу 'a' = {SumMultiple}");

Console.WriteLine($" Введите число 'a' :");
a = int.Parse(Console.ReadLine());

Console.WriteLine($" Введите число 'b' : ");
b = int.Parse(Console.ReadLine());

for (int i = 0; i < Allmas.Length; i++)

    if (Allmas[i] % a == 0)   // не понятно как идя по индексам, найти кратное числу
    {
        SumMultipleTwo1 += Allmas[i];
    }
    else if (Allmas[i] % b == 0)
    {
        SumMultipleTwo2 += Allmas[i];
    }

Console.WriteLine($"Сумма кратных числу 'a' или 'b' = {SumMultipleTwo1 + SumMultipleTwo2}");