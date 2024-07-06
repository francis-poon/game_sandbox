using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using game_00;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float baseMovementSpeed;

    [SerializeField]
    private float boostMultiplier;

    [SerializeField]
    private float boostChargeRate;

    [SerializeField]
    private float boostConsumeRate;


    private Vector3 movementVector;
    private float boostTank;
    private float movementSpeed;
    private bool boosting;

    private void Awake()
    {
        movementVector = Vector3.zero;
        boostTank = 0;
        movementSpeed = baseMovementSpeed;
        boosting = false;
    }

    public void Update()
    {
        movementVector = Vector3.zero;
        if (Input.GetKey(KeyCode.D))
        {
            movementVector += new Vector3(1, 0, 0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            movementVector += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            movementVector += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementVector += new Vector3(0, -1, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && boostTank > 0f)
        {
            movementSpeed = baseMovementSpeed * boostMultiplier;
            boosting = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed = baseMovementSpeed;
            boosting = false;
        }

        if (boostTank <= 0f)
        {
            movementSpeed = baseMovementSpeed;
        }

        if (boosting)
        {
            boostTank = boostTank = Mathf.Max(boostTank - Time.deltaTime * boostConsumeRate, 0f);
        }
        else
        {
            boostTank = Mathf.Min(boostTank + Time.deltaTime * boostChargeRate, 100f);
        }

        movementVector = movementVector.normalized;
        Vector3 movement = movementVector * (movementSpeed);
        GetComponent<Rigidbody2D>().velocity = movement;

        GameManager.Instance.OnUIUpdate(new UIData("ProgressBar", new Dictionary<string, object>() { { "maxValue", 100f }, { "currentValue", boostTank } }));
    }
}
