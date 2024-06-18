using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitCombiiner : MonoBehaviour
{
    private int layerIndex;
    private fruitInfo _info;

    private void Awake()
    {
        _info = GetComponent<fruitInfo>();
        layerIndex = gameObject.layer;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer==layerIndex)
        {
            fruitInfo info = collision.gameObject.GetComponent<fruitInfo>();
            if (info != null)
            {
                if (info.fruitIndex== _info.fruitIndex)
                {
                    int thisID = gameObject.GetInstanceID();
                         int otherID = collision.gameObject.GetInstanceID();

                    if (thisID > otherID)
                    {
                        suikaManager.instance.Increasescore(_info.pointsWhenanimated);
                        if (_info.fruitIndex==fruitSelector.instance.fruits.Length -1)
                        {
                            Destroy(collision.gameObject);
                            Destroy(gameObject);
                        }
                        else
                        {
                            Vector3 middlePosition = (transform.position + collision.transform.position) / 2f;
                            GameObject go = Instantiate(spawnCombineFruit(_info.fruitIndex), suikaManager.instance.transform);
                            go.transform.position = middlePosition;

                            colliderinformer informer = go.GetComponent<colliderinformer>();
                            if (informer!=null)
                            {
                                informer.WasCombined = true;
                            }

                            Destroy(collision.gameObject);
                            Destroy(gameObject);
                        }
                    }
                }
            }
        }
    }

    private GameObject spawnCombineFruit(int index)
    {
        GameObject go = fruitSelector.instance.fruits[index + 1];
        return go;
    }
}
