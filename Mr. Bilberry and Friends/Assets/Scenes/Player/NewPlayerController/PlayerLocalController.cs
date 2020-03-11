using System.Collections.Generic;
using System.Linq;
using Entities.Characters.NewPlayerController;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Entities.Characters.NewPlayerController
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerLocalController : MonoBehaviour, IPlayerController
    {
        public float walkSpeed = 5f;
        public float crawlSpeedDifferential = 0.5f;
        public float sprintSpeedDifferential = 2f;
        public float jumpHeight = 2f;
        public float gravity = -9.81f;
        public float rotateSpeed = 70f;
        public float reloadTime = 0f;
        public int timeToReload = 2;

        private float _rotation;
        private float _timeToWait;
        private Backpack _backpack;
        private Animator _playerAnimator;
        private CharacterController _cc;
        private Vector3 _movement;
        private bool _isImmobile;
        private bool _isCrawling;
        private bool _isSprinting;
        private List<CapsuleCollider> _capsuleColliders;
        private MainCameraLocal _mainCamera;
        private static readonly int Taunt1 = Animator.StringToHash("Taunt");
        private bool _isTaunting;
        private bool _outOfAmmo;
        private int _frame;
        private bool _isThrowing;

        private void Awake()
        {
            //controls = new InputMaster();
            _playerAnimator = GetComponent<Animator>();
            _backpack = GetComponent<Backpack>();
            _cc = GetComponent<CharacterController>();
            _capsuleColliders = GetComponents<CapsuleCollider>().ToList();
            _mainCamera = GetComponentInChildren<MainCameraLocal>();

            /*controls.Player.Sprint.performed += x => Sprint(x.ReadValue<float>());
            controls.Player.Sprint.canceled += x => Sprint(x.ReadValue<float>());

            controls.Player.Move.performed += x => Move(x.ReadValue<Vector2>());
            controls.Player.Move.canceled += x => Move(Vector2.zero);

            controls.Player.Sneak.performed += x => Crawl(x.ReadValue<float>());
            controls.Player.Sneak.canceled += x => Crawl(x.ReadValue<float>());

            controls.Player.Jump.performed += x => Jump();

            // controls.Player.Rotate.performed += x => Rotate(x.ReadValue<float>());
            // controls.Player.Rotate.canceled += x => Rotate(0);

            controls.Player.Throw.performed += x => Throw();

            controls.Player.Reload.performed += x => StartReload();

            controls.Player.Taunt.performed += x => Taunt();*/
        }

        /// <summary>
        /// Play the taunt.
        /// </summary>
        private void OnTaunt()
        {
            _playerAnimator.SetTrigger(Taunt1);
            _isTaunting = true;
        }

        /// <summary>
        /// Play the reload and set player into reload.
        /// </summary>
        private void OnReload()
        {
            if (!_cc.isGrounded || _isImmobile) return;
            _playerAnimator.SetTrigger("StartReloading");
            _playerAnimator.SetBool("IsReloading", true);
            _isImmobile = true;
            reloadTime = Time.time;
        }

        private void EndReload()
        {
            _playerAnimator.Play("EndReload");
            _playerAnimator.SetBool("IsReloading", false);
            _isImmobile = false;
            _outOfAmmo = _backpack.Reload();
        }

        /// <summary>
        /// Play the throw.
        /// </summary>
        private void OnThrow()
        {
            if (_outOfAmmo || _isThrowing)
            {
                return;
            }

            _isThrowing = true;
            _playerAnimator.SetTrigger("Throw");
            _outOfAmmo = _backpack.MunitionThrown();

            var constraint = transform.gameObject.GetComponent<MParentConstraint>();

            constraint.RHand();
        }

        /// <summary>
        /// Moves in the specified direction.
        /// </summary>
        /// <param name="direction">The direction.</param>
        private void OnMove(InputValue value)
        {
            var direction = value.Get<Vector2>();
            _movement.x = direction.x * walkSpeed;
            _movement.z = direction.y * walkSpeed;

            _playerAnimator.SetBool("IsMoving", !direction.Equals(new Vector2(0,0)));
        }

        /// <summary>
        /// Play the crawling and set player into crawling.
        /// </summary>
        /// <param name="crawlingState">State of the crawling.</param>
        private void OnSneak(InputValue value)
        {
            var crawlingState = value.Get<float>();
            if(_isCrawling != crawlingState >= 0.9f) SwapCollider();
            _isCrawling = crawlingState >= 0.9f;
        }

        /// <summary>
        /// Rotates the player.
        /// </summary>
        /// <param name="rotation">The rotation.</param>
        public void Rotate(float rotation)
        {
            _rotation = rotation * rotateSpeed;
        }

        /// <summary>
        /// Play the sprint and set player into sprinting.
        /// </summary>
        /// <param name="sprintingState">State of the sprinting.</param>
        public void OnSprint(InputValue value)
        {
            var sprintingState = value.Get<float>();
            _isSprinting = sprintingState >= 0.9f;
        }

        /// <summary>
        /// Make the player jumps.
        /// </summary>
        private void OnJump()
        {
            if (_cc.isGrounded)
            {
                _isImmobile = false;
                _playerAnimator.SetTrigger("IsJumping");
                _movement.y += Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
        }

        /// <summary>
        /// Swaps collider.
        /// </summary>
        private void SwapCollider()
        {
            foreach (var caps in _capsuleColliders)
            {
                caps.enabled = !caps.enabled;
            }
        }

        private void FixedUpdate()
        {
            _movement.y += gravity * Time.deltaTime;

            var move = _movement;
            if (_isCrawling && !_isSprinting)
            {
                move.x *= crawlSpeedDifferential;
                move.z *= crawlSpeedDifferential;
            }

            if (_isSprinting && !_isCrawling)
            {
                move.x *= sprintSpeedDifferential;
                move.z *= sprintSpeedDifferential;
            }

            if(!_isImmobile) _cc.Move(_cc.transform.TransformDirection(move) * Time.deltaTime);

            _playerAnimator.SetBool("IsCrawling", _isCrawling);
            _playerAnimator.SetBool("IsSprinting", _isSprinting);

            _playerAnimator.SetFloat("PinguX", move.x, 5f, Time.deltaTime * 50);
            _playerAnimator.SetFloat("PinguY", move.z, 5f, Time.deltaTime * 50);
            _cc.transform.Rotate(0, _rotation * Time.deltaTime, 0);
            _rotation = 0f;

            if (_movement.y < -5 && !_cc.isGrounded)
                _playerAnimator.SetBool("IsFalling",true);

            if (_cc.isGrounded && _movement.y < 0)
            {
                _movement.y = 0f;
                _playerAnimator.SetBool("IsFalling", false);
            }

            if (_playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("Reload") && _isImmobile)
            {

                //_playerAnimator.Play("Reload");
                if (Time.time > reloadTime + timeToReload)
                {
                    EndReload();

                }
            }
        }

        ///// <summary>
        ///// Called when [enable].
        ///// </summary>
        //private void OnEnable()
        //{
        //    controls.Enable();
        //}

        ///// <summary>
        ///// Called when [disable].
        ///// </summary>
        //private void OnDisable()
        //{
        //    controls.Disable();
        //}

        private void OnMoveByStick(InputValue value)
        {
            _mainCamera?.OnMoveByStick(value.Get<Vector2>());
        }

        private void OnMoveByMouse(InputValue value)
        {
            _mainCamera?.OnMove(value.Get<Vector2>());
        }

        private void OnSwapCamera()
        {
            _mainCamera?.MainCameraBehavior();
        }

        public void EndThrow()
        {
            _isThrowing = false;
        }
    }
}
