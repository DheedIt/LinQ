using System.Dynamic;

namespace LinQ.Request
{
    public class RequestString
    {
        public string Get()
        {
            
            Console.Write(": ");
            string? usersEnter = Console.ReadLine();
            if (usersEnter != null)
            {
                return usersEnter;
            }
            return null;
        }
    }
}
