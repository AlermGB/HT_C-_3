// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27

// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите положительное целое число, не равное нулю: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int degree = 3;
int outputNumber = 1;
Console.Write(outputNumber);
if (number > 0) {
    for(int counter = 2; counter<=number; counter++){
        for(int i = 1; i<=degree; i++){
            outputNumber=outputNumber*counter;
        }
        Console.Write($", {outputNumber}");
        outputNumber = 1;
    }
    
}
else  {
    Console.WriteLine("Некорректное число!");
}