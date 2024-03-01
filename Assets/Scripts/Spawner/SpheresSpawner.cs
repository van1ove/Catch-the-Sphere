using System.Collections;
using System.Collections.Generic;
using Sphere;
using UnityEngine;
using UnityEngine.Serialization;
using Random = System.Random;

namespace Spawner
{
    public class SpheresSpawner : MonoBehaviour
    {
        #region Variables

        [SerializeField, Range(1, 100)] private int scoreSpherePercent;
        [SerializeField] private int spawnDelay;
        [SerializeField] private List<MovingSphere> spheres;

        private SphereFactory _sphereFactory;
        private Random _random;

        private static bool _keepSpawning;
        #endregion

        #region TargetsBorder

        [SerializeField] private Transform bottomLeftPoint;
        [SerializeField] private Transform topRightPoint;

        #endregion
        
        #region MonoBehaviorMethods

        private void Start()
        {
            _sphereFactory = new SphereFactory(spheres);
            _random = new Random();
            
            StartSpawning();
            StartCoroutine(SpawnSphere());
        }

        #endregion

        #region OtherMethods
        private IEnumerator SpawnSphere()
        {
            while (_keepSpawning)
            {
                yield return new WaitForSeconds(spawnDelay);
            
                int numb = _random.Next(0, 100);
                MovingSphere sphere = numb <= scoreSpherePercent 
                    ? _sphereFactory.CreateScoreSphere() : _sphereFactory.CreateDeadSphere();
                
                sphere = Instantiate(sphere, transform.position, Quaternion.identity);
                sphere.SetUpSphere(CreateDirectionVector());
            }
        }

        private Vector2 CreateDirectionVector()
        {
            Vector2 direction = Vector2.zero;
            direction.x = (float)(_random.NextDouble() * 
                (topRightPoint.position.x - bottomLeftPoint.position.x) + bottomLeftPoint.position.x);
                
            direction.y = (float)(_random.NextDouble() * 
                (topRightPoint.position.y - bottomLeftPoint.position.y) + bottomLeftPoint.position.y);
            direction.Normalize();
            return direction;
        }
        
        public void StopSpawning() => _keepSpawning = false;

        private void StartSpawning() => _keepSpawning = true;
        #endregion
    }
}