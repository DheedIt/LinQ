using Castle.Components.DictionaryAdapter.Xml;
using Castle.Facilities.Startable;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using LinQ.ILinQOperations;
using LinQ.LinQOperations.AbstractClasses;
using LinQ.Lists;
using LinQ.Request;

namespace LinQ;
class Program
{ //Меню с операциями и списком в дб
    static void Main(string[] args)
    {
        ListOfPerson list = new ListOfPerson();
        RequestNumber number = new RequestNumber();
        ListOfOperations operations = new ListOfOperations();
        RequestOperation requestOperation = new RequestOperation();
        list.Create();
        
        try
        {
            while (true) { Start(list, number,operations,requestOperation); }
            
        }
        catch (Exception exep)
        {
            Console.Clear();
            Console.WriteLine(exep.Message);
        }
    }
    public static void Start(ListOfPerson list, RequestNumber number, ListOfOperations operations, RequestOperation requestOperation)
    {
        
        int i = 0;
        foreach(var o in operations.Get())
        {
            Console.WriteLine($"{i+1}.{o.Name}");
            ++i;
        }
        AbstractOperation operation = requestOperation.Request(number.Get()-1, operations.Get());
        operation.Select(list.Get());
        Console.ReadLine();
        Console.Clear();
    }
    
}
