using LinQ.Lists;

namespace LinQ.ToDevelop;
internal class SelectUsingDiffucultFilter
{
    public List<Person> Select(List<Person> list)
    {
        var selectPeople = list.OfType<Person>().SelectMany(u => u.Languages, (u, l) => new { DifficultPerson = u, Lang = l })
            .Where(u => u.Lang == "C++" && u.DifficultPerson.Age < 28)
            .Select(u => u.DifficultPerson);
        foreach (var p in selectPeople)
        {
            Console.WriteLine(p.Name);
        }
        return list;
    }
}

