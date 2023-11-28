using System;
using UnityEngine;

namespace Sources
{
    public class InputService : MonoBehaviour
    {
        [SerializeField] private CommandCenterView _commandCenterView;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                _commandCenterView.CreateCollector();
            }
            
            if (Input.GetKeyDown(KeyCode.C))
            {
                _commandCenterView.SendCollector();
            }
        }
    }
}