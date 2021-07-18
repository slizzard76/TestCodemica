using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireArm : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    void Start()
    {
        Speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += transform.forward * 1f;
    }

    private void OnTriggerEnter(Collider other)
    {
    
        Main.IncreaseScoreAndDestroy(other.gameObject, this.gameObject);
        Debug.Log("FireArmCollitedt");
    }
}
