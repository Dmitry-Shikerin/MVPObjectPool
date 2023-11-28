
using UnityEngine;

namespace Sources.Collectors
{
    public interface ICollectorView
    {
        void Destroy();
        void SetPosition(Vector3 position);
        void MoveTo(Vector3 position);
        Vector3 Position { get; }
        void SetCommandCenter(CommandCenter commandCenter);
    }
}