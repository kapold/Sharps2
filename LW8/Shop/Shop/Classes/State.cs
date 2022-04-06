using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Classes
{
    public static class State
    {
        public static Stack<List<Book>> undoBooks = new Stack<List<Book>>();
        public static Stack<List<Book>> redoBooks = new Stack<List<Book>>();

    }
}
