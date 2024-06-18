using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {

	public WordManager wordManager;

	public float wordDelay = 1.5f;
	private float nextWordTime = 0f;

	private void Update()
	{
		//*if (Time.time >= nextWordTime)
		{
			
			//nextWordTime = Time.time + wordDelay;
			//wordDelay *= .99f;
		}
	}
    public void Start()
    {
		wordManager.AddWord();
	}
}
