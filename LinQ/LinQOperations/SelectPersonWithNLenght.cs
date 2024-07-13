using LinQ.ILinQOperations;
using LinQ.Lists;

namespace LinQ.LinQOperations;

internal class SelectPersonWithNLenght : ISelectPersonWithNLenght
{
    public List<Person> Select(List<Person> listOfPeople, int lenght)
    {
        var selectAllList = listOfPeople.Where(l => l.Age == lenght);
        foreach (var p in selectAllList)
        {
            Console.WriteLine($"{p.Name}, {p.Age},{p.Company}, {p.Language}");
        }
        return selectAllList.ToList();
    }
}

