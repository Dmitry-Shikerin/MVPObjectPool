using Sources.Common;
using TMPro;
using UnityEngine;

namespace Sources.CommandCenters
{
    public class TextUi<T> : PresentableView<T>, ITextUi where T : IPresenter
    {
        [SerializeField] private TextMeshProUGUI _text;

        public virtual void SetText(string text)
        {
            _text.text = text;
        }
    }
}