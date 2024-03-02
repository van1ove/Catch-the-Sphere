using System;
using System.Collections.Generic;
using Sphere;
using UnityEngine;

namespace Spawner
{
    public class SphereFactory
    {
        #region Variables

        private readonly List<MovingSphere> _spheres;
        private Dictionary<SphereType, MovingSphere> _spheresDictionary;

        #endregion
        
        #region InitMethods

        public SphereFactory(List<MovingSphere> spheres)
        {
            _spheres = spheres;
            CreateCollection();
        }
        private void CreateCollection()
        {
            _spheresDictionary = new Dictionary<SphereType, MovingSphere>();
            try
            {
                foreach (MovingSphere sp in _spheres)
                {
                    _spheresDictionary.Add(sp.Type, sp);
                }
            }
            catch (ArgumentException e)
            {
                Debug.LogError(e);
            }
        }

        #endregion
        
        #region CreationMethods

        public MovingSphere CreateDeadSphere() => _spheresDictionary[SphereType.DeadSphere];

        public MovingSphere CreateScoreSphere() => _spheresDictionary[SphereType.ScoreSphere];

        #endregion
    }
}