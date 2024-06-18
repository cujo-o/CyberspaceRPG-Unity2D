using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectspawner : MonoBehaviour
{   
    public GameObject[] items;
    public float spawnrate;
    public bool canspawn = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnenemy());
        spawnrate = Random.Range(1f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private IEnumerator spawnenemy()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnrate);
        while (canspawn)
        {
            yield return wait;
            int rand = Random.Range(0, items.Length);
            GameObject itemstospawn = items[rand];

            Instantiate(itemstospawn, transform.position, Quaternion.identity); 
           
        }

    }
	public  void win()
    {

	}
}
