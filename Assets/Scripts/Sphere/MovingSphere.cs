using UnityEngine;

namespace Sphere
{
    [RequireComponent(typeof(CircleCollider2D))]
    public class MovingSphere : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [field: SerializeField] public SphereType SphereType { get; private set; }
    }
}