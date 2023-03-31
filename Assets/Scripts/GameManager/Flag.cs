using System;
using UnityEngine;
using Constants;

namespace GameManager
{
    public class Flag : MonoBehaviour
    {
        public event Action OnReachedPoint;

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (!col.gameObject.CompareTag(PlayerConstants.PLAYER_TAG))
            {
                return;
            }
        
            OnReachedPoint?.Invoke();
        }
    }
}