using UnityEngine;


public class cameraChange : MonoBehaviour
{
    public Camera cam;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;

    void Start()
    {
        cam.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            cam.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            cam.enabled = false;
            cam2.enabled = true; 
            cam3.enabled = false;
            cam4.enabled = false;
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            cam.enabled = false;
            cam2.enabled = false;
            cam3.enabled = true;
            cam4.enabled = false;
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            cam.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = true;
        }
    }
}