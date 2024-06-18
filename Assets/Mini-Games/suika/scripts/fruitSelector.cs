using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fruitSelector : MonoBehaviour
{
    public static fruitSelector instance;

    public GameObject[] fruits;
    public GameObject[] NoPhysicsfruits;
    public int highestStartingIndex=3;

    [SerializeField] private Image nextfruitimage;
    [SerializeField] private Sprite[] fruitsprite;
    public GameObject nextFruit { get; private set; }

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Start()
    {
        pickNextDruit();
    }

    public GameObject PickrandomFruitforThrow()
    {
        int randomindex = Random.Range(0, highestStartingIndex + 1);
        if (randomindex < NoPhysicsfruits.Length)
        {
            GameObject randomFruit = NoPhysicsfruits[randomindex];
            return randomFruit;
           
        }
        return null;

       
    }

    public void pickNextDruit()
    {
        int randomindex = Random.Range(0, highestStartingIndex + 1);
        if (randomindex < fruits.Length)
        {
            nextFruit = NoPhysicsfruits[randomindex];

        }


    }
}
