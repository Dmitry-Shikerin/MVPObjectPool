using System.Collections.Generic;
using System.Linq;
using Sources.Collectors;
using Sources.CommandCenters;
using Sources.Common;
using Sources.ObjectPool;
using UnityEngine;

[RequireComponent(typeof(CollectorPool))]
public class CommandCenterView : PresentableView<CommandCenterPresenter>, ICommandCenterView
{
    [SerializeField] private CollectorViewFactory _collectorFactory;
    [SerializeField] private List<Transform> _targets;
    
    public ICollectorViewFactory CollectorFactory => _collectorFactory;
    
    public Vector3 Position => transform.position;

    public IObjectPool ObjectPool { get; private set; }
    public Vector3[] Targets { get; set; }

    private void Awake()
    {
        Targets = _targets.Select(target => target.position).ToArray();
        ObjectPool = GetComponent<CollectorPool>();
    }

    public void CreateCollector() => 
        Presenter.CreateCollector();

    public void SendCollector() => 
        Presenter.SendCollector();
}