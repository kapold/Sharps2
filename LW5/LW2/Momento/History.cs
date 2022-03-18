using System.Collections.Generic;

namespace LW2;

public class History
{
    public Stack<Memento> history { get; private set; }
    public History()
    {
        history = new Stack<Memento>();
    }
}