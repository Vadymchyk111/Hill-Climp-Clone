using System;
using UnityEngine;

namespace ScriptableObjects.Events
{
    [CreateAssetMenu(fileName = "ScriptableObjectFloatEvent", menuName = "ScriptableObject/Events/ScriptableObjectFloatEvent")]
    public class ScriptableObjectFloatEvent : ScriptableObject
    {
        public event Action<float> OnValueChanged;

        public void ChangeValue(float value)
        {
            OnValueChanged?.Invoke(value);        
        }
    }
}
