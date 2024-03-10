using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface Icon
{
    Image icon { get;}
}

public class Item : MonoBehaviour , Icon
{
    public Event dropped;
    public Event pickedUp;  
    public Image eggIcon;

    public Image icon { get => eggIcon; }

    private void Start()
    {
        dropped.Occured(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pickedUp.Occured(gameObject);
            gameObject.GetComponent<MeshRenderer>().enabled = false;    
            gameObject.GetComponent<Collider>().enabled = false;    
            Destroy(gameObject,5);
        }
    }
}
