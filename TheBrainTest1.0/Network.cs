using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBrainTest1_0
{
    class Network
    {
        Node[] inputNodes;  //each of these three node arrays keep track of specific sets of nodes
        Node[] innerNodes;  
        Node[] outputNodes;

        List<FiringTime> firingQueue;   //the firing queue holds a list that contains a seperate list for each different firing time

        int time;   //keeps track of time for the network

        /// <summary>
        /// Generate the network
        /// </summary>
        /// <param name="numInput">Number of Input neurons, which should correlate to the number of inputs the network will handle</param>
        /// <param name="numOutput">Number of Output neurons, which should correlate to the number of outputs the network will handle</param>
        /// <param name="numInner">Number of Inner neurons, which will make up the reserviour</param>
        /// <param name="avgConnections">Average number of connections each neuron will have</param>
        /// <param name="maxFiringTime">Max </param>
        Network(int numInput, int numOutput, int numInner, int avgConnections, int maxFiringTime)
        {
            createInnerNodes(numInner, avgConnections);
            createInputNodes(numInput);
            createOutputNodes(numOutput);
        }

        private void createInnerNodes(int numInner, int avgConnections)
        {
            inputNodes = new Node[numInner];

        }
    }
}
