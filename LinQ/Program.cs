using LinQ.Lists;

namespace LinQ;
class Program
{ //Меню с операциями и списком в дб
    static void Main(string[] args)
    {
        var listOfPeople = new List<Person>()
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
        /*
        var secondListOfPeople = new List<Person>()
        {
            new Person("Andrew", 15, "Rostelecom", "C++"),
            new Person("Ura", 23, "Tele2", "C#"),
        };
        var difficultListOfPeople = new List<DifficultPerson>()
        {
            new DifficultPerson("Ilya", 18, new List<string>{"C++","C#" }),
            new DifficultPerson("Roma", 24, new List<string>{"Python","C#" }),
            new DifficultPerson("Sasha", 25, new List<string>{"C++","Assembler" }),
            new DifficultPerson("Egor", 18, new List<string>{"Russian"}),
        };
        // SelectPerson selectString = new SelectPerson();
        // selectString.SelectAll(listOfPeople);
        //SelectPersonWithNLenght selectPersonWithNLenght = new SelectPersonWithNLenght(listOfPeople);
        //SelectUsingDiffucultFilter selectUsingDiffucultFilter = new SelectUsingDiffucultFilter(difficultListOfPeople);
        SortPerson sortPerson = new SortPerson(listOfPeople);
        */
    }
    
}
