using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    private Rigidbody rb;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView); // Assigning the TankView component attached to Game Object being instantiated

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        rb = tankView.GetRigidbody();

    }

    public void Move(float movementDir, float movementSpeed)
    {
        rb.velocity = tankView.transform.forward * movementDir * movementSpeed;
    }

    public void Rotate(float rotateDir, float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotateDir * rotateSpeed, 0f); // specifying direction and speed of rotation
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);// additional variable for smooth rotation
        rb.MoveRotation(rb.rotation *  deltaRotation); // implementing rotation in the rigidbody of tank so it is visible on the screen
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
