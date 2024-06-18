using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movespeed = 5f;
    [SerializeField] private BoxCollider2D boundaries;
    [SerializeField] private Transform fruitTrowTransform;

    private Bounds _bounds;

    private float leftbound;
    private float rightbound;

    private float Startingleftbound;
    private float Startingrightbound;

    private float offset;
   
    private void Awake()
    {
        _bounds = boundaries.bounds;

        offset = transform.position.x - fruitTrowTransform.position.x;

        leftbound = _bounds.min.x + offset;
       rightbound = _bounds.max.x + offset;

        Startingleftbound = leftbound;
        Startingrightbound = rightbound;
    }

    // Update is called once per frame
  private  void Update()
    {
        Vector3 newPosition = transform.position + new Vector3(userInput.moveInput.x * movespeed * Time.deltaTime, 0f, 0f);
        newPosition.x = Mathf.Clamp(newPosition.x, leftbound, rightbound);

        transform.position = newPosition;
    }
    
    public void ChangeBoundary(float extrawidth)
    {
        leftbound = Startingleftbound;
         rightbound= Startingrightbound;

        leftbound += throwFruitController.instance.Bounds.extents.x + extrawidth;
        rightbound -= throwFruitController.instance.Bounds.extents.x + extrawidth;

    }
}
