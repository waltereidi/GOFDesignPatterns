using FactoryPattern.Interfaces;
using System.Text;

public class LowGradeCar : ICar { }
public class LowGradeBike : IBike { }
public class HighGradeCar : ICar { }
public class HighGradeBike : IBike { }

public class LowGradeVechicleFactory : IVechicleFactory
{
    public IBike CreateBike() => new LowGradeBike();

    public ICar CreateCar() => new LowGradeCar();
}
public class HighGradeVechicleFactory : IVechicleFactory
{
    public IBike CreateBike() => new HighGradeBike();

    public ICar CreateCar() => new HighGradeCar();
}

public class Program() 
{ 
    public static void Main(string[] args)
    {

    }
}
