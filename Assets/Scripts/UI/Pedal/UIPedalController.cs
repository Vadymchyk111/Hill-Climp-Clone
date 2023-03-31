using UI.Button;
using UnityEngine;

namespace UI.Pedal
{
    public class UIPedalController : MonoBehaviour
    {
        [SerializeField] private PedalView _pedalView;
        [SerializeField] private CustomButton _button;

        private void OnEnable()
        {
            _button.OnClick += _pedalView.SetActivePedal;
        }

        private void OnDisable()
        {
            _button.OnClick -= _pedalView.SetActivePedal;
        }
    }
}