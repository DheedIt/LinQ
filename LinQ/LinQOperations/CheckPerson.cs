using LinQ.ILinQOperations;
using LinQ.LinQOperations.AbstractClasses;
using LinQ.Lists;
using LinQ.Request;

namespace LinQ.LinQOperations
{
    public class CheckPerson : AbstractOperation, ICheckPerson
    {
        public override string Name => "Поиск по имени";
        public override void Execute(List<Person> list)
        {
            RequestString name = new RequestString();
            var newList = list.Select(p => p.Name).Contains(name.Get());
            if(newList)
                Console.WriteLine("Person is exist");
        }
    }
}
