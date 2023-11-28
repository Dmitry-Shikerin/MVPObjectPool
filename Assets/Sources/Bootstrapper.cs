using Sources.CommandCenters;
using UnityEngine;

namespace Sources
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private CommandCenterView _commandCenterView;
        [SerializeField] private CommandCenterUi _commandCenterUi;

        private void Awake()
        {
            CommandCenter commandCenter = new CommandCenter();
            
            new CommandCenterViewFactory().Create(_commandCenterView, commandCenter);
            new CommandCenterUiFactory().Create(_commandCenterUi, commandCenter);
        }
    }
}