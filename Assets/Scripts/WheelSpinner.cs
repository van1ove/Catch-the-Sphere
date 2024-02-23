using UnityEngine;

public class WheelSpinner : MonoBehaviour
{
    [field:SerializeField] public float SpinCoefficient { get; private set;}

    private readonly Vector3 _axis = Vector3.forward;
    void Update()
    {
        transform.Rotate(_axis * Time.deltaTime * SpinCoefficient);
    }
}
