using UnityEngine;

namespace ScriptableObjects.Coins
{
    [CreateAssetMenu(fileName = "Coin",menuName = "Money/Coin")]
    public class Coin : ScriptableObject
    {
        [SerializeField] private int coinCount;
        [SerializeField] private Sprite _sprite;

        public int CoinCount => coinCount;
        public Sprite Sprite => _sprite;
    }
}