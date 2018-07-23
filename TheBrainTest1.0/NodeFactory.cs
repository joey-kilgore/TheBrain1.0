using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBrainTest1_0
{
    class NodeFactory
    {
        Random random = new Random();

        /// <summary>
        /// Generate array of nodes each generated with specific connection amounts and firetimes
        /// </summary>
        /// <param name="numNodes">Number of nodes in the array</param>
        /// <param name="avgNumConnections">Average number of connections each node will have</param>
        /// <param name="maxFireTime">Maximum time a neuron will take to fire</param>
        /// <param name="minWeight"></param>
        /// <param name="maxWeight"></param>
        /// <returns></returns>
        public Node[] makeNodes(int numNodes, int avgNumConnections, int maxFireTime, double minWeight, double maxWeight)
        {
            Node[] nodes = new Node[numNodes];
            double connectionPercent = (double)avgNumConnections / (double)numNodes;

            for (int i=0; i<nodes.Length; i++)
            {
                nodes[i] = new Node(maxFireTime);
                for(int j=0; j<nodes.Length; j++)
                {                   
                    if (j != i && random.NextDouble() < connectionPercent)
                    {
                        nodes[i].connections.Add(new Connection()
                    }
                }
            }



        }
    }
}
