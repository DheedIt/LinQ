using LinQ.Lists;

namespace LinQ.LinQOperations
{
   public abstract class AbstractOperation
    {
        public abstract void Select(List<Person> list);
        public abstract string Name { get; }
    }
}
