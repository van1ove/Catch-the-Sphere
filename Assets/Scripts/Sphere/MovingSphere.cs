using System.Collections;
using UnityEngine;

namespace Sphere
{
    [RequireComponent(typeof(CircleCollider2D), typeof(Rigidbody2D))]
    public class MovingSphere : MonoBehaviour
    {
        #region Variables
        
        [SerializeField, Min(0)] private float destroyDelay;
        [SerializeField, Range(0.1f,0.5f)] private float moveDelay;
        [SerializeField, Min(1)] private float moveSpeed;
        
        [field: SerializeField] public SphereType Type { get; private set; }
        
        [SerializeField] private Rigidbody2D rb;
        private Vector2 _direction;

        #endregion

        #region Methods

        private void OnValidate() => rb = GetComponent<Rigidbody2D>();

        public void SetUpSphere(Vector2 direction)
        {
            SetTarget(direction);
            StartCoroutine(PushSphere());
            StartCoroutine(DestroySphere());
        }
        private void SetTarget(Vector2 direction) => _direction = direction;
        
        private IEnumerator PushSphere()
        {
            yield return new WaitForSeconds(moveDelay);
            PushThisSphere();
        }
        private void PushThisSphere() => rb.AddForce(_direction * moveSpeed, ForceMode2D.Impulse);
        
        private IEnumerator DestroySphere()
        {
            yield return new WaitForSeconds(destroyDelay);
            DestroyThisSphere();
        }
        private void DestroyThisSphere() => Destroy(gameObject);

        #endregion
    }
}