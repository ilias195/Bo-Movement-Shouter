using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingBehaviour : MonoBehaviour
{
    private Shoot shoot;
    private TriggerAnimation triggerAnimation;
    public Transform target;
    private float shotRange = 10f;
    private bool inCooldown;
    private float coolDownTime = 4f;
    void Start()
    {
        shoot = GetComponentInChildren<Shoot>();
        triggerAnimation = GetComponentInChildren<TriggerAnimation>();
    }


    void Update()
    {
        Debug.Log(0);
        Vector3 targetPos = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        transform.LookAt(targetPos);

        Vector3 delta = transform.position - target.transform.position;

        if (delta.magnitude < shotRange && !inCooldown)
        {
            Debug.Log(1);
            shoot.CallShot();
            triggerAnimation.CallTrigger();
            inCooldown = true;
            StartCoroutine(Cooldown(coolDownTime));
        }


    }
    private IEnumerator Cooldown(float time)
    {
        Debug.Log(2);
        yield return new WaitForSeconds(time);
        Debug.Log(3);
        inCooldown = false;
    }

}
