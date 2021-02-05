using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;

namespace Week2_Programchat
{
public class Wepsocketconnet : MonoBehaviour
{
        private WebSocket websocket;
        public Text Showchat;
        public InputField _Input;
        public GameObject ip;
        public GameObject port;
        public GameObject login_ui;
        public GameObject chat_ui;
        public Text x;
        

        // Start is called before the first frame update
        void Start()
    {
            
            //websocket = new WebSocket("ws://127.0.0.1:5500");

            //websocket.OnMessage += OnMassage;
            //websocket.Connect();
            //Connect();
            //websocket.Send("A");
        }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                chating();
                
            }

    }
       
        private void OnDestroy()
        {
            if (websocket != null)
            {
                websocket.Close();
            }
        }
        public void OnMassage(object sender , MessageEventArgs messageEventArgs)
        {
            Showchat.text += "" + messageEventArgs.Data + "\n";
            Debug.Log("Receive msg : "+ messageEventArgs.Data);
        }
        public void Connect()
        {
            //x.text = ip.GetComponent<Text>().text;
            websocket = new WebSocket("ws://"+ip.GetComponent<Text>().text+":" + port.GetComponent<Text>().text);
            
            websocket.OnMessage += OnMassage;
            //Debug.Log(x.text);
            login_ui.SetActive(false);
            chat_ui.SetActive(true);
            websocket.Connect();   

        }
        public void chating()
        {
            if (websocket.ReadyState == WebSocketState.Open)
           {
                websocket.Send(""+_Input.GetComponent<InputField>().text);
                //Debug.Log(websocket);
                
            }
        }
    }
}


