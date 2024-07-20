using LinQ.ILinQOperations;
using LinQ.LinQOperations.AbstractClasses;
using LinQ.Lists;
using LinQ.Request;

namespace LinQ.LinQOperations
{
    internal class GroupByElements : AbstractOperation, IGroupByElements
    {
        public override string Name => "Группировка по признаку";
        public override void Execute(List<Person> list)
        {
            Console.Clear();
            var listOfGroups = new List<string>()
            {
                new string("Имя"),
                new string("Возраст"),
                new string("Компания"),
                new string("Язык")
            };
            for(int i = 0; i < listOfGroups.Count; i++)
            {
                Console.WriteLine($"{i+1}, {listOfGroups[i]}");
            }
            Console.WriteLine("Выберите признак");
            RequestNumber num = new RequestNumber();
            var newList = list.GroupBy(p => (num.Get() == 1 ?? p.Name))
        }
    }
}
