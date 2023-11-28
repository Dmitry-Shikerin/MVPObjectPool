namespace Sources.CommandCenters
{
    public class CommandCenterViewFactory
    {
        public ICommandCenterView Create(CommandCenterView view, CommandCenter commandCenter)
        {
            view.Construct(new CommandCenterPresenter(view, commandCenter));
            
            return view;
        }
    }
}