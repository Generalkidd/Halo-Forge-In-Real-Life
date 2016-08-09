using UnityEngine;
using System.Collections;

public class MenuSelect : MonoBehaviour
{
    string category = "";
    
	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnSelect()
    {
        category = this.GetComponent<TextMesh>().text;
        GameObject tmp = GameObject.Find("MenuTitle");
        tmp.GetComponent<MenuManager>().gameType = category;
    }
}
