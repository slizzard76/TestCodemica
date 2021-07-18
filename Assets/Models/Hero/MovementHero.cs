using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHero : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject _player;
    GameObject _camera;
    public GameObject FireArm;
    public float Speed;
    
    void Start()
    {
        _player = GameObject.FindWithTag("Hero");
        _camera = GameObject.FindWithTag("MainCamera");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && (this.transform.position.x > 5))
            this.transform.position -= transform.right * 1f;

        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && (this.transform.position.x < 995))
                this.transform.position += transform.right * 1f;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var gobject = Instantiate(FireArm,
                new Vector3(transform.position.x, transform.position.y + 15, transform.position.z + 70), Quaternion.identity);


            Main.Fire(gobject);
        }
            //_fireArmsList.Add(Instantiate(FireArm, 
              //  new Vector3(transform.position.x, transform.position.y+15, transform.position.z+70), Quaternion.identity));

       
    }
}
