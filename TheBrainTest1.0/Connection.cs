using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBrainTest1_0
{
    class Connection
    {
        public double weight;
        public Node node;   //this is the node that is fired to
        public int time;    //time to send synapse to next neuron

        /// <summary>
        /// Make a new connection
        /// </summary>
        /// <param name="w">Connection weight</param>
        /// <param name="n">Neuron being fired to</param>
        /// <param name="t">Time to send synapse to next neuron</param>
        public Connection(double w, Node n, int t)
        {
            weight = w;
            node = n;
            time = t;
        }
    }
}
