using LinQ.ILinQOperations;
using LinQ.LinQOperations.AbstractClasses;
using LinQ.Lists;

namespace LinQ.LinQOperations;
internal class SelectPeople : AbstractOperation, ISelectPeople
{
    
    public override string Name => "Показать список людей";
    public override void Execute(List<Person> listOfPeople)
    {
        Console.Clear();
        var newList = listOfPeople.Select(l => new
        {
            name = l.Name,
            age = l.Age,
            company = l.Company,
            language = l.Language
        });
        foreach (var p in newList)
        {
            Console.WriteLine($"{p?.name}, {p?.age},{p?.company}, {p?.language}");
        }
    }
}

