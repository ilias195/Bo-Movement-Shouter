using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    public KeyCode shootKey = KeyCode.LeftControl;
    public float delay;
    


    void Start()
    {

    }


    void Update()
    {

        if (Input.GetKeyDown(shootKey))
        {
            CallShot();
        }



    }
    private void createProjectile()
    {
        GameObject ob = Instantiate(prefab);

        ob.transform.rotation = transform.rotation;
        ob.transform.position = transform.position + transform.forward;
        Destroy(ob, 3f);
    }
    public void CallShot()
    {
        StartCoroutine(AwaitDelay(delay));
    }
    private IEnumerator AwaitDelay(float time)
    {
        yield return new WaitForSeconds(time);
        createProjectile();
    }

}
