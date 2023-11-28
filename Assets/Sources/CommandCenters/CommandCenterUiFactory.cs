namespace Sources.CommandCenters
{
    public class CommandCenterUiFactory
    {
        public ITextUi Create(CommandCenterUi commandCenterUi, CommandCenter commandCenter)
        {
            commandCenterUi.Construct(new CommandCenterUiPresenter(commandCenterUi, commandCenter));
            
            return commandCenterUi;
        }
    }
}