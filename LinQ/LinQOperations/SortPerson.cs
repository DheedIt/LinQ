using LinQ.Lists;
using LinQ.Features;
using LinQ.ILinQOperations;
namespace LinQ.LinQOperations;

internal class SortPerson : AbstractOperation
{
    public override string Name => "Показать отстортированный список людей";
    public override void Select(List<Person> persons)
    {
        Console.Clear();
        var newList = persons.OrderByDescending(p => p.Company, new CustomComparer())
            .ThenByDescending(p => p.Language, new CustomComparer())
            .ThenByDescending(p => p.Name);
        foreach (var p in newList)
        {
            Console.WriteLine($"{p.Name}, {p.Age}, {p.Company}, {p.Language}");
        }
    }
}
