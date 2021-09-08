using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelRand : MonoBehaviour
{
	[SerializeField]
	private GameObject[] panels = null;
	
	[SerializeField]
	private GameObject placeHolder = null;

    void Start()
    {
		placeHolder.SetActive(false);
		int pick = Random.Range(0, panels.Length);
		panels[pick].SetActive(true);
    }
}
