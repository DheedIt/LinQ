using LinQ.Lists;

namespace LinQ.LinQOperations.AbstractClasses
{
    abstract public class AddInfoOperation : AbstractOperation
    {
        abstract public void Add(List<Person> list);
    }
}
