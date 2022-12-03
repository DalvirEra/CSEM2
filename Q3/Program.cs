Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int numberInInt;
bool IsInt = int.TryParse(number,out numberInInt);
if (IsInt)
    {
    if (numberInInt%7 == 0 && numberInInt%23 == 0)
        {
        Console.WriteLine("Да");
        }
    else 
        {
        Console.WriteLine("Нет");
        }
    }
else 
    {
    Console.WriteLine("Введено не число");
    }