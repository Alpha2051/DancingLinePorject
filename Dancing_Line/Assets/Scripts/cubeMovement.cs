using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    public GameObject Actor; 
    public float speed = 1;
    private Vector3 pos;
    public Material mat;

    private int lCount =1 ;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = Actor.transform.position;
        Actor.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        GameObject Actor2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Actor2.transform.position = pos;
        Actor2.GetComponent<MeshRenderer>().material = mat;
        Actor2.GetComponent<BoxCollider>().isTrigger = true;
        if (Input.GetMouseButtonDown(0) )
        {
            if(lCount % 2 !=0)
            {
                Actor.transform.eulerAngles = new Vector3(0, 90, 0);
                lCount++;
            }
            else
            {
                Actor.transform.eulerAngles = new Vector3(0, 0, 0);
                lCount++;
            }
        }
    }
}
