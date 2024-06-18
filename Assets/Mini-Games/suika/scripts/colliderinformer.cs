using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderinformer : MonoBehaviour
{
   public bool WasCombined { get; set; }
    private bool hasCollided;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasCollided && !WasCombined)
        {
            hasCollided = true;
            throwFruitController.instance.canThrow = true;
            throwFruitController.instance.spawnFruit(fruitSelector.instance.nextFruit);
            fruitSelector.instance.pickNextDruit();
            Destroy(this);

        }
    }
}
