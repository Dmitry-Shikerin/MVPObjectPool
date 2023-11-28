using Sources.Collectors;
using UnityEngine;

namespace Sources.CommandCenters
{
    public interface ICollectorViewFactory
    {
        ICollectorView Create(ICommandCenterView view, Vector3 spawnPosition);
    }
}