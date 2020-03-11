using UnityEngine;

public abstract class ACamera : MonoBehaviour, IMovable
{


    public abstract void Move(Vector2 mouseVector, GameObject player);

    public abstract void ResetPosition(Vector3 mainCameraPosition);

    public abstract void SetDeltaPosition(Vector3 mainCameraPosition);
}
