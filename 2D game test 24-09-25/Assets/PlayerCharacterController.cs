using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    public float MoveSpeed;
    public float[] Boarder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");
        //Debug.Log(ver.ToString()+" [] " + hor.ToString());
        Vector2 move = new Vector2(hor*MoveSpeed*Time.deltaTime, ver*MoveSpeed* Time.deltaTime);
        transform.position=new Vector2(transform.position.x+move.x,transform.position.y+ move.y);
       ResetoVeiw();
    }

    public void ResetoVeiw()
    {
        //Debug.Log(transform.position.y);
        if (transform.position.y > Boarder[0])
        {
            Debug.Log("outside y up");
            transform.position =new Vector2(transform.position.x, Boarder[0]);
        }
        else
        {
            if (transform.position.y < Boarder[1])
            {
                Debug.Log("outside Y Down");
                transform.position = new Vector2(transform.position.x, Boarder[1]);
            }
        }
        
        if (transform.position.x > Boarder[2])
        {
            Debug.Log("outside x Right");
            transform.position = new Vector2(Boarder[2], transform.position.y);
        }
        else 
        {
            if (transform.position.x < Boarder[3])
            {
                Debug.Log("outside x Left");
                transform.position = new Vector2(Boarder[3], transform.position.y);
            }
        }
        
    }
}
