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


//bool stan = true;
//while (stan==true) {
//    Zadanie2();
//}
Zadanie1();
Zadanie2();
Zadanie3();
Zadanie4();
Zadanie5();
Zadanie6();
Zadanie7();

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
    Console.WriteLine("\n\n\n==============ZADANIE 1==============\n\n\n");
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
    Console.WriteLine("\n\n\n==============ZADANIE 2==============\n\n\n");
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
    Console.WriteLine("\n\n\n==============ZADANIE 3==============\n\n\n");
    double[] table = new double[10];
    AddToArray(table);


    Console.WriteLine("1. Wyświetlanie tablicy od pierwszego do ostatniego indeksu ");
    Console.WriteLine("2. Wyświetlanie tablicy od ostatniego do pierwszego indeksu.");
    Console.WriteLine("3. Wyświetlanie elementów o parzystych indeksach.");
    Console.WriteLine("4. Wyświetlanie elementów o nieparzystych indeksach.");

    double choice;
    do
    {
        choice = InputDouble();
        if (choice == 1)
        {
            FromFirstToLast(table);
        }
        else if (choice == 2)
        {
            FromLastToFirst(table);
        }
        else if (choice == 3)
        {
            DisplayEvenNumbers(table);
        }
        else if (choice == 4)
        {
            DisplayOddNumbers(table);
        }

    } while (choice != 5);


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
//Koniec Zadania 3 

//Zadanie 4 

void Zadanie4()
{
    Console.WriteLine("\n\n\n==============ZADANIE 4==============\n\n\n");
    double[] table = new double[10];
    AddToArray(table);
    CalculateArrSum(table);
    CalculateArrProduct(table);
    CalculateArrAvg(table);
    FindMinValue(table);
    FindMaxValue(table);

}

double CalculateArrSum(double[] table)
{
    double sum = 0;
    foreach (double value in table) { sum += value; };
    Console.WriteLine("Suma elementów Tablicy Wynosi: " + sum);
    return sum;

}

void CalculateArrProduct(double[] table)
{
    double product = 1;
    foreach (double value in table) { product *= value; };
    Console.WriteLine("Iloczyn Elementów Tablicy wynosi: " + product);
}

void CalculateArrAvg(double[] table)
{
    double sum = CalculateArrSum(table);
    double avg = sum / table.Length;
    Console.WriteLine("Wartość średnia wynosi: " + avg);
}

void FindMinValue(double[] table)
{
    double minValue = 0;
    foreach (double value in table)
    {
        if (value < minValue) minValue = value;
    }
    Console.WriteLine("Najmniejsza wartość to: " + minValue);
}
void FindMaxValue(double[] table)
{
    double maxValue = 0;
    foreach (double value in table)
    {
        if (value > maxValue) maxValue = value;
    }
    Console.WriteLine("Najwieksza wartość to: " + maxValue);
}

//Koniec Zadania 4 

//Zadanie 5 

void Zadanie5()
{
    Console.WriteLine("\n\n\n==============ZADANIE 5==============\n\n\n");
    for (int i = 20; i >= 0; i--)
    {
        if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
        {
            continue;
        }
        Console.Write(i + ", ");
    }
}

void Zadanie6()
{
    Console.WriteLine("\n\n\n==============ZADANIE 6==============\n\n\n");
    while (true)
    {
        Console.WriteLine("Podaj Liczby calkowite");
        int number = (int)InputDouble();
        if (number < 0) break;
    }
}

void Zadanie7()
{
    Console.WriteLine("\n\n\n==============ZADANIE 7==============\n\n\n");

    Console.WriteLine("Podaj Ile liczb chcesz pisac");
    int n = (int)InputDouble();
    double[] numbers = new double[n];
    AddNToArr(numbers, n);
    Console.WriteLine("Liczby Przed sortowaniem:");
    ShowArr(numbers);
    BubbleSort(numbers);
    Console.WriteLine("\n Liczby Po sortowaniem:");
    ShowArr(numbers);

}

void AddNToArr(double[] numbers, int n)
{
    Console.WriteLine("Podaj Wartości do wpisania do Tablicy");
    for (int i = 0; i < n; i++)
    {
        numbers[i] = InputDouble();
    }
}

void ShowArr(double[] numbers)
{
    foreach (var element in numbers)
    {
        Console.Write(element + ", ");
    }
}

void BubbleSort(double[] numbers)
{
    int n = numbers.Length;
    bool changed;
    do
    {
        changed = false;
        for (int i = 1; i < n; i++)
        {
            if (numbers[i - 1] > numbers[i])
            {
                double temp = numbers[i - 1];
                numbers[i - 1] = numbers[i];
                numbers[i] = temp;
                changed = true;
            }

        }

    } while (changed);
}