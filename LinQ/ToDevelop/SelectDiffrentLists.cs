using LinQ.Lists;

namespace LinQ.ToDevelop;

internal class SelectDiffrentLists
{
    public SelectDiffrentLists(List<Person> fl, List<Person> sl)
    {
        var selectLists = fl.SelectMany(f => f.Name,
                                        (f, s) => new
                                        {

                                        });

    }
}

