using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        List<int> a = new List<int> { 1, 2, 3, 4 };

        var c = a.Where(c => c > 2).ToArray();
        a.Add(6);

        Console.WriteLine("Добавляем эллемент после выполнения");
        foreach (var t in c)
        {
            Console.WriteLine(t);
        }

        a.Add(6);
        var n = a.Where(b => b > 2).ToArray();

        Console.WriteLine("А тут до выполнения");
        foreach (var t in c)
        {
            Console.WriteLine(t);
        }

        Console.WriteLine("Итоговое значение нашей коллекции");

        foreach (var t in a)
        Console.WriteLine(t);
    }
}
class Dep
{
    public void Dep1()
    {
        var departments = new List<Department>()
{
   new Department() {Id = 1, Name = "Программирование"},
   new Department() {Id = 2, Name = "Продажи"}
};

        var employees = new List<Employee>()
{
   new Employee() { DepartmentId = 3, Name = "Инна", Id = 1},
   new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
   new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
   new Employee() { DepartmentId = 1, Name = "Альберт ", Id = 4},
};

        var cow = from emp in departments
                  join exp in employees on emp.Id equals exp.DepartmentId
                  select new
                  {
                      Name = exp.Name,
                      NameN = emp.Name,
                      Id = exp.Id,
                  };

        foreach (var a in cow)
        {
            Console.WriteLine(a.Name + " " + a.NameN + " " + a.Id);
        }

        var res = departments.GroupJoin(employees, m => m.Id, c => c.DepartmentId,
        (m, c) => new
        {
            NameN = m.Name,
            Name = c.Select(e => e.Name),
        });

        foreach (var b in res)
        {
            Console.WriteLine(b.NameN);

            foreach (var e in b.Name)
                Console.WriteLine(e);
        }
    }
}
class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
}
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DepartmentId { get; set; }
}