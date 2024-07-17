using LinQ.Lists;

namespace LinQ.LinQOperations.AbstractClasses
{
   abstract public class SelectOperations : AbstractOperation
    {
        abstract public void Select(List<Person> list);
    }
}
