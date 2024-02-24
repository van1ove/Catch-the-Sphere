using UnityEngine;

namespace Wheel
{
    [RequireComponent(typeof(CircleCollider2D))]
    public class Catcher : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent(out Sphere.Sphere sphere))
            {
                
            }
        }
    }
}