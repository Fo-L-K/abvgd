using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class task4 : MonoBehaviour
{
    [SerializeField] private Text text1;
    [SerializeField] private Text text2;
    Logger logger = new Logger();




    public class Logger
    {

        private string massage;


        

        public void getter(string text)
        {
            if (text == "")
            {
                massage = "netu";
            }
            else
            {
                massage = text;
            }

        }
        public string setter()
        {
            return massage;
        }

    }
    public void OnLoder()
    {
        logger.getter(text1.text);
        text2.text = logger.setter();
    }

    void Start()
    {
        
    }

   
}
