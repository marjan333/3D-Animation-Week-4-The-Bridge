using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDoor : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("isOpening", false);
    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("isOpening", true);
    }
    void Start()
    {
        anim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
