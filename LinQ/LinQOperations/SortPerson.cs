using LinQ.Lists;
using LinQ.Features;
using LinQ.ILinQOperations;
namespace LinQ.LinQOperations;

internal class SortPerson : ISortPerson
{
    public List<Person> Sort(List<Person> persons)
    {
        var SortedPersons = persons.OrderByDescending(p => p.Company, new CustomComparer())
            .ThenByDescending(p => p.Language, new CustomComparer())
            .ThenByDescending(p => p.Name);
        foreach (var p in SortedPersons)
        {
            Console.WriteLine($"{p.Name}, {p.Age}, {p.Company}, {p.Language}");
        }
        return SortedPersons.ToList();
    }
}
