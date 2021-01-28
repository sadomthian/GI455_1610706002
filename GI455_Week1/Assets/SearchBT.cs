using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchBT : MonoBehaviour
{
    public InputField ipField;
    public Text Show;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Search()
    {
        List<string> list = new List<string>() { "Happy", "Walk", "Shoot", "Run","Jump" };
        foreach (string word in list)
        {
            if (text = GameObject.Find(ipField.text))
            {
           
                Show.text = ipField.text + " found.";
                
            }else Show.text = ipField.text + " not found.";
               
        }
    }
}
