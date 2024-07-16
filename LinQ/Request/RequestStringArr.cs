using System.Dynamic;

namespace LinQ.Request
{
    public class RequestStringArr
    {
        public string[] Get()
        {
            
            string[] toReturn = { };
            Console.Write(": ");
            string? usersEnter = Console.ReadLine();
            if (usersEnter != null)
            {
                toReturn = usersEnter.Split(" ");
                return toReturn;
            }
            return null;
        }
    }
}
