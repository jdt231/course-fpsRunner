using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{

    [SerializeField] float restoreAngle = 90f;
    [SerializeField] float addIntensity = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Collected battery");
            other.GetComponentInParent<FlashLightSystem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInParent<FlashLightSystem>().AddLightIntensity(addIntensity);
            Destroy(gameObject);
        }
    }


}
