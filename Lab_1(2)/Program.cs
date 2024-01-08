using System;

public class Rectangle
{
    private double side1;
    private double side2;

    // Пользовательский конструктор
    public Rectangle(double sideA, double sideB)
    {
        side1 = sideA;
        side2 = sideB;
    }

    // Метод для вычисления площади
    private double CalculateArea()
    {
        return side1 * side2;
    }

    // Метод для вычисления периметра
    private double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    // Свойство для получения площади
    public double Area
    {
        get { return CalculateArea(); }
    }

    // Свойство для получения периметра
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main()
    {
        // Ввод данных от пользователя
        Console.Write("Введите длину первой стороны прямоугольника: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите длину второй стороны прямоугольника: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        // Создание объекта прямоугольника
        Rectangle rectangle = new Rectangle(sideA, sideB);

        // Вывод результатов
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
    }
}