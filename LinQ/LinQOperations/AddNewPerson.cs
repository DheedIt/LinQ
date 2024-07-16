using LinQ.Lists;
using LinQ.Request;

namespace LinQ.LinQOperations
{
    public class AddNewPerson : AbstractOperation
    {
        public override string Name => "Добавить человека в список";
        public override void Select(List<Person> list)
        {
            var addToList = new Person(new RequestString().Get(), new RequestNumber().Get(), new RequestString().Get(), new RequestString().Get());
            list.Add(addToList);
        }
    }
}
