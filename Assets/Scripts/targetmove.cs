using UnityEngine;
using System.Collections;

public class targetmove : MonoBehaviour
{
    public float speed;
    private Vector3 target;
    private Vector3 tar;
    public Camera ena;
    public Camera dva;
    
    void Start()
    {
        target = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            tar = ena.ScreenToWorldPoint(Input.mousePosition);
            target.x = tar.x;
            target.z = tar.z;
            target.y = 0.056f;
            dva.enabled = true;
            ena.enabled = false;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}