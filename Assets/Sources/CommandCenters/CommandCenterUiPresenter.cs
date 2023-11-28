using Sources.Common;

namespace Sources.CommandCenters
{
    public class CommandCenterUiPresenter : PresenterBase
    {
        private readonly ITextUi _textUi;
        private readonly CommandCenter _commandCenter;

        public CommandCenterUiPresenter(ITextUi textUi, CommandCenter commandCenter)
        {
            _textUi = textUi;
            _commandCenter = commandCenter;
        }

        public override void Enable()
        {
            _commandCenter.CollectorsCountChanged += OnCollectorsCountChanged;
        }

        public override void Disable()
        {
            _commandCenter.CollectorsCountChanged -= OnCollectorsCountChanged;
        }

        private void OnCollectorsCountChanged(int count)
        {
            _textUi.SetText(count.ToString());
        }
    }
}