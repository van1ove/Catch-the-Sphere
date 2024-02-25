using System.Collections;
using System.Collections.Generic;
using Sphere;
using UnityEngine;
using Random = System.Random;

namespace Spawner
{
    public class SpheresSpawner : MonoBehaviour
    {
        #region Variables

        [SerializeField] private int spawnDelay;
        [SerializeField] private List<MovingSphere> spheres;

        private SphereFactory _sphereFactory;
        private Random _random;

        public static bool KeepSpawning;
        #endregion

        #region MonoBehaviorMethods

        private void Start()
        {
            _sphereFactory = new SphereFactory(spheres);
            _random = new Random();
            KeepSpawning = true;
            StartCoroutine(SpawnSphere());
        }

        #endregion

        #region OtherMethods
        private IEnumerator SpawnSphere()
        {
            while (KeepSpawning)
            {
                yield return new WaitForSeconds(spawnDelay);
            
                int numb = _random.Next(0, 100);
                MovingSphere sphere = numb < 80 ? _sphereFactory.CreateScoreSphere() : _sphereFactory.CreateDeadSphere();
                Instantiate(sphere, transform.position, Quaternion.identity);
            }
        }
        #endregion
    }
}