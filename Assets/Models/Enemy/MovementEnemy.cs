using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    public float EnemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
            EnemySpeed = Random.Range(0.01f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position+= transform.forward * EnemySpeed;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("DETECTED!");
    }
}
