using LinQ.Lists;
namespace LinQ.ILinQOperations;

public interface ISelectPeople
{
    public void Execute(List<Person> listOfPeople);
}
