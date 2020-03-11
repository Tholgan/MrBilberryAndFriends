using Cinemachine;
using UnityEngine;

public class VCamFree : ACamera
{
    private Vector2 _mouseMovement;

    private void Awake()
    {
        CinemachineCore.GetInputAxis = GetAxisCustom;
    }

    private float GetAxisCustom(string axisName)
    {
        _mouseMovement.Normalize();

        switch (axisName)
        {
            case "Mouse X":
                return _mouseMovement.x;
            case "Mouse Y":
                return _mouseMovement.y;
            default:
                return 0;
        }
    }

    public override void Move(Vector2 mouseVector, GameObject player)
    {
        _mouseMovement = mouseVector;
    }

    public override void ResetPosition(Vector3 mainCameraPosition)
    {

    }

    public override void SetDeltaPosition(Vector3 mainCameraPosition)
    {

    }
}
