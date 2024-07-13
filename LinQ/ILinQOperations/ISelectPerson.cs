using LinQ.Lists;
namespace LinQ.ILinQOperations;

public interface ISelectPerson
{
    public List<Person> Select(List<Person> listOfPeople);
}
