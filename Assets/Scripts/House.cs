using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
	[SerializeField]
	private GameObject house = null;
	
	private float xMin = -26.6f;
	private float xMax = -45.0f;

    void Start()
    {
        float _xpoz = Random.Range(xMin, xMax);
		
		house.transform.position = new Vector3(_xpoz, transform.position.y, transform.position.z);
    }
}
