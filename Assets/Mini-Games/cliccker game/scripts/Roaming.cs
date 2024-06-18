using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roaming : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float range;
    [SerializeField] private float maxDistance;

    public GameObject playersBusiness;
    public GameObject center;
    public float click;

    Vector2 wayPoint;
    // Start is called before the first frame update
    void Start()
    {
        SetNewDestination();
    }

    // Update is called once per frame
    void Update()
    {
      

        if (click >= 5f )
        {
            MovetoPlayerBusiness();
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, wayPoint) < range)
            {
                SetNewDestination();
            }
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            ClickFunction();
        }
    }

    void SetNewDestination()
    {
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }

    public void ClickFunction()
    {
        click += 1;
        Debug.Log("clicked");
        //click++;
    }

    void MovetoPlayerBusiness()
    {

        transform.position = Vector2.MoveTowards(this.transform.position, playersBusiness.transform.position, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(center.transform.position, range);

        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(center.transform.position, maxDistance);
     
    }
  

}
