using LinQ.ILinQOperations;
using LinQ.LinQOperations.AbstractClasses;
using LinQ.Lists;

namespace LinQ.LinQOperations
{
    public class SelectDistinct : AbstractOperation, ISelectDistinct
    {
        public override string Name => "Показать список без повторений";
        public override void Execute(List<Person> list) {
            Console.Clear();
            var newList = list.Distinct();
            foreach (Person p in list)
            {
                Console.WriteLine($"{p.Name},{p.Age},{p.Company},{p.Language}");
            }
        }
    }
}
