namespace LinQ.Lists
{
    public class ListOfPerson
    {
        List<Person> people;
        public void Create()
        {
            people = new List<Person>()
        {
            new Person("Sanya", 19, "Lesosbor", "C#"),
            new Person("Uliya", 22, "MTS", "Python"),
            new Person("Dasha",14,null,"Python"),
            new Person("Ilya",18,null,"C#"),
            new Person("Daniil", 23, "Vector", "C#"),
            new Person("Vladimir", 22, "FSB", null),
            new Person("Andrew", 23, null, "Python"),
            new Person("Liza", 21, "MTS", "CPP"),
            new Person("Vlad", 16, null, null),
            new Person("Danil", 14, null , null),
            new Person("Sanya", 20, "Dark Project", "C#"),
            new Person("Nikita", 22, "MTS", "Python"),
            new Person("Dasha",14,null,"Python"),
            new Person("Mihail",15,null,"C#"),
            new Person("Daniil", 23, "Vector", "Paskal"),
            new Person("Vladimir", 32, "FSB", null),
            new Person("Andrew", 30, "Mi", "Python"),
            new Person("Ura", 19, "MTS", "CPP"),
            new Person("Vlad", 26, "LG", null),
            new Person("Semen", 10, null , null),
            new Person("Sanya", 19, "Ashan", "C#"),
            new Person("Aik", 22, "Dell", "Python"),
            new Person("Dasha",24,"Mi","Python"),
            new Person("Kirill",18,null,"C#"),
            new Person("Daniil", 23, "Vector", "C#"),
            new Person("Vladimir", -1, "Asus", null),
            new Person("Andrew", 12, null, "Python"),
            new Person("Ura", 13, "MTS", "CPP"),
            new Person("Anton", 16, "Honor", "Rust"),
            new Person("Danil", 15, null , null)
        };
        }
        public List<Person> Get() => people;

    }
}
