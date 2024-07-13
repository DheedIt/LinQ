using LinQ.Lists;

namespace LinQ.ILinQOperations
{
    internal interface ISelectPersonWithNLenght
    {
        public List<Person> Select(List<Person> listOfPeople, int lenght);
    }
}
