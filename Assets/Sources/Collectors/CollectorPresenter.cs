using Cysharp.Threading.Tasks;
using Sources.Common;
using UnityEngine;

namespace Sources.Collectors
{
    public class CollectorPresenter : PresenterBase
    {
        private readonly ICollectorView _view;
        private readonly Collector _collector;

        public CollectorPresenter(ICollectorView view, Collector collector)
        {
            _view = view;
            _collector = collector;
        }

        public async void MoveTo(Vector3 position)
        {
            _collector.SetDestination(position);
            await MoveAsync();
            _collector.SetDestination(new Vector3(0,0,0));
            await MoveAsync();
            _collector.CommandCenter.AddCollector(_view);
        }

        private async UniTask MoveAsync()
        {
            while (Vector3.Distance(_collector.Destination, _view.Position) > 0.02f)
            {
                Vector3 position = Vector3.MoveTowards(_view.Position, _collector.Destination, Time.deltaTime * 10);
                _view.SetPosition(position);
                
                await UniTask.Yield();
            }
        }

        public void SetCommandCenter(CommandCenter commandCenter)
        {
            _collector.SetCommandCenter(commandCenter);
        }
    }
}