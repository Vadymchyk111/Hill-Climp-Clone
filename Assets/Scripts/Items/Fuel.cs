using System;
using Car;
using UnityEngine;

namespace Items
{
    public class Fuel : MonoBehaviour
    {
        private readonly float _fuelCount = 0.25f;

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (!col.gameObject.CompareTag("Player"))
            {
                return;
            }
            
            PlayerStats playerStats = col.gameObject.GetComponentInParent<PlayerStats>();

            if (playerStats == null)
            {
                return;
            }
            
            playerStats.RecoveryFuel(_fuelCount);
            Destroy(gameObject);
        }
    }
}