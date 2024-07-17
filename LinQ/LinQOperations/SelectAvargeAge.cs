﻿using LinQ.ILinQOperations;
using LinQ.LinQOperations.AbstractClasses;
using LinQ.Lists;

namespace LinQ.LinQOperations
{
    public class SelectAvargeAge : SelectOperations, ISelectAvargeAge
    {
        public override string Name => "Выбрать людей чей возраст является усредненным числом";
        public override void Select(List<Person> list)
        {
            int AvargeAge = (int)list.Average(p => p.Age);
            var newList = list.Where(x=> x?.Age == AvargeAge && (x!= null || x?.Age!= -1));
            Console.Clear();
            foreach (var p in newList)
            {
                Console.WriteLine($"{p?.Name}, {p?.Age},{p?.Company}, {p?.Language}");
            }
        }
    }
}
