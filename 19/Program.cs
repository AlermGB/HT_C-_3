// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int maxBorder = 100000;
int minBorder = 10000;
int lasDigit = number%10;
int firstDigit = number/minBorder;
int secondDigit = (number - firstDigit*minBorder)/1000;
int preLastDigit = number%100/10;
// Console.WriteLine(firstDigit);
// Console.WriteLine(secondDigit);
// Console.WriteLine(preLastDigit);
// Console.WriteLine(lasDigit);
if (number >= minBorder && number < maxBorder) {
    if (firstDigit == lasDigit && secondDigit == preLastDigit) {
        Console.WriteLine("Да");
    }
    else {
        Console.WriteLine("Нет");
    }
    
}

else  {
    Console.WriteLine("Вы ввели неверное число!");
}
