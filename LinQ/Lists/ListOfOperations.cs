using LinQ.LinQOperations;

namespace LinQ.Lists
{
    public class ListOfOperations
    {
        public List<AbstractOperation> Get()
        {
            var listOfOperations = new List<AbstractOperation> {
            new SelectPerson(),
            new SelectPersonWithNLenght(),
            new SortPerson()
        };
            return listOfOperations;
        }
    }
}
