using ScriptableObjects.Events;
using UnityEngine;
using Constants;

namespace Items
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] private ScriptableObjectFloatEvent _addFuelEvent;
        
        private readonly float _fuelCount = 0.25f;

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (!col.gameObject.CompareTag(PlayerConstants.PLAYER_TAG))
            {
                return;
            }
        
            _addFuelEvent.ChangeValue(_fuelCount);
            Destroy(gameObject);
        }
    }
}