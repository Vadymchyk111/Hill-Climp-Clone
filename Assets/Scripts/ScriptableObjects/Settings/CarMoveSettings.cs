using UnityEngine;

namespace ScriptableObjects.Settings
{
   [CreateAssetMenu(fileName = "CarMoveSettings", menuName = "Settings/CarMoveSettings")]
   public class CarMoveSettings : ScriptableObject
   {
      [SerializeField] private float _moveSpeed;

      public float MoveSpeed => _moveSpeed;
   }
}