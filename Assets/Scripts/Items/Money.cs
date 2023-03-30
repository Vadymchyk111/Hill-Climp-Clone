using PlayerPrefsValues;
using ScriptableObjects.Coins;
using UnityEngine;

namespace Items
{
    public class Money : MonoBehaviour
    {
        [SerializeField] private Coin _coin;
        [SerializeField] private SpriteRenderer _renderer;
        [SerializeField] private ScriptableObjectInt _moneyCount;

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
            
            _moneyCount.ChangeValue(_moneyCount.Value.RestoreValue() + _coin.CoinCount, true);
            Destroy(gameObject);
        }
    }
}