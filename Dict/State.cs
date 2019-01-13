using System.Collections.Generic;

namespace Dict
{
    public class State
    {
        public string Capital { get; set; }
        public int Population { get; set; }
        public int Size { get; set; }

        public State(string capital, int pop, int size)
        {
            Capital = capital;
            Population = pop;
            Size = size;
        }

        //static method
        public static Dictionary<string, State> GetStates()
        {
            var states = new Dictionary<string, State>();
            var theState = new State("Gandhinagar", 123456, 123);
            states.Add("Gujarat", theState);
            theState = new State("Jaipur", 3983282, 3833);
            states.Add("Rajasthan", theState);
            return states;
        }

       
    }
}