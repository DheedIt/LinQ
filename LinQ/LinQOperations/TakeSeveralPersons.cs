using LinQ.ILinQOperations;
using LinQ.LinQOperations.AbstractClasses;
using LinQ.Lists;
using LinQ.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.LinQOperations
{
    internal class TakeSeveralPersons : AbstractOperation, ITakeSeveralPersons
    {
        public override string Name => "Выбрать определенное количество людей";
        public override void Execute(List<Person> list) {
            RequestNumber num = new RequestNumber();
            var newList = list.Take(num.Get());
            foreach ( var p in newList )
            {
                Console.WriteLine($"{p.Name}, {p.Age}, {p.Company}, {p.Language}");
            }
        }   
    }
}
