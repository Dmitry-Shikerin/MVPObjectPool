using Sources.ObjectPool;
using UnityEngine;

namespace Sources.Collectors
{
    public class PoolableObject : MonoBehaviour
    {
        private IObjectPool _pool;

        public PoolableObject SetPool(IObjectPool pool)
        {
            _pool = pool;

            return this;
        }

        public void ReturnToPool() =>
            _pool.Return(this);
    }
}