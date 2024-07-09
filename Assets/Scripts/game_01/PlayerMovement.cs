using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using game_01;

namespace game_01
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private float baseMovementSpeed;

        [SerializeField]
        private float baseTurnSpeed;

        //[SerializeField]
        //private float boostMultiplier;

        //[SerializeField]
        //private float boostChargeRate;

        //[SerializeField]
        //private float boostConsumeRate;


        private Vector3 movementVector;
        //private float boostTank;
        private float movementSpeed;
        //private bool boosting;
        private new Rigidbody2D rigidbody;

        private void Awake()
        {
            movementVector = Vector3.zero;
            //boostTank = 0;
            movementSpeed = baseMovementSpeed;
            //boosting = false;
            rigidbody = GetComponent<Rigidbody2D>();
        }

        public void Update()
        {
            //rigidbody.velocity = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
            {
                rigidbody.AddForce(new Vector2(0,1) * movementSpeed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rigidbody.AddForce(new Vector2(-1, 0) * movementSpeed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rigidbody.AddForce(new Vector2(0, -1) * movementSpeed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rigidbody.AddForce(new Vector2(1, 0) * movementSpeed);
            }
            //rigidbody.angularVelocity = 0f;
            if (Input.GetKey(KeyCode.Q))
            {
                rigidbody.AddTorque(baseTurnSpeed);
            }
            if (Input.GetKey(KeyCode.E))
            {
                rigidbody.AddTorque(-baseTurnSpeed);
            }


            //if (Input.GetKeyDown(KeyCode.LeftShift) && boostTank > 0f)
            //{
            //    movementSpeed = baseMovementSpeed * boostMultiplier;
            //    boosting = true;
            //}
            //if (Input.GetKeyUp(KeyCode.LeftShift))
            //{
            //    movementSpeed = baseMovementSpeed;
            //    boosting = false;
            //}

            //if (boostTank <= 0f)
            //{
            //    movementSpeed = baseMovementSpeed;
            //}

            //if (boosting)
            //{
            //    boostTank = boostTank = Mathf.Max(boostTank - Time.deltaTime * boostConsumeRate, 0f);
            //}
            //else
            //{
            //    boostTank = Mathf.Min(boostTank + Time.deltaTime * boostChargeRate, 100f);
            //}

            //movementVector = movementVector.normalized;
            //Vector3 movement = new Vector3(0,1,0) * (movementSpeed);
            //rigidbody.velocity = movement;

            //transform.rotation = Quaternion.FromToRotation(new Vector3(0,1,0), movementVector);

            //GameManager.Instance.OnUIUpdate(new UIData("ProgressBar", new Dictionary<string, object>() { { "maxValue", 100f }, { "currentValue", boostTank } }));
        }
    }
}
