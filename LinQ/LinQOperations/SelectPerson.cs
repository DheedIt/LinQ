using LinQ.ILinQOperations;
using LinQ.Lists;

namespace LinQ.LinQOperations;
internal class SelectPerson : ISelectPerson
{
    public List<Person> Select(List<Person> listOfPeople)
    {
        var selectAllList = listOfPeople.Select(l => new
        {
            name = l.Name,
            age = l.Age,
            company = l.Company,
            language = l.Language
        });
        foreach (var p in selectAllList)
        {
            Console.WriteLine($"{p?.name}, {p?.age},{p?.company}, {p?.language}");
        }
        return listOfPeople.ToList();
    }
}

