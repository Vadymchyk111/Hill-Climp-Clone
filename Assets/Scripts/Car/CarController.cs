using System.Collections;
using ScriptableObjects.Events;
using ScriptableObjects.Settings;
using UnityEngine;

namespace Car
{
    public class CarController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _frontTire;
        [SerializeField] private Rigidbody2D _backTire;
        [SerializeField] private CarMoveSettings _carMoveSettings;
        [SerializeField] private ScriptableObjectFloatEvent _carMoveEvent;

        private bool _isMoving;
        private Coroutine _movingCoroutine;
        private readonly WaitForSeconds _movingDelayInSeconds = new(0.01f);

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
            if (moveDirection != 0 && !_isMoving)
            {
                _isMoving = true;
                
                if (_movingCoroutine != null)
                {
                    StopCoroutine(_movingCoroutine);
                }
                
                _movingCoroutine = StartCoroutine(MovingCoroutine(moveDirection));
            }
            else
            {
                _isMoving = false;
            }
        }

        private IEnumerator MovingCoroutine(float moveDirection)
        {
            while (_isMoving)
            {
                _frontTire.AddTorque(-moveDirection * _carMoveSettings.MoveSpeed * Time.fixedDeltaTime);
                _backTire.AddTorque(-moveDirection * _carMoveSettings.MoveSpeed * Time.fixedDeltaTime);
                yield return _movingDelayInSeconds;
            }
            
        }
    }
}
