using Practice14_Grebenukov;

static string CheckString()
{
    while (true)
    {
        Console.WriteLine("Введите строку");
        bool test = false;
        string str = Console.ReadLine();
        if(str.Length == 0)
            Console.WriteLine("Вы ввели пустую строку");
        else
        {
            foreach(char c in str)
            {
                if (!char.IsLetter(c))
                    test = true;

            }
            if (test == true)
            {
                Console.WriteLine("Можно использовать только буквы");
            }
            else
                return str;
        }
    }
}
static string CheckAddress()
{
    while (true)
    {
        Console.WriteLine("Ввведите строку");
        bool test = false;
        string str = Console.ReadLine();
        if (str.Length == 0)
            Console.WriteLine("Вы ввели пустую строку");
        else
        {
            return str;
        }
    }
}
static int CheckNumber()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                return number;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка! Повторите ввод");
        }
    }
}
static double CheckDoubleNumber()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Введите число");
            double number  = Convert.ToDouble(Console.ReadLine());
            if (number > 0)
            {
                return number;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка! Повторите ввод");
        }
    }
}
static int CheckYear()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Введите год");
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number < 2024)
            {
                return number;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка! Повторите ввод");
        }
    }
}

List<SubjectOfInsurance> insurance = new List<SubjectOfInsurance>();
while (true)
{
    Console.WriteLine("Добавить? Да/Нет");
    if (Console.ReadLine() == "Да")
    {
        Console.WriteLine("Недвижимость(1) или автомобиль(2)? 1/2");
        string answer = Console.ReadLine();
        if (answer == "1")
        {
            Console.WriteLine("Введите марку машины, год изготовления, фамилию страховщика, предмет страховки, стоимость страховки, срок страховки");
            insurance.Add(new Car(CheckString(), CheckYear(), CheckString(), CheckString(), CheckDoubleNumber(), CheckNumber()));
        }
        else if (answer == "2")
        {
            Console.WriteLine("Введите адрес , фамилию страховщика, предмет страховки, стоимость страховки, срок страховки");
            insurance.Add(new RealEstate(CheckAddress(), CheckString(), CheckString(), CheckDoubleNumber(), CheckNumber()));
        }
        else
            Console.WriteLine("Выберите 1 или 2");
    }
    else
        break;
}
foreach (SubjectOfInsurance dogovor in insurance)
{
    dogovor.Info();
}

insurance.ForEach(delegate (SubjectOfInsurance test)
{
    Console.WriteLine(test.Info());
});