// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double squareOfDifference(double firstNumber, double secondNumber) {
    double result = (secondNumber-firstNumber)*(secondNumber-firstNumber);
    return result;
}


Console.WriteLine("Введите координату X точки A: ");
double Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A: ");
double Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A: ");
double Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X точки B: ");
double Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
double By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
double Bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(squareOfDifference(Bx, Ax)+
                            squareOfDifference(By, Ay)+
                            squareOfDifference(Bz, Az));
double roundDistance = Math.Round(distance,2);
Console.WriteLine($"Расстояние между A и B равно {roundDistance}");

