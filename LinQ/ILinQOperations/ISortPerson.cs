using LinQ.Lists;

namespace LinQ.ILinQOperations
{
    internal interface ISortPerson
    {
        public List<Person> Sort(List<Person> persons);
    }
}
