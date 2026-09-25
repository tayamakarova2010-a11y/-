using System;

class Program
{
    static void Main()
    {
        Box box = new Box();
        box.Width = 2;
        box.Height = 3;
        box.Length = 5;

        box.Show();
        float volume = box.Volume();
        Console.WriteLine($"Объем коробки = {volume}");

        Console.ReadLine();
    }
}

class Box
{
    public double Width;
    public double Height;
    public double Length;

    public void Show()
    {
        Console.WriteLine($"Коробка: ширина = {Width}, высота = {Height}, длина = {Length}");
    }

    public float Volume()
    {
        return (float)(Width * Height * Length);
    }
}
