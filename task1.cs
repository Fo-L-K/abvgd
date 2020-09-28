using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task1 : MonoBehaviour
{
    public class Robot
    {


        public static int weght = 0;
        public static int strange = 0;
        public static int speed = 0;

        public Robot()
        {

        }

        public void Debugs()
        {
            Debug.Log(weght);
            Debug.Log(strange);
            Debug.Log(speed);

        }

        public void Rand()
        {
            weght = Random.Range(0, 10);
            strange = Random.Range(0, 10);
            speed = Random.Range(0, 10);
        }
    }

    void Start()
    {
        Robot robot = new Robot();
        robot.Debugs();
        robot.Rand();
        robot.Debugs();


    }


}
