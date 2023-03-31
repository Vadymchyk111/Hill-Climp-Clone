using UnityEngine;
using UnityEngine.UI;

namespace UI.Pedal
{
    public class PedalView : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private Sprite _activePedal;
        [SerializeField] private Sprite _deactivePedal;

        public void SetActivePedal(bool isActive)
        {
            _image.sprite = isActive ? _activePedal : _deactivePedal;
        }
    }
}