namespace Sources.CommandCenters
{
    public class CommandCenterUi: TextUi<CommandCenterUiPresenter>
    {
        public override void SetText(string text)
        {
            base.SetText($"Коллекторы: {text}");
        }
    }
}