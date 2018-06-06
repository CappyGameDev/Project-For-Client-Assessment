using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDropDestination : MonoBehaviour {

    //References The Game Manager
    public GameObject gameManager;

    //Used to Identify parameters for Quests
    public float RemainingClothes = 4;
    public float RemainingMoneyBags = 8;

    public AudioSource clothesAudio;
    public AudioSource moneyAudio;

    // Use this for initialization
    void Start()
    {

    }

    private void Update()
    {
        Debug.Log("There are Currently " + RemainingClothes + " Clothes Remaining.");
    }
    public void MoneyBagsQuest()
    {
        if (RemainingMoneyBags >= 0)
        {
            RemainingMoneyBags = RemainingMoneyBags - 1;
        }
        else
        {
            MoneyBagsComplete();
        }
    }

    public void ClothesQuest()
    {

        if (RemainingClothes == 3)
        {
            //clothesAudio.Play();
        }
        if (RemainingClothes >= 1)
        {
            RemainingClothes = RemainingClothes - 1;
            
        }
        if (RemainingClothes <= 0)
        {
            ClothesComplete();
        }
    }

    public void MoneyBagsComplete()
    {
        gameManager.GetComponent<GameManager>().StreetProgress();
    }

    public void ClothesComplete()
    {
        gameManager.GetComponent<GameManager>().HouseProgress();
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Money")
        {
            MoneyBagsQuest();
        }
       if (other.tag == "Clothes")
        {
            ClothesQuest();
        }
    }
}
