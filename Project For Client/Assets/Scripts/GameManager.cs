using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

    [HideInInspector]
    public bool moneyBagsQuest;
    [HideInInspector]
    public bool clothesQuest;

    public GameObject fader;

    // Use this for initialization
    void Start () {
        moneyBagsQuest = false;
        clothesQuest = false;

        fader.GetComponent<FadeMe>().FadeIn();

	}

    public void HouseProgress()
    {
        SceneManager.LoadScene("Street");
    }

    public void StreetProgress()
    {
        //Play Progression Audio here and do other stuff
    }
}
