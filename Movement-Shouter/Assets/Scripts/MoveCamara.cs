using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamara : MonoBehaviour
{
    private float x;
    private float y;
    public float sensitvity = -1f;
    private Vector3 rotate;

    public Transform player;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        y = Input.GetAxisRaw("Mouse X");
        x = Input.GetAxisRaw ("Mouse Y");
        rotate = new Vector3 (x, y * sensitvity, 0);
        transform.eulerAngles =transform.eulerAngles - rotate;
        transform.position = player.transform.position;
        
    }
}
