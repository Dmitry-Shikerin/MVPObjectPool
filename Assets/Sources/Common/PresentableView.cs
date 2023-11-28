using System;
using UnityEngine;

namespace Sources.Common
{
    public class PresentableView<T> : MonoBehaviour where T: IPresenter
    {
        protected T Presenter { get; private set; }

        public void OnEnable() => 
            Presenter?.Enable();
        
        public void OnDisable() => 
            Presenter?.Disable();

        public void Hide() => 
            gameObject.SetActive(false);
        
        public void Show() =>
            gameObject.SetActive(true);

        public void Construct(T presenter)
        {
            Hide();
            Presenter = presenter;
            Show();
        }
    }
}