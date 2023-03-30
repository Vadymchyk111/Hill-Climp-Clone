using Car;
using ScriptableObjects.Coins;
using UnityEngine;

namespace Items
{
    public class Money : MonoBehaviour
    {
        [SerializeField] private Coin _coin;
        [SerializeField] private SpriteRenderer _renderer;

        private void Start()
        {
            _renderer.sprite = _coin.Sprite;
        }

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
            
            playerStats.GetMoney(_coin.CoinCount);
            Destroy(gameObject);
        }
    }
}