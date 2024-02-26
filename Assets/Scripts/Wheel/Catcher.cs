using Managers;
using Score;
using Spawner;
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
                ScoreController.SetNewScore?.Invoke();
                Destroy(sphere.gameObject);
            }
                
            else
            {
                SpheresSpawner.StopSpawning();
                TimeManager.PauseTime();
            }
                
        }
    }
}