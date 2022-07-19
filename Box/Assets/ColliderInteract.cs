using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderInteract : MonoBehaviour
{
    public bool NPC_One;
    public GameObject interact;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "cube"){
            // Debug.Log("Success");
            NPC_One = true;   
            interact.gameObject.SetActive(true);
        }
        else if(col.gameObject.tag == "Assignments") {
            // Debug.Log("Success");
            NPC_One = true;   
            interact.gameObject.SetActive(true);
        }
    }
    public void OnTriggerStay(Collider other) {
         if(other.gameObject.tag == "cube"){
            // Debug.Log("Success"); 
            NPC_One = true;    
            interact.gameObject.SetActive(true);
        }
        else if(other.gameObject.tag == "Assignments"){
            // Debug.Log("Success");
            NPC_One = true;   
            interact.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other) {
         if(other.gameObject.tag == "cube"){
            // Debug.Log("Out of range"); 
            NPC_One = false;    
            interact.gameObject.SetActive(false);
        }
        
        if(other.gameObject.tag == "Assignments"){
            // Debug.Log("Success");
            NPC_One = true;   
            interact.gameObject.SetActive(false);
        }
    }
}
