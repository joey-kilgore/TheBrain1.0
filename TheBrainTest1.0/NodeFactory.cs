using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBrainTest1_0
{
    class NodeFactory
    {
        static Random random = new Random();

        /// <summary>
        /// Generate array of nodes each generated with specific connection amounts and firetimes
        /// Connections are all contained within this array of nodes
        /// </summary>
        /// <param name="numNodes">Number of nodes in the array</param>
        /// <param name="avgNumConnections">Average number of connections each node will have</param>
        /// <param name="maxFireTime">Maximum time a neuron will take to fire</param>
        /// <returns></returns>
        public static Node[] makeNodes(int numNodes, int avgNumConnections, int maxFireTime)
        {
            Node[] nodes = new Node[numNodes];
            double connectionPercent = (double)avgNumConnections / (double)numNodes;

            // generate nodes for the entire array
            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i] = new Node(maxFireTime);
            }

            // generate connections between the nodes 
            bool isConnected;
            for (int i = 0; i < nodes.Length; i++)
            {
                isConnected = false;
                for (int j = 0; j < nodes.Length; j++)
                {
                    if (j != i && random.NextDouble() < connectionPercent)
                    {
                        //ADDDDDDDD ABILITY TO SET MIN/MAX WEIGHTS
                        nodes[i].connections.Add(new Connection(random.NextDouble(), nodes[j], random.Next(1, maxFireTime)));
                        isConnected = true;
                    }
                }

                //the node must have atleast 1 connection
                while (!isConnected)
                {
                    int j = random.Next(0, nodes.Length);
                    if (j != i)
                    {
                        nodes[i].connections.Add(new Connection(random.NextDouble(), nodes[j], random.Next(1, maxFireTime)));
                        isConnected = true;
                    }
                }
            }

            return nodes;
        }

        public static Node[] makeInputNodes(int numNodes, int avgNumConnections, int maxFireTime, Node[] nodesToConnectTo)
        {
            Node[] nodes = new Node[numNodes];
            double connectionPercent = (double)avgNumConnections / (double)numNodes;

            // generate nodes for the entire array
            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i] = new Node(maxFireTime);
            }

            // generate connections between the nodes 
            bool isConnected;
            for (int i = 0; i < nodes.Length; i++)
            {
                isConnected = false;
                for (int j = 0; j < nodesToConnectTo.Length; j++)
                {
                    if (j != i && random.NextDouble() < connectionPercent)
                    {
                        //ADDDDDDDD ABILITY TO SET MIN/MAX WEIGHTS
                        nodes[i].connections.Add(new Connection(random.NextDouble(), nodesToConnectTo[j], random.Next(1, maxFireTime)));
                        isConnected = true;
                    }
                }

                //the node must have atleast 1 connection
                while (!isConnected)
                {
                    int j = random.Next(0, nodesToConnectTo.Length);
                    nodes[i].connections.Add(new Connection(random.NextDouble(), nodesToConnectTo[j], random.Next(1, maxFireTime)));
                    isConnected = true;
                }
            }

            return nodes;
        }

        public static Node[] makeOutputNodes(int numNodes, int avgNumConnections, int maxFireTime, Node[] nodesToConnectFrom)
        {
            Node[] nodes = new Node[numNodes];
            double connectionPercent = (double)avgNumConnections / (double)numNodes;

            // generate nodes for the entire array
            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i] = new Node(maxFireTime);
            }

            // generate connections between the nodes 
            bool isConnected;
            for (int i=0; i<nodes.Length; i++)
            {
                isConnected = false;
                for (int j = 0; j < nodesToConnectFrom.Length; j++)
                {
                    if (j != i && random.NextDouble() < connectionPercent)
                    {
                        //ADDDDDDDD ABILITY TO SET MIN/MAX WEIGHTS
                        nodesToConnectFrom[j].connections.Add(new Connection(random.NextDouble(), nodes[i], random.Next(1, maxFireTime)));
                        isConnected = true;
                    }
                }

                //the node must have atleast 1 connection
                while (!isConnected)
                {
                    int j = random.Next(0, nodesToConnectFrom.Length);
                    nodesToConnectFrom[j].connections.Add(new Connection(random.NextDouble(), nodes[i], random.Next(1, maxFireTime)));
                    isConnected = true;
                }
            }

            return nodes;
        }
    }
}
