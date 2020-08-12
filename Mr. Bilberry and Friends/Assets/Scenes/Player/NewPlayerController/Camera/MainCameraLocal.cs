using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Cinemachine;
using UnityEngine;

using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

namespace Assets.Entities.Characters.NewPlayerController
{
    public class MainCameraLocal : MonoBehaviour
    {
        public GameObject _player;
        public List<ACamera> cameras;

        private bool waitingForCorrection;
        private ACamera mainCam;
        private CinemachineBrain brainCam;
        private Vector2 _vectorMove;
        private Camera _cam;


        private void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            brainCam = GetComponent<CinemachineBrain>();
            _cam = GetComponent<Camera>();


            var getCount = GameObject.FindGameObjectsWithTag("Player");
            var count = getCount.Length;

            mainCam = cameras[0];

            foreach (var cam in cameras)
            {
                cam.SetDeltaPosition(mainCam.transform.position);
                cam.gameObject.SetActive(cam == mainCam);
            }

            Debug.Log("cullingMask : " + _cam.cullingMask);

            /*_cam.cullingMask = 9 + count;
            mainCam.gameObject.layer = gameObject.layer;*/

        }

        public void OnMoveByStick(Vector2 vector2)
        {
            _vectorMove = vector2;
        }

        public void OnMove(Vector2 vector2)
        {
            brainCam.ActiveVirtualCamera.VirtualCameraGameObject.GetComponent<IMovable>().Move(vector2, _player);
        }

        public void MainCameraBehavior()
        {
            brainCam.ActiveVirtualCamera.VirtualCameraGameObject.SetActive(false);

            var nbActiveCam = cameras.Count(cam => cam.gameObject.activeSelf);

            if (nbActiveCam == 0)
            {
                foreach (var cam in cameras)
                {
                    cam.gameObject.SetActive(true);
                    waitingForCorrection = true;
                }
            }
            brainCam.ActiveVirtualCamera.VirtualCameraGameObject.SetActive(false);
        }

        private void FixedUpdate()
        {
            if (waitingForCorrection && !brainCam.IsBlending)
            {
                foreach (var cam in cameras)
                {
                    cam.ResetPosition(mainCam.transform.localPosition);
                }
                waitingForCorrection = false;
            }
            brainCam.ActiveVirtualCamera?.VirtualCameraGameObject.GetComponent<IMovable>().Move(_vectorMove, _player);
        }

        //private void OnEnable()
        //{
        //    _controls.Enable();
        //}

        //private void OnDisable()
        //{
        //    _controls.Disable();
        //}
    }
}


