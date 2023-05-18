using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public int moveSpeed;

    public void InitializePosition( Transform currentTarget )
    {
        transform.position = currentTarget.position + offset;
    }
    // sets the current selected car to the camera target
    public void setTargetPos(Transform currentTarget)
    {
        target = currentTarget;
    }

    // Moves the camera to the current selected target
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * moveSpeed);
        var targetRotation = Quaternion.LookRotation(target.transform.position - transform.position);
    }
}