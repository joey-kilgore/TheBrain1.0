using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBrainTest1_0
{
    enum NodeAction { Firing, PostFiring, NotFiring}

    class Node
    {
        public double[] potential;
        public double[] changePotential;
        public NodeAction[] fireTimes;

        public List<Connection> connections = new List<Connection>();

        public Node(int maxFireTimes)
        {
            potential = new double[maxFireTimes];
            changePotential = new double[maxFireTimes];
            fireTimes = new NodeAction[maxFireTimes];
        }
    }
}
