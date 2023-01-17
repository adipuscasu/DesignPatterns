// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");
OfficeApp app = new PPTApp();

app.NewDocument();

app = new WordApp();
app.NewDocument();

app = new ExcelApp();
app.NewDocument();