using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{

    [SerializeField] private TankView tankView;

    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;

        public TankTypes tankType;

        public Material color;
    }

    public List<Tank> tankList;

    // Start is called before the first frame update
    void Start()
    {
        //CreateTank(); //Creating a tank in the game scene
    }

    public void CreateTank(Tank selectedTank)
    {
        TankModel tankModel = new TankModel(selectedTank.movementSpeed, selectedTank.rotationSpeed, selectedTank.tankType, selectedTank.color);
        TankController tankController = new TankController(tankModel, tankView);
    }

}
