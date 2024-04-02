using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Dynamic;
using System.Text;
public interface IComponent 
{
    string Operation();
}
public class DecoratorA : IComponent
{ 
    private readonly IComponent _component;
    public DecoratorA(IComponent component)
    {
        _component = component ?? throw new ArgumentNullException(nameof(component));

    }

    public string Operation()
    {
        var result = _component.Operation();
        return $"<DecoratorA>{result}</DecoratorA>";
    }
}
public class DecoratorB : IComponent
{
    private readonly IComponent _component;
    public DecoratorB(IComponent component)
    {
        _component = component ?? throw new ArgumentNullException(nameof(component));

    }
    public string Operation()
    {
        var result = _component.Operation();
        return $"<DecoratorA>{result}</DecoratorA>";
    }
}

public class Component : IComponent
{
    
    public string Operation()
    {
        return "<a>Test</a>";
    }
}

public class Program
{
    private static void Main(string[] args)
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<IComponent>(serviceProvider => new DecoratorA(new DecoratorB(new Component())) );
        var Instance = new DecoratorA(new DecoratorB(new Component()));
        Console.WriteLine(Instance.Operation());
        Console.ReadLine();

    }


}

