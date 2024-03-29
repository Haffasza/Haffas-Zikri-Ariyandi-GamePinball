using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float returnTime;
    public float followSpeed;
    public float length;

    private Vector3 defaultPosition; // Keep only one declaration of defaultPosition

    public bool hasTarget { get 
    { 
        return target != null; 
        } 
    }
    
    // Start is called before the first frame update
    private void Start()
    {
        defaultPosition = transform.position;
        target = null;
    }

    private void Update()
    {
        if (hasTarget)
        {
            Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
            Vector3 targetPosition = target.position + (targetToCameraDirection * length);

            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }

    public void FollowTarget(Transform targetTransform, float targetLength)
    {
        StopAllCoroutines();
        target = targetTransform;
        length = targetLength;
    }

    // public void FocusAtTarget(Transform targetTransform)
    // {
    //     target = targetTransform;

    //     Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
    //     Vector3 targetPosition = targetTransform.position + (targetToCameraDirection * length);

    //     StartCoroutine(MovePosition(targetPosition, returnTime));
    // }

    public void GoBackToDefault()
    {
        
        target = null;
        StopAllCoroutines();
        StartCoroutine(MovePosition(defaultPosition, returnTime));
    }

    private IEnumerator MovePosition(Vector3 target, float time)
    {
        float timer = 0;
        Vector3 start = transform.position;

        while (timer < time)
        {
            transform.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0.0f, 1.0f, timer/time));

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        transform.position = target;
    }
}
