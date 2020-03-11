using UnityEngine;

namespace Assets.Entities.Characters.NewPlayerController
{
    public class CameraCinemachine : MonoBehaviour
    {
        public float speed = 5f;
        public GameObject player;
        public float maxUpCamAngle = 340;
        public float minUpCamAngle = 20;
        public float angularSpeed;
        [SerializeField] private bool _mainCamera;

        private void Awake()
        {
            //controls.Camera.MoveByMouse.started += x => Mouse(x.ReadValue<Vector2>());
        }

        private void Mouse(Vector2 mouseVector)
        {
            var timeSpeed = Time.deltaTime * speed;

            if (_mainCamera)
            {
                var trans = player.transform;
                trans.Rotate(new Vector3(0, mouseVector.x, 0) * timeSpeed, Space.Self);
                transform.Rotate(new Vector3(-mouseVector.y, 0, 0) * timeSpeed, Space.Self);
            }
            else
            {
                transform.RotateAround(player.transform.position , Vector3.up,  angularSpeed * mouseVector.x);
            }

        }

        private void OnEnable()
        {
            //controls.Camera.MoveByMouse.started += x => Mouse(x.ReadValue<Vector2>());
            //controls.Enable();
        }

        private void OnDisable()
        {
            //controls.Camera.MoveByMouse.started -= x => Mouse(x.ReadValue<Vector2>());
            //controls.Disable();
        }

        private float NormalizeXAxis(float xAxis)
        {
            if(xAxis <= maxUpCamAngle && xAxis > 180)
            {
                return maxUpCamAngle;
            }
            if(xAxis >= minUpCamAngle && xAxis < 180)
            {
                return minUpCamAngle;
            }
            return xAxis;
        }
    }
}
