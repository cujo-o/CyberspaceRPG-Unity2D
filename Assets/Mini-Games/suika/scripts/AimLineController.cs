using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimLineController : MonoBehaviour
{
    [SerializeField] private Transform fruitThrowTransform;
    [SerializeField] private Transform bottomTransform;

    private LineRenderer lineRenderer;

    private float topPos;
    private float bottomPos;
    private float _x;
    // Start is called before the first frame update
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        _x = fruitThrowTransform.position.x;
        topPos = fruitThrowTransform.position.y;
        bottomPos = bottomTransform.position.y;

        lineRenderer.SetPosition(0, new Vector3(_x, topPos));
        lineRenderer.SetPosition(1, new Vector3(_x, bottomPos));

    }

    private void OnValidate()
    {
        lineRenderer = GetComponent<LineRenderer>();

        _x = fruitThrowTransform.position.x;
        topPos = fruitThrowTransform.position.y;
        bottomPos = bottomTransform.position.y;

        lineRenderer.SetPosition(0, new Vector3(_x, topPos));
        lineRenderer.SetPosition(1, new Vector3(_x, bottomPos));

    }
}
