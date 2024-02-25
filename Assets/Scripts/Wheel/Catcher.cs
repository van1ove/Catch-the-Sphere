using Score;
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
            
            if(sphere.SphereType == SphereType.ScoreSphere) 
                ScoreController.SetNewScore.Invoke();
        }
    }
}