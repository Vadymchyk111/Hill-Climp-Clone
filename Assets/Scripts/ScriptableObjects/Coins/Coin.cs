using UnityEngine;

namespace ScriptableObjects.Coins
{
    [CreateAssetMenu(fileName = "Coin",menuName = "Money/Coin")]
    public class Coin : ScriptableObject
    {
        [SerializeField] private int _coinCount;
        [SerializeField] private Sprite _sprite;

        public int CoinCount => _coinCount;
        public Sprite Sprite => _sprite;
    }
}