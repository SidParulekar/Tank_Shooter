using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{

    [SerializeField] private int playerNumber = 1;

    [SerializeField] private Rigidbody shell;

    [SerializeField] private Transform fireTransform;

    [SerializeField] private AudioSource shootingAudio;

    [SerializeField] private AudioClip chargingClip;

    [SerializeField] private AudioClip fireClip;

    [SerializeField] private float minLaunchForce = 15f;
    [SerializeField] private float maxLaunchForce = 30f;

    [SerializeField] private float maxChargeTime = 0.75f;

    private string fireButton;
    private float currentLaunchForce;
    private float chargeSpeed;
    private bool fired;

    private void OnEnable()
    {
        currentLaunchForce = minLaunchForce;
    }

    private void Start()
    {
        fireButton = "Fire" + playerNumber;

        chargeSpeed = (maxLaunchForce - minLaunchForce) / maxChargeTime;
    }

    private void Update()
    {
        if(currentLaunchForce >= maxLaunchForce && !fired) // at max charge not yet fired
        {
            currentLaunchForce = maxLaunchForce;
            Fire();
        }

        else if (Input.GetButtonDown(fireButton)) // fire button pressed for first time
        {
            fired = false;
            currentLaunchForce = minLaunchForce;

            //shootingAudio.clip = chargingClip;
            //shootingAudio.Play();
        }

        else if (Input.GetButton(fireButton) && !fired) // holding fire button not yet fired
        {
            currentLaunchForce += chargeSpeed * Time.deltaTime;
        }

        else if (Input.GetButtonUp(fireButton) && !fired)
        {
            Fire();
        }

    }

    private void Fire()
    {
        fired = true;

        Rigidbody shellInstance = Instantiate(shell, fireTransform.position, fireTransform.rotation) as Rigidbody;

        shellInstance.velocity = currentLaunchForce * fireTransform.forward;

        //shootingAudio.clip = fireClip;
        //shootingAudio.Play();

        currentLaunchForce = minLaunchForce;
    }

}
