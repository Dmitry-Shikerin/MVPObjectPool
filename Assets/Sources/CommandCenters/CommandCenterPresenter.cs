using Sources.CommandCenters;
using Sources.Common;
using UnityEngine;

public class CommandCenterPresenter : PresenterBase
{
    private readonly ICommandCenterView _view;
    private readonly CommandCenter _commandCenter;

    public CommandCenterPresenter(ICommandCenterView view, CommandCenter commandCenter)
    {
        _view = view;
        _commandCenter = commandCenter;
    }

    public void CreateCollector()
    {
        Vector3 spawnPosition = _view.Position + Quaternion.Euler(0, Random.Range(0, 360), 0) * Vector3.forward * 20;

        _commandCenter.AddCollector(_view.CollectorFactory.Create(_view, spawnPosition));
    }

    public void SendCollector()
    {
        _commandCenter.SendCollector(GetTarget());
    }

    private Vector3 GetTarget()
    {
        return _view.Targets[Random.Range(0, _view.Targets.Length)];
    }
}