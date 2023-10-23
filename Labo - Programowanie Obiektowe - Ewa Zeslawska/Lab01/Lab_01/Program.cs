////MAIN
//WriteExample();
//string name = InputName();
//double value = InputDouble();
//View(name, value);
//View("Janina", 12);


//for (int i = 0; i < 10; i++)
//{
//    Console.Write(i + " ");
//}

//Zadanie1();
//Zadanie2();
//bool stan = true;
//while (stan==true) {
//    Zadanie2();
//}
Zadanie3();



////Koniec Main 

//Tutaj są przykłady funkcji 

void WriteExample()
{
    int wiek = 11;
    string name = "ala";
    Console.WriteLine("Imie: " + name + ", wiek: " + wiek);
    Console.WriteLine("Imie:{0}, wiek{1}", name, wiek);
    Console.WriteLine($"Imie {name}, wiek {wiek}");
}

string InputName()
{
    Console.WriteLine("Podaj imie");
    string name = Console.ReadLine();
    return name;
}
double InputDouble()
{
    Console.WriteLine("Podaj wartosc: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

void View(string name, double value)
{
    Console.WriteLine($"Imie: {name}, wartosc: {value}");
}

void Zadanie1()
{
    double a = InputDouble(), b = InputDouble(), c = InputDouble();
    double delta = Math.Pow(b, 2) - (4 * a * c);
    double x1, x2;

    if (a == 0) Console.WriteLine("To nie jest row kwadratowe");
    else if (delta < 0) Console.WriteLine("brak rozwiazan, w zb liczbie rzeczywistej");
    else if (delta == 0)
    {
        x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("Jedno Rozwiazanie x1" + x1);
    }
    else
    {
        x1 = (b - Math.Sqrt(delta)) / (2 * a);
        x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("Jest jedno rozwiazanie x1: " + x1 + ", x2: " + x2);
    }
}

//Zadanie 2 
void Zadanie2()
{
    Menu();
}

void Menu()
{
    Console.WriteLine("Wybierz operację:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Różnica");
    Console.WriteLine("3. Iloczyn");
    Console.WriteLine("4. Iloraz");
    Console.WriteLine("5. Potegowanie");
    Console.WriteLine("6. Pierwiastkowanie");
    Console.WriteLine("7. Trygonometria");
    Console.WriteLine("8. Zakończ");

    int choice = (int)InputDouble();


    switch (choice)
    {
        case 1: Suma(); break;
        case 2: Roznica(); break;
        case 3: Iloczyn(); break;
        case 4: Iloraz(); break;
        case 5: Potegowanie(); break;
        case 6: Pierwiastkowanie(); break;
        case 7: Trygonometria(); break;
        case 8: Wyjscie(); break;
        default: Console.WriteLine("Błędne Dane, Spróbuj jeszcze raz..."); break;
    }

}
void Suma()
{
    Console.WriteLine("Wybrałeś Dodawanie");
    double a = InputDouble(), b = InputDouble();
    double result = a + b;
    Console.WriteLine($"Suma {a} + {b} = {result}");
}
void Roznica()
{
    Console.WriteLine("Wybrałeś Różnice");
    double a = InputDouble(), b = InputDouble();
    double result = a - b;
    Console.WriteLine($"Roznica {a} - {b} = {result}");
}
void Iloczyn()
{
    double a = InputDouble(), b = InputDouble();
    double result = a * b;
    Console.WriteLine($"Iloczyn {a} * {b} = {result}");
}
void Iloraz()
{
    double a = InputDouble(), b = InputDouble();
    double result = a / b;
    Console.WriteLine($"Roznica {a} / {b} = {result}");
}

void Potegowanie()
{
    double a = InputDouble(), b = InputDouble();
    double result = Math.Pow(a, b);
    Console.WriteLine($"Potegowanie {a} do {b} = {result}");
}

void Pierwiastkowanie()
{
    double a = InputDouble();
    double result = Math.Sqrt(a);
    Console.WriteLine($"Wynik Pierwiastka z {a} = {result}");
}
void Trygonometria()
{
    double a = InputDouble();

}

void Wyjscie()
{
    //stan = false;
}

//Koniec Zadania 2 

//Zadanie 3 

void Zadanie3()
{
    double[] table = new double[10];


    Console.WriteLine("1. Wyświetlanie tablicy od pierwszego do ostatniego indeksu ");
    Console.WriteLine("2. Wyświetlanie tablicy od ostatniego do pierwszego indeksu.");
    Console.WriteLine("3. Wyświetlanie elementów o nieparzystych indeksach.");
    Console.WriteLine("4. Wyświetlanie elementów o parzystych indeksach.");

    AddToArray(table);
    FromFirstToLast(table);
    FromLastToFirst(table);
    DisplayEvenNumbers(table);
    DisplayOddNumbers(table);


}

void AddToArray(double[] table)
{

    for (int i = 0; i < 10; i++)
    {
        table[i] = InputDouble();
    }
}

void FromFirstToLast(double[] table)
{
    Console.WriteLine("Wyświetlanie tablicy od pierwszego do ostatniego indesku: ");
    for (int i = 0; i < table.Length; i++)
    {
        Console.Write(table[i] + ", ");
    }

}
void FromLastToFirst(double[] table)
{
    Console.WriteLine("\nWyświetlanie tablicy od ostatniego do pierwszego indeksu: ");
    for (int i = table.Length - 1; i >= 0; i--)
    {
        Console.Write(table[i] + ", ");
    }
}

void DisplayEvenNumbers(double[] table)
{
    Console.WriteLine("\nWyświetlanie elementów o nieparzystych indeksach: ");
    for (int i = 1; i < table.Length; i += 2)
    {
        Console.Write(table[i] + ", ");
    }
}

void DisplayOddNumbers(double[] table)
{
    Console.WriteLine("\nWyświetlanie elementów o parzystych indeksach: ");
    for (int i = 0; i < table.Length; i += 2)
    {
        Console.Write(table[i] + ", ");
    }
}
