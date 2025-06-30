using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    [SerializeField] TankSpawner tankSpawner;
    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(tankSpawner.tankList[1]);
        this.gameObject.SetActive(false);
    }

    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(tankSpawner.tankList[0]);
        this.gameObject.SetActive(false);
    }

    public void RedTankSelected()
    {
        tankSpawner.CreateTank(tankSpawner.tankList[2]);
        this.gameObject.SetActive(false);
    }
}
