using Sources.ObjectPool;
using UnityEngine;

namespace Sources.CommandCenters
{
    public interface ICommandCenterView
    {
        IObjectPool ObjectPool { get; }
        ICollectorViewFactory CollectorFactory { get; }
        
        Vector3 Position { get; }
        Vector3[] Targets { get; }
    }
}