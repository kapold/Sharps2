namespace LW2.Composite;

abstract class Component
{
    protected string name;
 
    public Component(string name)
    {
        this.name = name;
    }
 
    public abstract void Display();
    public abstract void Add(Component c); 
    public abstract void Remove(Component c);
}