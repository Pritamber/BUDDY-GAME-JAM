using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class planting : MonoBehaviour
{
    //This script is attached to the player
    public bool onsoil;
    Transform soil;
    public GameObject seeds;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Soil"))
        {
            onsoil = true;
            soil=collision.GetComponent<Transform>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Soil"))
        {
            onsoil = false;
        }
    }

    private void Update()
    {

    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (onsoil)
        {
            Instantiate(seeds,soil.position,Quaternion.identity);
        }
    }
}
