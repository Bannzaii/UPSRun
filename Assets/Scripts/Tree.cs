using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
	private float size;
	
    void Start()
    {
		size = Random.Range(16f, 24f);
        transform.localScale = new Vector3(size, size, size);
    }
}
