using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionModelo : MonoBehaviour
{

	public GameObject objectRotate;
	public  float rotateSpeed = 50f;
	bool rotateStatus = false;

	public void Rotacion (){
		if (rotateStatus == false)
		{
			rotateStatus = true;
		}
		else {
			rotateStatus = false;
		}

	}

    // Update is called once per frame
    void Update()
	{
        if (rotateStatus == true)
        {
        	objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }
}
