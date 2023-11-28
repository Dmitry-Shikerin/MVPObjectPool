using Sources.Common;
using UnityEngine;

namespace Sources.Collectors
{
    public class CollectorView : PresentableView<CollectorPresenter>, ICollectorView
    {
        public void Destroy()
        {
            if (TryGetComponent(out PoolableObject poolableObject) == false)
                Destroy(gameObject);

            poolableObject.ReturnToPool();
        }

        public void SetPosition(Vector3 position) => 
            transform.position = position;

        public void MoveTo(Vector3 position)
        {
            Presenter.MoveTo(position);
        }

        public Vector3 Position => transform.position;
        public void SetCommandCenter(CommandCenter commandCenter)
        {
            Presenter.SetCommandCenter(commandCenter);
        }
    }
}