using Assets.Entities.Characters.NewPlayerController;
using Assets.Scenes.Player.NewPlayerController.Tools;
using UnityEngine;

public class VCamMain : ACamera
{
    public float speed = 5;

    public override void Move(Vector2 mouseVector, GameObject player)
    {
        var timeSpeed = Time.deltaTime * speed;

        var playerController = player.GetComponent<IPlayerController>();
        // Debug.Log("MouseVector : " + mouseVector);
        if(mouseVector.x != 0)
            playerController.Rotate(mouseVector.x * speed);
        transform.Rotate(new Vector3(-mouseVector.y, 0, 0) * timeSpeed, Space.Self);
        var rotation = gameObject.transform.localRotation.eulerAngles;
        rotation.Set(Tools.ClampAngle(transform.localRotation.eulerAngles.x, -80f, 80f),
            transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z);
        transform.localEulerAngles = rotation;
    }

    public override void ResetPosition(Vector3 mainCameraPosition)
    {

    }

    public override void SetDeltaPosition(Vector3 mainCameraPosition)
    {

    }
}
