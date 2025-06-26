using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public TankModel(float movement, float rotation)
    {
        movementSpeed = movement;
        rotationSpeed = rotation;
    }

    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
}
