using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float mesafe;
    public Transform target;
    Vector3 pos;

    private Animator enemyanimator;


    // Start is called before the first frame update
    void Start()
    {
        enemyanimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        mesafe = Vector3.Distance(transform.position, target.position);
        pos = new Vector3(target.position.x, transform.position.y, transform.position.z);

        if (mesafe < 10f)
        {
            transform.LookAt(pos);
            enemyanimator.SetBool("combatmode", true);
        }
        else
        {
            enemyanimator.SetBool("combatmode", false);
        }
    }
}
