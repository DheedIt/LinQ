using LinQ.Lists;
using LinQ.Request;

namespace LinQ.LinQOperations
{
    internal class SelectCertainLanguageWithPeople : AbstractOperation
    {
        public override string Name => "Подсчет людей с определенным языком программирования";
        public override void Select(List<Person> listOfPeople)
        {

            listOfPeople.Select(x=> x.Language).Intersect(new RequestStringArr().Get());
            
            foreach (var p in listOfPeople)
        {
            Console.WriteLine($"{p.Name}, {p.Age},{p.Company}, {p.Language}");
        }
        }

    }
}
