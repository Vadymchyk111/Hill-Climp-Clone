using ScriptableObjects.Events;
using UI.Button;
using UnityEngine;

namespace UI.Car
{
    public class UICarController : MonoBehaviour
    {
        [SerializeField] private ScriptableObjectFloatEvent _carMoveEvent;
        [SerializeField] private CustomButton _buttonMoveForvard;
        [SerializeField] private CustomButton _buttonMoveBackward;

        private void OnEnable()
        {
            _buttonMoveForvard.OnClick += MoveForward;
            _buttonMoveBackward.OnClick += MoveBackward;
        }

        private void OnDisable()
        {
            _buttonMoveForvard.OnClick -= MoveForward;
            _buttonMoveBackward.OnClick -= MoveBackward;
        }

        private void MoveForward(bool isMove)
        {
            _carMoveEvent.ChangeValue(isMove ? 1f : 0f);
        }
        
        private void MoveBackward(bool isMove)
        {
            _carMoveEvent.ChangeValue(isMove ? -1f : 0f);
        }
    }
}