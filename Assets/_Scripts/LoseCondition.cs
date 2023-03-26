using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Coin"))
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                Destroy(gameObject);
            }
        }

        if (other.gameObject.CompareTag("Bomb"))
        {

        }
    }
}
