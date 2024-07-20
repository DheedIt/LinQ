using LinQ.ILinQOperations;
using LinQ.LinQOperations.AbstractClasses;
using LinQ.Lists;
using LinQ.Request;


namespace LinQ.LinQOperations;
internal class SelectPersonWithNLenght : AbstractOperation, ISelectPersonWithNLenght
{
public override string Name => "Показать список людей с определенным возрастом";
    public override void Execute(List<Person> listOfPeople)
    {
        Console.Clear();
        RequestNumber number = new RequestNumber();
        int age = number.Get();
        var newList = listOfPeople.Where(l => l.Age ==age );
        foreach (var p in newList)
        {
            Console.WriteLine($"{p.Name}, {p.Age},{p.Company}, {p.Language}");
        }
    }
}

