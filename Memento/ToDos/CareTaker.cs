using System.Collections.Generic;

namespace Memento.ToDos
{
    class CareTaker
    {
        private Dictionary<string, Memento> history;
        public CareTaker()
        {
            history = new Dictionary<string, Memento>();
        }
        public void Save(string name, Memento state)
        {
            history[name] = state; 
        }
        public Memento GetState(string name)
        {
            return history[name];
            
        }

        //public Memento PreviousState { get; set; }
    }

}
