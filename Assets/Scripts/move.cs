using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    public GameObject character;
    public float speed;

    void Start()
    {
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 newPosition = character.transform.position;
            newPosition.z += speed;
            character.transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 newPosition = character.transform.position;
            newPosition.z -= speed;
            character.transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 newPosition = character.transform.position;
            newPosition.x -= speed;
            character.transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            Vector3 newPosition = character.transform.position;
            newPosition.x += speed;
            character.transform.position = newPosition;

        }
    }
}

