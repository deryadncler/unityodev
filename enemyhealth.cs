using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyhealth : MonoBehaviour
{
    public float enemyHealth = 100f;
    public float enemycount = 2f;

   
    public void DeductHealth(float deductHealth)
    {
        enemyHealth -= deductHealth;
        if (enemyHealth <= 0){ enemyDead(); }
        
        void enemyDead()
        {
            Destroy(gameObject);
        }

    }
   

}
