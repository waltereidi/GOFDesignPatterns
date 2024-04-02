using StrategyPattern;
using StrategyPattern.Interfaces;
using System.Text;

public sealed class SortableColletion
{ 
    public ISortStrategy? SortStrategy { get; set; }
    public IEnumerable<string> Items { get; set; }
    public SortableColletion(IEnumerable<string> items)
    {
        Items = items;
    }
    public void Sort()
    {
        if(SortStrategy == null)
            throw new NullReferenceException();

        Items = SortStrategy.Sort(Items);
    }

}
public class Program
{
    public static readonly SortableColletion _data = new SortableColletion(new[] {"S1" ,"s2" , "S3" , "S4"});
    private static void Main(string[] args)
    {
        SetSortAsc();
        SortData();
        PrintCollection();
        SetSortDesc();
        SortData();
        PrintCollection();
        Console.WriteLine("Sorted string ascending");
        Console.ReadLine();
    }
    public static string PrintCollection()
    {
        var sb = new StringBuilder();

        foreach (var item in _data.Items)
        {
            sb.AppendLine(item);
        }
        Console.WriteLine(sb.ToString());
        return sb.ToString();
    }
    private static string SetSortAsc()
    {
        _data.SortStrategy= new SortAscending();
        return "Ascending sort";
    }
    private static string SetSortDesc()
    {
        _data.SortStrategy = new SortDescending();
        return "Descending sort";
    }
    private static string SortData()
    {
        try
        {
            _data.Sort();
            return "data Sorted";
        }
        catch (NullReferenceException ex)
        {
            return ex.Message;
        }
    }
}

