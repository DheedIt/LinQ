using LinQ.ILinQOperations;
using LinQ.LinQOperations.AbstractClasses;
using LinQ.Lists;


namespace LinQ.LinQOperations
{
    public class SelectAvargeAge : AbstractOperation, ISelectAvargeAge
    {
        public override string Name => "Выбрать людей чей возраст является усредненным числом";
        public override void Execute(List<Person> list)
        {
            Console.Clear();
            int AvargeAge = (int)list.Average(p => p.Age);
            var newList = list.Where(x=> x?.Age == AvargeAge && (x!= null || x?.Age!= -1));
            foreach (var p in newList)
            {
                Console.WriteLine($"{p?.Name}, {p?.Age},{p?.Company}, {p?.Language}");
            }
        }
    }
}
