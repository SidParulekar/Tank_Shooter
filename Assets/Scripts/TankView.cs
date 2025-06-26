using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movementDir;
    private float rotationDir;

    [SerializeField] private Rigidbody rb;

    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");

        cam.transform.SetParent(this.transform); // Defining the tank object to which this TankView script is attached as Parent of cam

        cam.transform.position = new Vector3(0f, 11f, -5f); // Setting distance between the tank and camera
    }

    // Update is called once per frame
    void Update()
    {
        MovementInput();

        if(movementDir!=0)
        {
            tankController.Move(movementDir, tankController.GetTankModel().movementSpeed);
        }

        if (rotationDir != 0)
        {
            tankController.Rotate(rotationDir, tankController.GetTankModel().rotationSpeed);
        }
    }

    private void MovementInput()
    {
        movementDir = Input.GetAxis("Vertical");

        rotationDir = Input.GetAxis("Horizontal");
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
