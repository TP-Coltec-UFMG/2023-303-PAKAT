using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public Sprite profile;
    public string[] speechTxt;
    public string actorName;

    public LayerMask playerLayer;
    public float radious;

    private DialogueControl dc;
    bool onRadious;

    private void Start(){
        dc = FindObjectOfType<DialogueControl>();
    }

    private void FixedUpdate(){
        Interact();
    }
    private void Update()
    {
        dc.Speech(profile,speechTxt, actorName);
        if(Input.GetKey(KeyCode.Space) && onRadious)
        {
            
        }
    }

    public void Interact(){
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer); //coloca o player pra detectar alguem proximo 
        if(hit != null)
        {
            onRadious = true;
        }
        else
        {
            onRadious= false;
        }
    }
    private void OnDrawGizmosSelected(){
        Gizmos.DrawWireSphere(transform.position, radious);
    }
//aaaa
}
