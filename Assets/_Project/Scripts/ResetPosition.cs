using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    private Vector3 startPosition;
    private Quaternion startRotation;
    private Vector3 startScale;

    private void Awake()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
        startScale = transform.localScale;
    }

    private void OnEnable()
    {
        EventManager.OnReset += ResetTransform;
    }

    private void OnDisable()
    {
        EventManager.OnReset -= ResetTransform;
    }

    public void ResetTransform()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
        transform.localScale = startScale;
    }
}
