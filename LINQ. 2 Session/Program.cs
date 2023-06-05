using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        var phoneBook = new List<Contact1>();

        // добавляем контакты
        phoneBook.Add(new Contact1("Игорь", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact1("Сергей", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact1("Анатолий", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact1("Валерий", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact1("Сергей", 799900000013, "serg@gmail.com"));
        phoneBook.Add(new Contact1("Иннокентий", 799900000013, "innokentii@example.com"));

        var sort = phoneBook.GroupBy(c => c.Email.Split("@").Last());

        foreach (var group in sort)
        {
            if (group.Key.Contains("example"))
            {
                Console.WriteLine("Fake");
                foreach (var gr in group)
                {
                    Console.WriteLine(gr.Name + " " + gr.Email);
                }
            }
            else
            {
                Console.WriteLine("True");
                foreach (var item in group)
                {
                    Console.WriteLine(item.Name + " " + item.Email);
                }
            }
            
        }
    }
}

class Contact1
{
    public Contact1(string name, long phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }

    public string Name { get; set; }
    public long Phone { get; set; }
    public string Email { get; set; }
}
class Collec
{
    public void Collec1()
    {
        var collec = new List<int>();
        while (true)
        {
            int number = (Convert.ToInt32(Console.ReadLine()));
            collec.Add(number);

            Console.WriteLine(collec.Count);
            Console.WriteLine(collec.Sum());
            Console.WriteLine(collec.Max());
            Console.WriteLine(collec.Min());
            Console.WriteLine(collec.Average());
        }
    }
}
class Averag
{
    static double Average(int[] numbers)
    {
        return numbers.Sum() / (double)numbers.Length;
    }
}
class Contact
{
    public string Name { get; set; }
    public long Phone { get; set; }
}
class Nophone
{
    static long Factorial(int number)
    {
        var chis = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            chis.Add(i);
        }

        long result = chis.Aggregate((x, y) => x * y);
        return result;
    }
    static void Numbers() 
    {
        var contacts = new List<Contact>()
{
   new Contact() { Name = "Андрей", Phone = 79994500508 },
   new Contact() { Name = "Сергей", Phone = 799990455 },
   new Contact() { Name = "Иван", Phone = 79999675334 },
   new Contact() { Name = "Игорь", Phone = 8884994 },
   new Contact() { Name = "Анна", Phone = 665565656 },
   new Contact() { Name = "Василий", Phone = 3434 }
};

        var trues = (from contact in contacts // пробегаемся по контактам
                     let phoneString = contact.Phone.ToString() // сохраняем в промежуточную переменную строку номера телефона
                     where !phoneString.StartsWith('7') || phoneString.Length != 11 // выполняем выборку по условиям
                     select contact) // добавляем объект в выборку
    .Count();


        Console.WriteLine(trues);
    }
}
class Prog
{
    void Prog1()
    {
        var a = "Привет";
        var b = "Покаие";

        var ab = a.Intersect(b);
        foreach (var x in ab)
            Console.WriteLine(x);

        var softwareManufacturers = new List<string>()
{
   "Microsoft", "Apple", "Oracle"
};

        var hardwareManufacturers = new List<string>()
{
   "Apple", "Samsung", "Intel"
};

        var itCompanies = softwareManufacturers.Union(hardwareManufacturers);

        foreach (var x in itCompanies)
        {
            Console.WriteLine(x);
        }
        string text = Console.ReadLine();

        var simbols = new List<char> { ' ', ',', '.', ';', ':', '!', '?' };

        var ar = text.Except(simbols).ToArray();

        Console.WriteLine(ar);
    }
}