using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterMove : MonoBehaviour
{
    public GameObject obj;
	public float range = 5f, moveSpeed = 3f, turnSpeed = 40f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
			obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.DownArrow))
			obj.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.LeftArrow))
			obj.transform.Translate(Vector3.forward  * moveSpeed * Time.deltaTime);

		// if(Input.GetKey(KeyCode.RightArrow))
		// 	obj.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
	}
        
}
