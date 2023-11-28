using Sources.Collectors;
using UnityEngine;

namespace Sources.ObjectPool
{
    public interface IObjectPool
    {
        T Get<T>() where T : MonoBehaviour;
        void Return(PoolableObject poolableObject);
    }
}