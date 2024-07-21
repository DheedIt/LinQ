using LinQ.ILinQOperations;
using LinQ.LinQOperations.AbstractClasses;
using LinQ.Lists;
using LinQ.Request;
using System.Diagnostics.Eventing.Reader;

namespace LinQ.LinQOperations
{
    internal class GroupByElements : AbstractOperation, IGroupByElements
    {
        public override string Name => "Группировка по признаку";
        public override void Execute(List<Person> list)
        {
            Console.Clear();
            var listOfGroups = new List<string>()
            {
                new string("Имя"),
                new string("Возраст"),
                new string("Компания"),
                new string("Язык")
            };
            for(int i = 0; i < listOfGroups.Count; i++)
            {
                Console.WriteLine($"{i+1}, {listOfGroups[i]}");
            }
            Console.WriteLine("Выберите признак");
            RequestNumber numberToGet = new RequestNumber();
            int num = numberToGet.Get();
            if(num == 1)
            {
                var newList = list.GroupBy(p => p.Name);
                foreach (var p in newList)
                {
                    Console.WriteLine($"-{p.Key}");
                    foreach (var p2 in p)
                    {
                        Console.WriteLine($"{p2?.Name}, {p2?.Age}, {p2?.Company}, {p2?  .Language}");
                    }
                }
                
            }
            else if(num  == 2)
            {
                    var newList = list.GroupBy(p => p.Age);
                foreach (var p in newList)
                {
                    Console.WriteLine($"-{p.Key}");
                    foreach (var p2 in p)
                    {
                        Console.WriteLine($"{p2?.Name}, {p2?.Age}, {p2?.Company}, {p2?.Language}");
                    }
                }

            }
            else if(num == 3)
            {
                var newList = list.GroupBy(p => p.Company);
                foreach (var p in newList)
                {
                    Console.WriteLine($"-{p.Key}");
                    foreach (var p2 in p)
                    {
                        Console.WriteLine($"{p2?.Name}, {   p2?.Age}, {p2?.Company}, {p2?.Language}");
                    }
                }
            }
            else if (num == 4)
            {
                var newList = list.GroupBy(p => p.Language);
                foreach (var p in newList)
                {
                    Console.WriteLine($"-{p.Key}");
                    foreach (var p2 in p)
                    {
                        Console.WriteLine($"{p2?  .Name}, {p2?.Age}, { p2?.Company}, {    p2?.Language}");
                    }
                }
            }

        }
    }
}
