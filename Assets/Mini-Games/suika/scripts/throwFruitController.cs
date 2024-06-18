using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwFruitController : MonoBehaviour
{
    public static throwFruitController instance;

    public GameObject currentFruit { get; set; }
    [SerializeField] private Transform fruitTransform;
    [SerializeField] private Transform parentAfterThrow;
    [SerializeField] private fruitSelector selector;

    private PlayerController playerController;
    private Rigidbody2D rb;
    private CircleCollider2D circleCollider;

    public Bounds Bounds { get; private set; }
    private const float extra_width = 0.02f;
    public bool canThrow { get; set; } = true;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        playerController = GetComponent<PlayerController>();
        spawnFruit(selector.PickrandomFruitforThrow());
    }

    private void Update()
    {
        if (userInput.IsthrowPressed && canThrow==true)
        {
            SpriteIndex Index = currentFruit.GetComponent<SpriteIndex>();
            Quaternion rot = currentFruit.transform.rotation;

            GameObject go = Instantiate(fruitSelector.instance.fruits[Index.index], currentFruit.transform.position, rot);
            go.transform.SetParent(parentAfterThrow);

           Destroy(currentFruit);
            canThrow = false;
        }
    }
    public void spawnFruit(GameObject fruit)
    {
        GameObject go = Instantiate(fruit, fruitTransform);
        currentFruit = go;
        circleCollider = currentFruit.GetComponent<CircleCollider2D>();
        Bounds = circleCollider.bounds;

        playerController.ChangeBoundary(extra_width);
    }


}
