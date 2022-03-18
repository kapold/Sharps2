using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LW2.Composite;

class CAddress : Component
{
    List<Component> children = new List<Component>();
 
    public CAddress(string name) : base(name) { }
 
    public override void Add(Component component)
    {
        children.Add(component);
    }
 
    public override void Remove(Component component)
    {
        children.Remove(component);
    }
 
    public override void Display()
    {
        MessageBox.Show(name);
 
        foreach (Component component in children)
        {
            component.Display();
        }
    }
}