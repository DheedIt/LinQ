using System.Dynamic;

namespace LinQ.Request
{
    public class RequestNumber
    {
        public int Get()
        {
            Console.Write(": ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
