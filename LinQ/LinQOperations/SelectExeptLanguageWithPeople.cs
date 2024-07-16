using LinQ.Lists;
using LinQ.Request;

namespace LinQ.LinQOperations
{
    internal class SelectExeptLanguageWithPeople : AbstractOperation
    {
        public override string Name => "Подсчет людей с определенным языком программирования который не должен включать определенные языки";
        public override void Select(List<Person> listOfPeople)
        {
            RequestStringArr stringArr = new RequestStringArr();
            listOfPeople.Select(x=> x.Language).Except(stringArr.Get()); // ??????????????????????????????
            
            foreach (var p in listOfPeople)
        {
            Console.WriteLine($"{p.Name}, {p.Age},{p.Company}, {p.Language}");
        }
        }

    }
}
