using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public TankTypes tankType;

    public Material color;

    public TankModel(float movement, float rotation, TankTypes tankType, Material color)
    {
        movementSpeed = movement;
        rotationSpeed = rotation;
        this.tankType = tankType;
        this.color = color;
    }

    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
}
