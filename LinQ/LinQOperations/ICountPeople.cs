using LinQ.ILinQOperations;
using LinQ.Lists;

namespace LinQ.LinQOperations
{
    public class ICountPeople : AbstractClasses.AbstractOperation, ILinQOperations.ICountPeople
    {
        public override string Name => "Подсчет людей в списке";
        public override void Execute(List<Person> list)
        {
            Console.WriteLine(list.Count()); 

        }
    }
}
