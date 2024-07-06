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

        private void Awake()
        {
            movementVector = Vector3.zero;
            //boostTank = 0;
            movementSpeed = baseMovementSpeed;
            //boosting = false;
        }

        public void Update()
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
            {
                GetComponent<Rigidbody2D>().velocity = transform.up * movementSpeed;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.Rotate(new Vector3(0, 0, 90));
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, 0, -90));
            }
            GetComponent<Rigidbody2D>().angularVelocity = 0f;
            if (Input.GetKey(KeyCode.Q))
            {
                GetComponent<Rigidbody2D>().angularVelocity = baseTurnSpeed;
            }
            if (Input.GetKey(KeyCode.E))
            {
                GetComponent<Rigidbody2D>().angularVelocity = -baseTurnSpeed;
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
            //GetComponent<Rigidbody2D>().velocity = movement;

            //transform.rotation = Quaternion.FromToRotation(new Vector3(0,1,0), movementVector);

            //GameManager.Instance.OnUIUpdate(new UIData("ProgressBar", new Dictionary<string, object>() { { "maxValue", 100f }, { "currentValue", boostTank } }));
        }
    }
}
