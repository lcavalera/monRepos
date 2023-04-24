
using System;


namepace H23_DevInfo
{
    public class Chat: Animal
{
    public string Nom { get; set; }
    public int Age { get; set; }

    public void Bondir()
    {
        Console.WriteLine($"{Nom} bondit!");
    }

    public void Miauler()
    {
        Console.WriteLine($"{Nom} miaule!");
    }
}
}