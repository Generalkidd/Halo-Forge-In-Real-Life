using UnityEngine;
using System.Collections;
using System;
using UnityEngine.Networking;
using System.Collections.Generic;
using System.Text;
using Assets.Scripts.ApiClients.DataTypes;
using Assets.Scripts.DataTypes;

public class MenuManager : MonoBehaviour
{
    private const string barcode = "+0002F1";

    public MenuManager()
    {
        SelectedReason = -1;
        AdjustmentReasonIds = new List<int>();
        AdjustmentReasonNames = new List<string>();
    }

    public string Action { get; set; }

    private GameObject GameObject { get; set; }

    public int SelectedReason { get; set; }

    private int Count { get; set; }

    private int Increment { get; set; }

    private List<int> AdjustmentReasonIds { get; set; } 

    private List<string> AdjustmentReasonNames { get; set; }

    private Product product;

    private int index = 0;

    // Use this for initialization
    void Start()
    {
        //StartCoroutine(Get());
    }

    IEnumerator Get()
    {
        var geturi = new Uri("http://40.87.66.169:5073/getdetails/furniture/58239f264d41086272833fec"); //replace your url  
        var responseGet = UnityWebRequest.Get(geturi.ToString());
        yield return responseGet.Send();
        if (responseGet.isError)
        {
            Debug.Log(responseGet.error);
        }
        else
        {
        //    var temp = JsonConvert.DeserializeObject<List<ProductArray>>(response);
        //    var temp2 = temp[0];
        //    var temp3 = temp2.Product;
        //    StringBuilder builder = new StringBuilder();
        //    //foreach (string value in temp3)
        //    //{
        //    //    builder.Append(value);
        //    //}
        //    //product = JsonConvert.DeserializeObject<Product>(builder.ToString());
        }

        //if (AdjustmentReasonIds.Count == 0)
        //{
        //    geturi = new Uri("http://192.168.60.143/hololensapi/reasons/");
        //    responseGet = UnityWebRequest.Get(geturi.ToString());
        //    yield return responseGet.Send();
        //    if (responseGet.isError)
        //    {
        //        Debug.Log(responseGet.error);
        //    }
        //    else
        //    {
        //        string response = responseGet.downloadHandler.text;
        //        var adjustmentReasons = JsonConvert.DeserializeObject<List<AdjustmentReason>>(response);
        //        foreach(var reason in adjustmentReasons)
        //        {
        //            AdjustmentReasonIds.Add(reason.Id);
        //            AdjustmentReasonNames.Add(reason.Name);
        //        }
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        switch (Action)
        {
            case "-->":
                if (index > 2)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
                if (index == 0)
                {
                    GameObject = GameObject.Find("Option1");
                    GameObject.GetComponent<TextMesh>().text = "Soccer Ball";
                    GameObject = GameObject.Find("Option2");
                    GameObject.GetComponent<TextMesh>().text = "Hunter";
                    GameObject = GameObject.Find("Option3");
                    GameObject.GetComponent<TextMesh>().text = "Warthog";
                    GameObject = GameObject.Find("Option4");
                    GameObject.GetComponent<TextMesh>().text = "Ghost";
                }
                else if(index == 1)
                {
                    GameObject = GameObject.Find("Option1");
                    GameObject.GetComponent<TextMesh>().text = "Gravity Hammer";
                    GameObject = GameObject.Find("Option2");
                    GameObject.GetComponent<TextMesh>().text = "Golf Cup";
                    GameObject = GameObject.Find("Option3");
                    GameObject.GetComponent<TextMesh>().text = "Assault Rifle";
                    GameObject = GameObject.Find("Option4");
                    GameObject.GetComponent<TextMesh>().text = "Flamethrower";
                }
                else if(index == 2)
                {
                    GameObject = GameObject.Find("Option1");
                    GameObject.GetComponent<TextMesh>().text = "Plasma Rifle";
                    GameObject = GameObject.Find("Option2");
                    GameObject.GetComponent<TextMesh>().text = "Rocket Launcher";
                    GameObject = GameObject.Find("Option3");
                    GameObject.GetComponent<TextMesh>().text = "Scorpion";
                    GameObject = GameObject.Find("Option4");
                    GameObject.GetComponent<TextMesh>().text = "Shotgun";
                }
                Action = "";
                break;
            case "<--":
                if (index < 0)
                {
                    index = 2;
                }
                else
                {
                    index--;
                }
                if (index == 0)
                {
                    GameObject = GameObject.Find("Option1");
                    GameObject.GetComponent<TextMesh>().text = "Soccer Ball";
                    GameObject = GameObject.Find("Option2");
                    GameObject.GetComponent<TextMesh>().text = "Hunter";
                    GameObject = GameObject.Find("Option3");
                    GameObject.GetComponent<TextMesh>().text = "Warthog";
                    GameObject = GameObject.Find("Option4");
                    GameObject.GetComponent<TextMesh>().text = "Ghost";
                }
                else if (index == 1)
                {
                    GameObject = GameObject.Find("Option1");
                    GameObject.GetComponent<TextMesh>().text = "Gravity Hammer";
                    GameObject = GameObject.Find("Option2");
                    GameObject.GetComponent<TextMesh>().text = "Golf Cup";
                    GameObject = GameObject.Find("Option3");
                    GameObject.GetComponent<TextMesh>().text = "Assault Rifle";
                    GameObject = GameObject.Find("Option4");
                    GameObject.GetComponent<TextMesh>().text = "Flamethrower";
                }
                else if (index == 2)
                {
                    GameObject = GameObject.Find("Option1");
                    GameObject.GetComponent<TextMesh>().text = "Plasma Rifle";
                    GameObject = GameObject.Find("Option2");
                    GameObject.GetComponent<TextMesh>().text = "Rocket Launcher";
                    GameObject = GameObject.Find("Option3");
                    GameObject.GetComponent<TextMesh>().text = "Scorpion";
                    GameObject = GameObject.Find("Option4");
                    GameObject.GetComponent<TextMesh>().text = "Shotgun";
                }
                Action = "";
                break;
        }
    }

}
