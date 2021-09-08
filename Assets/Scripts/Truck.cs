using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
	[SerializeField]
	private float _speed = 0.8f;
	
    void Update()
    {
       transform.Translate(Vector3.right * Time.deltaTime * _speed);
    }
}
