namespace task_2;

public abstract class Animal
{
    public string Name { get; set; }

    // methods
    public void SetName(string _name)
    {
        Name = _name;
    }
    public string GetName()
    {
        return Name;
    }

    // abstract methods
    public abstract void Eat();



}
