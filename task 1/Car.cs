namespace task_1;

public class Car : IVehicle
{

    int gasoline;
    public Car(int _gasoline)
    {
        gasoline = _gasoline;
    }

    public void Drive()
    {
        if (gasoline > 0)
        {
            System.Console.WriteLine("Driving");
        }
    }

    public bool Refuel(int refuel)
    {
        gasoline = refuel;
        return true;
    }


}
