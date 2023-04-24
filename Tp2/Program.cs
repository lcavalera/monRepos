using System;


namepace H23_DevInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var felix = new Chat();
            felix.Nom = "Felix";
            felix.Age = 2;

            felix.Bondir();
        }
    }
}