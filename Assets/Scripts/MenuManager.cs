using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour
{
    public string gameType = "";
    GameObject tmp;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    switch(gameType)
        {
            case "Halo 1":
                tmp = GameObject.Find("Option1");
                tmp.GetComponent<TextMesh>().text = "Weapons";
                tmp = GameObject.Find("Option2");
                tmp.GetComponent<TextMesh>().text = "Vehicles";
                tmp = GameObject.Find("Option3");
                tmp.GetComponent<TextMesh>().text = "Objects";
                tmp = GameObject.Find("Option4");
                tmp.GetComponent<TextMesh>().text = "Characters";
                break;
            case "Halo 2":
                tmp = GameObject.Find("Option1");
                tmp.GetComponent<TextMesh>().text = "Weapons";
                tmp = GameObject.Find("Option2");
                tmp.GetComponent<TextMesh>().text = "Vehicles";
                tmp = GameObject.Find("Option3");
                tmp.GetComponent<TextMesh>().text = "Objects";
                tmp = GameObject.Find("Option4");
                tmp.GetComponent<TextMesh>().text = "Characters";
                break;
            case "Halo 3":
                tmp = GameObject.Find("Option1");
                tmp.GetComponent<TextMesh>().text = "Weapons";
                tmp = GameObject.Find("Option2");
                tmp.GetComponent<TextMesh>().text = "Vehicles";
                tmp = GameObject.Find("Option3");
                tmp.GetComponent<TextMesh>().text = "Objects";
                tmp = GameObject.Find("Option4");
                tmp.GetComponent<TextMesh>().text = "Characters";
                break;
            case "Halo 4":
                tmp = GameObject.Find("Option1");
                tmp.GetComponent<TextMesh>().text = "Weapons";
                tmp = GameObject.Find("Option2");
                tmp.GetComponent<TextMesh>().text = "Vehicles";
                tmp = GameObject.Find("Option3");
                tmp.GetComponent<TextMesh>().text = "Objects";
                tmp = GameObject.Find("Option4");
                tmp.GetComponent<TextMesh>().text = "Characters";
                break;
        }
	}
}
