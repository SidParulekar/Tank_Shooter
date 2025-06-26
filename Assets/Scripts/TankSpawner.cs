using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{

    [SerializeField] private TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank(); //Creating a tank in the game scene
    }

    public void CreateTank()
    {
        TankModel tankModel = new TankModel(30, 20);
        TankController tankController = new TankController(tankModel, tankView);
    }

}
