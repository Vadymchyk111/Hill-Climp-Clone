using ScriptableObjects.Events;
using UnityEngine;

namespace Car
{
    public class CarController : MonoBehaviour
    {
        [SerializeField] private ScriptableObjectFloatEvent _carMoveEvent;

        private void OnEnable()
        {
            _carMoveEvent.OnValueChanged += SetMoveDirection;
        }

        private void OnDisable()
        {
            _carMoveEvent.OnValueChanged -= SetMoveDirection;
        }

        private void SetMoveDirection(float moveDirection)
        {
            print(moveDirection);
        }
    }
}
