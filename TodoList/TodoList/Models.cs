using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;

namespace TodoList
{
    /// <summary>
    /// Represents all of the entire todo list
    /// </summary>
    class Todo : RealmObject
    {
        public string TodoMessage = "";
        public bool isTodoDone = false;
    }
}
