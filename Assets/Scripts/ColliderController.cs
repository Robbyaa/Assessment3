using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    
    private Animator anim;


    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isCollider", true);
            GameController.controller.AddDieChestCount();
            GetComponent<AudioSource>().clip = clip;
            GetComponent<AudioSource>().Play();
            Destroy(gameObject,1.5f);
        }
        Debug.Log(1);
    }
    
}
