using UnityEngine;

namespace ScriptableObjects.Settings
{
   [CreateAssetMenu(fileName = "CarMoveSettings", menuName = "Settings/CarMoveSettings")]
   public class CarMoveSettings : ScriptableObject
   {
      [SerializeField] private float _moveSpeed;
      [SerializeField] private float _rotationSpeed;

      public float MoveSpeed => _moveSpeed;
      public float RotationSpeed => _rotationSpeed;
   }
}