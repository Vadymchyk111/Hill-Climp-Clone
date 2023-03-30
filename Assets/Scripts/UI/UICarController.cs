using System;
using ScriptableObjects.Events;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UICarController : MonoBehaviour
    {
        [SerializeField] private ScriptableObjectFloatEvent _carMoveEvent;
        [SerializeField] private Button _buttonMoveForvard;
        [SerializeField] private Button _buttonMoveBackward;

        private void OnEnable()
        {
            _buttonMoveForvard.onClick.AddListener(MoveForward);
            _buttonMoveBackward.onClick.AddListener(MoveBackward);
        }

        private void OnDisable()
        {
            _buttonMoveForvard.onClick.RemoveListener(MoveForward);
            _buttonMoveBackward.onClick.RemoveListener(MoveBackward);
        }

        private void MoveForward()
        {
            _carMoveEvent.ChangeValue(1f);
        }
        
        private void MoveBackward()
        {
            _carMoveEvent.ChangeValue(-1f);
        }
    }
}
