using UnityEngine;

namespace ScriptableObjects.Settings
{
   [CreateAssetMenu(fileName = "CarMoveSettings", menuName = "Settings/CarMoveSettings")]
   public class CarMoveSettings : ScriptableObject
   {
      [SerializeField] private float _moveSpeed;
      [SerializeField] private float _acceleration;

      public float MoveSpeed => _moveSpeed;
      public float Acceleration => _acceleration;
   }
}
