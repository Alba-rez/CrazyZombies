using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpApply : MonoBehaviour
{
    const int POWER = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SendMessage("ApplyDamage", -POWER);
            Destroy(gameObject);
        }
    }
}
