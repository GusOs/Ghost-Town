using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCloseDoor : MonoBehaviour
{
    // Smoothly open a door
    public float doorCloseAngle = 90.0f; //Set either positive or negative number to open the door inwards or outwards
    public float closeSpeed = 8.0f; //Increasing this value will make the door open faster

    public Sound doorCloseAudio;

    bool close = false;
    bool enter = false;

    float defaultRotationAngle;
    float currentRotationAngle;
    float openTime = 0;

    void Start()
    {
        defaultRotationAngle = transform.localEulerAngles.y;
        currentRotationAngle = transform.localEulerAngles.y;
    }

    // Main function
    void Update()
    {
        if (openTime < 1)
        {
            openTime += Time.deltaTime * closeSpeed;
        }
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, Mathf.LerpAngle(currentRotationAngle, defaultRotationAngle + (close ? doorCloseAngle : 0), openTime), transform.localEulerAngles.z);

        if (enter)
        {
            AudioManager.Instance.PlaySound(doorCloseAudio);
            close = !close;
            currentRotationAngle = transform.localEulerAngles.y;
            openTime = 0;
        }
    }


    // Activate the Main function when Player enter the trigger area
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = true;
        }
    }
}
