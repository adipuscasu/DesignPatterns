// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");

UserPrefs pref1 = UserPrefs.GetInstance();
pref1.PrefColor = "blue";

UserPrefs pref2 = UserPrefs.GetInstance();

pref2.PrefColor = "red";

Console.WriteLine($"Pref1: {pref1.PrefColor}");
Console.WriteLine($"Pref2: {pref2.PrefColor}");