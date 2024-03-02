using Managers;
using UnityEngine;
using Sphere;

namespace Wheel
{
    [RequireComponent(typeof(CircleCollider2D))]
    public class Catcher : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (!col.gameObject.TryGetComponent(out MovingSphere sphere)) return;

            if (sphere.Type == SphereType.ScoreSphere)
            {
                EventManager.Instance.InvokeIncreaseScore();
                Destroy(sphere.gameObject);
            }
                
            else
            {
                EventManager.Instance.InvokeEndGame();
            }
                
        }
    }
}