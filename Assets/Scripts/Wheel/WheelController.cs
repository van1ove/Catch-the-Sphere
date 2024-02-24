using UnityEngine;

namespace Wheel
{
    public class WheelController : MonoBehaviour
    {
        [SerializeField] private float spinSpeed;
        private Vector3 _axis = Vector3.back;

        #region MonoBehaviorMethods
        private void Update()
        {
            transform.Rotate(_axis * Time.deltaTime * spinSpeed);
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                ChangeSpinDirection();
            }
        }
        #endregion

        private void ChangeSpinDirection()
        {
            _axis = _axis == Vector3.back ? Vector3.forward : Vector3.back;
        }
    }
}
