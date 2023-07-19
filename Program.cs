int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void Task25()
{
    //     Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16
    int A = Input("введите число А ");
    int B = Input("введите число B ");
    double result = Math.Pow(A, B);
    Console.WriteLine($"число А = {A} в степени B = {B} равно {result}");
}


void Task27()
{
//     Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
    int A = Input("введите число А ");
    int sum = 0;
    int i = 10;
    while (A>0)
    {
        sum = sum + A%i;
        A = A/i;
    }
    Console.WriteLine($"Сумма цифр числа A = {sum}");

}

void Task29()
{
//     Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
// 6, 1, -33 -> [1, 6, -33]
    Random rnd = new Random();
    int size = 8;
    int[]numbers = new int[size];
    for (int i=0; i<size; i++)
    {
        numbers[i]=rnd.Next(-15, 15); // работает и без заданных значений, просто хотела проверить что отрицательные числа анализируются по модулю
    }
    for(int i=0; i<size; i++)
    {
        Console.Write($"{numbers[i]}; ");
    }

    Console.WriteLine();
    
    int current_index = 0;
    int min_index=0;
    int temp1=0;
    int temp2=0;
    int count = 0;

    while(current_index<size)
    {
        while(current_index<size)
        {
            if (Math.Sqrt(Math.Pow(numbers[current_index], 2))<Math.Sqrt(Math.Pow(numbers[min_index],2)))
            {
                temp1=numbers[min_index];
                temp2=numbers[current_index];
                numbers[min_index]=temp2;
                numbers[current_index]=temp1;
            }
            current_index++;
        }
        Console.Write($"{numbers[min_index]}; ");
        count++;
        min_index=0+count;
        current_index=0+count;
    }
}

Task29();
