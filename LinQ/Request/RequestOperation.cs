using LinQ.LinQOperations;

namespace LinQ.Request
{
    internal class RequestOperation
    {
        public AbstractOperation Request(int number, List<AbstractOperation> list) {

            return list.ElementAt(number);
        }
    }
}
