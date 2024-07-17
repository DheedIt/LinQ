using LinQ.Lists;
using LinQ.Features;
using LinQ.ILinQOperations;
using LinQ.LinQOperations.AbstractClasses;
namespace LinQ.LinQOperations;

internal class SelectSortedtPeople : SelectOperations, ISelectSortedtPeople
{
    public override string Name => "Показать отстортированный список людей";
    public override void Select(List<Person> list)
    {
        Console.Clear();
        var newList = list.OrderByDescending(p => p.Company, new CustomComparer())
            .ThenByDescending(p => p.Language, new CustomComparer())
            .ThenByDescending(p => p.Name);
        foreach (var p in newList)
        {
            Console.WriteLine($"{p.Name}, {p.Age}, {p.Company}, {p.Language}");
        }
    }
}
