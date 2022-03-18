using System.Collections.Generic;

namespace LW2;

public class State
{
    public string? location { set; get; }
    public string? value { set; get; }

    public State(string Location, string Value)
    {
        location = Location;
        value = Value;
    }
    
    public State()
    {
        location = null;
        value = null;
    }
    
    public static class StateControl
    {
        public static Stack<State> undoStack { get; set; } = new Stack<State>();
        public static Stack<State> redoStack { get; set; } = new Stack<State>();
    }
}