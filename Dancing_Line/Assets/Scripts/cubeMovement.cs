using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    public GameObject Actor; 
    public float speed = 1;
    private Vector3 pos;
    public Material mat;

    private int lCount = 1 ;
    public bool onGround = true;
    public float distFromGround = 0.6f;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive) { 
            onGround = isGrounded(); 
            pos = Actor.transform.position;
            Actor.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(onGround == true) { 
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
    }

    public bool isGrounded()
    {
        return Physics.Raycast(Actor.transform.position, Vector3.down, distFromGround);
    }

    private void OnCollisionEnter( Collision collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            isAlive = false;
            GameObject Prime = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject Prime1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject Prime2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject Prime3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject Prime4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject Prime5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject Prime6 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            Prime.transform.position = pos;
            Prime1.transform.position = pos;
            Prime2.transform.position = pos;
            Prime3.transform.position = pos;
            Prime4.transform.position = pos;
            Prime5.transform.position = pos;
            Prime6.transform.position = pos;

            Prime.AddComponent<Rigidbody>().velocity = Random.onUnitSphere * 50;
            Prime1.AddComponent<Rigidbody>().velocity = Random.onUnitSphere * 100;
            Prime2.AddComponent<Rigidbody>().velocity = Random.onUnitSphere * 10;
            Prime3.AddComponent<Rigidbody>().velocity = Random.onUnitSphere * 20;
            Prime4.AddComponent<Rigidbody>().velocity = Random.onUnitSphere * 60;
            Prime5.AddComponent<Rigidbody>().velocity = Random.onUnitSphere * 5;
            Prime6.AddComponent<Rigidbody>().velocity = Random.onUnitSphere * 1;

            Prime.GetComponent<MeshRenderer>().material = mat;
            Prime1.GetComponent<MeshRenderer>().material = mat;
            Prime2.GetComponent<MeshRenderer>().material = mat;
            Prime3.GetComponent<MeshRenderer>().material = mat;
            Prime4.GetComponent<MeshRenderer>().material = mat;
            Prime5.GetComponent<MeshRenderer>().material = mat;
            Prime6.GetComponent<MeshRenderer>().material = mat;

        }
    }
}


