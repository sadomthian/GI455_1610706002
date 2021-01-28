using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModTest : MonoBehaviour
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
        Hashtable perD = new Hashtable();
        perD.Add("Happy", "Happy");
        perD.Add("Run", "Run");
        perD.Add("Shoot", "Shoot");
        perD.Add("Walk", "Walk");
        foreach (string word in perD.Keys)
        {
            if (text = GameObject.Find(ipField.text))
            {

                Show.text = ipField.text + " found.";

            }
            else Show.text = ipField.text + " not found.";

        }
    }
}
