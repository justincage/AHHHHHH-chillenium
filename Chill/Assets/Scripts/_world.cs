using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;

public class _world : MonoBehaviour {

    public GameObject[] characters;
    GameObject currentCharacter;
    int charactersIndex;

	// Use this for initialization
	void Start () {
        charactersIndex = 0;
        currentCharacter = characters[0];
	}
	
	// Update is called once per frame
	void Update () {

        if (charactersIndex == 0)
        {
            GameObject.Find("SpriteCam").SetActive(true);
        }
        else
        {
            GameObject.Find("Main Camera").SetActive(false);
        }

        if (Input.GetKeyDown("left shift"))
        {
            charactersIndex++;
            if (charactersIndex == characters.Length)
            {
                charactersIndex = 0;
            }
        }
        currentCharacter.SetActive(false);
        GameObject.Find("Main Camera").SetActive(false);
	}
}
