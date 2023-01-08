using OHCE;
using OHCE.Console;
using System;

var ohce = new Ohce(new SystemLang(), SystempériodeJournee.GetPeriodeJournee);

Console.WriteLine(ohce.Saluer());

Console.WriteLine("Entrez un mot pour savoir si c'est un palindrome : ");

Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));