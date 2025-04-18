using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnHit : MonoBehaviour
{
    public string targetTag;
    public GameObject gameObject;
    public GameObject effect;
    private AudioSource audioSource;
    public Hearts heartScript;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {

    }
    private void OnCollisionEnter(Collision coll)
    {
        handleHit(coll.gameObject);
    }
    private void OnTriggerEnter(Collider coll)
    {
        handleHit(coll.gameObject);
    }
    private void handleHit(GameObject other)
    {
        if (other.tag == targetTag)
        {
            GameObject expl = Instantiate(effect);
            expl.transform.position = other.transform.position;
            Destroy(expl, 2f);
            if (targetTag == "Player")
            {
                if (heartScript == null)
                {
                    heartScript = FindObjectOfType<Hearts>();
                }
                heartScript.Lives--;
                if (heartScript.Lives == 0)
                {
                    Destroy(other, 0.1f);
                }
            }
            else
            {
                Destroy(other, 0.1f);
            }
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }

}
