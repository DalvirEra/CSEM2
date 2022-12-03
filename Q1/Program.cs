Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int numberInInt;
bool IsInt = int.TryParse(number,out numberInInt);
if (IsInt) 
    {
    if (numberInInt < 100)
        {
        Console.WriteLine("Не трехзначное число");
        }
    Console.WriteLine("Вторая цифра: " + numberInInt/10%10);
    // работает и для чисел больше 999
    }
else
    {
    Console.WriteLine("Не целое число");
    }