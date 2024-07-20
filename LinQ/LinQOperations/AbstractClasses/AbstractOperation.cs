using LinQ.Lists;

namespace LinQ.LinQOperations.AbstractClasses
{
    public abstract class AbstractOperation
    {
        public abstract string Name { get; }
        public abstract void Execute(List<Person> list);
    }
}
