using Microsoft.VisualBasic;
using System.Windows.Forms;
using System;

class Hell
{
    static void Main()
    {
        Console.Title = "Данные";
        Console.Write("Введи что-нибудь: ");

        string name;

        name = Console.ReadLine();

        Console.WriteLine("Понял "+name+"");
    }
}