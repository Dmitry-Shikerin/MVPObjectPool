
using UnityEngine;

namespace Sources.Collectors
{
    public class Collector
    {
        public CommandCenter CommandCenter;
        public Vector3 Destination { get; private set; }

        public void SetDestination(Vector3 destination)
        {
            Destination = destination;
        }

        public void SetCommandCenter(CommandCenter commandCenter)
        {
            CommandCenter = commandCenter;
        }
    }
}