using UnityEngine;
using System.Collections;

public class MenuSelect : MonoBehaviour
{
    public bool isReasons;
    public int reasonId;

    private string Action { get; set; }

    private GameObject tmp;
    
	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isReasons)
        {
            GameObject tmp = GameObject.Find("MenuTitle");
            if(tmp.GetComponent<MenuManager>().SelectedReason != reasonId)
            {
                this.GetComponent<TextMesh>().color = Color.green;
            }
            else
            {
                this.GetComponent<TextMesh>().color = Color.red;
            }
        }
    }

    void OnSelect()
    {
        if (isReasons)
        {
            Action = this.GetComponent<TextMesh>().text;
            GameObject tmp = GameObject.Find("MenuTitle");
            tmp.GetComponent<MenuManager>().SelectedReason = reasonId;
            this.GetComponent<TextMesh>().color = Color.red;
        }
        else
        {
            Action = this.GetComponent<TextMesh>().text;
            if (Action == "-->" || Action == "<--")
            {
                tmp = GameObject.Find("MenuTitle");
                tmp.GetComponent<MenuManager>().Action = Action;
            }
            else
            {
                GameObject tmp2 = GameObject.Find("Menu");
                tmp = GameObject.Find(Action);
                Instantiate(tmp, new Vector3(tmp2.transform.position.x - 2, tmp2.transform.position.y, tmp2.transform.position.z), Quaternion.identity);
            }
        }
    }
}
