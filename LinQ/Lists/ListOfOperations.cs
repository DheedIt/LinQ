using LinQ.LinQOperations;
using LinQ.LinQOperations.AbstractClasses;

namespace LinQ.Lists
{
    public class ListOfOperations
    {
        public List<AbstractOperation> Get()
        {
            var listOfOperations = new List<AbstractOperation> {
            new SelectPeople(),
            new SelectPersonWithNLenght(),
            new SelectSortedtPeople(),
            new SelectAvargeAge(),
            new SelectCertainLanguageWithPeople(),
            new SelectExeptLanguageWithPeople(),
            new AddNewPerson(),
            new SelectDistinct()
        };
            return listOfOperations;
        }
    }
}
