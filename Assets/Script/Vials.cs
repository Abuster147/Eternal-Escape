using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Vials : MonoBehaviour
{
   public AudioClip VialCollect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(VialCollect, transform.position);
        Destroy(gameObject);
    }
}
