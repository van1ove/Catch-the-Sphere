using UnityEngine;
using UnityEngine.EventSystems;

namespace Wheel
{
    public class WheelController : MonoBehaviour
    {
        #region Variables
        
        [SerializeField, Min(0f)] private float spinSpeed;
        private Vector3 _axis = Vector3.back;
        private bool _inputEnable;

        #endregion
        
        #region MonoBehaviorMethods

        private void Start()
        {
            EnableInput();
        }

        private void Update()
        {
            transform.Rotate(_axis * Time.deltaTime * spinSpeed);
            
            if (!_inputEnable) return;

            if(EventSystem.current.currentSelectedGameObject &&
                EventSystem.current.currentSelectedGameObject.layer == LayerMask.NameToLayer("UI")) return;

            if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                ChangeSpinDirection();
            }
        }

        #endregion

        #region OtherMethods
        private void ChangeSpinDirection()
        {
            _axis = _axis == Vector3.back ? Vector3.forward : Vector3.back;
        }

        public void EnableInput() => _inputEnable = true;
        public void DisableInput() => _inputEnable = false;

        #endregion
    }
}
