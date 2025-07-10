using UnityEngine;

public class ViewDependentReflectionProbeProjection : MonoBehaviour
{
    private Transform _cameraTransform;
    private ReflectionProbe _thisReflectionProbe;

    private Vector3 _thisProbeStartPosition;

    private void Awake()
    {
        _thisReflectionProbe = GetComponent<ReflectionProbe>();

        _cameraTransform = Camera.main.transform;

        _thisProbeStartPosition = transform.position;
    }

    private void Update()
    {
        _thisReflectionProbe.center = _thisProbeStartPosition - _cameraTransform.position;
        transform.position = _cameraTransform.position;
    }
}
