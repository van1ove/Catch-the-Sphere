using System.Collections;
using UnityEngine;

namespace Sphere
{
    [RequireComponent(typeof(CircleCollider2D), typeof(Rigidbody2D))]
    public class MovingSphere : MonoBehaviour
    {
        #region Variables

        [SerializeField] private float destroyDelay;
        [SerializeField] private float moveSpeed;
        [field: SerializeField] public SphereType Type { get; private set; }
        
        private Rigidbody2D _rb;
        private Vector2 _direction;

        #endregion

        #region Methods

        public void SetUpSphere(Vector2 direction)
        {
            _rb = GetComponent<Rigidbody2D>();
            
            SetTarget(direction);
            PushSphere();
            StartCoroutine(DestroySphere());
        }
        private void SetTarget(Vector2 direction) => _direction = direction;

        private void PushSphere()
        {
            //_rb = GetComponent<Rigidbody2D>();
            _rb.AddForce(_direction * moveSpeed, ForceMode2D.Impulse);
        }

        private IEnumerator DestroySphere()
        {
            yield return new WaitForSeconds(destroyDelay);
            DestroyThisSphere();
            
        }
        private void DestroyThisSphere() => Destroy(gameObject);

        #endregion
    }
}