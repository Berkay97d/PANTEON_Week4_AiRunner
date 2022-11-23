using System;
using _Scripts.Player;
using UnityEngine;


    public class PlayerController : MonoBehaviour
    {
        
        private void Start() //BAŞLANGIÇTA IDLE OLMASI İÇİN
        {
            Player.PlayerState = PlayerStates.Waiting;
        }

        public void StartRunning() //START GAME BUTONUNA ATANDI
        {
            Player.PlayerState = PlayerStates.Running;
        }

        public void MakePlayerJump(float jumpForce)
        {
            Player.PlayerState = PlayerStates.Falling; 
            var rb = gameObject.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0,1,.1f) * jumpForce);
        }

        private void OnCollisionEnter(Collision collision) //FALLINGDEN YERE TEMAS EDİNCE RUNNİNGE ALDIM
        {
            if (Player.PlayerState == PlayerStates.Falling && collision.gameObject.CompareTag("Ground"))
            {
                Player.PlayerState = PlayerStates.Running;
            }
        }
    }
