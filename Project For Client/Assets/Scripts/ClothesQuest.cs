using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesQuest : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Basket")
        {
            gameObject.tag = "Deposited";
        }
    }
}
