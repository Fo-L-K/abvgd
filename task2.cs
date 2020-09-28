using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task2 : MonoBehaviour
{
    public class NPC
    {
        public int charisma;
        public int intelligence;
        public int stamina;


        public NPC(int charisma = 0, int intelligence = 0, int stamina = 0)
        {
            this.charisma = charisma;
            this.intelligence = intelligence;
            this.stamina = stamina;
        }

        public void Write()
        {
            Debug.Log(charisma + " " + intelligence + " " + stamina);
        }

    }



    void Start()
    {
        NPC airic = new NPC(5);
        NPC oyshen = new NPC(3, 6, 8);
        airic.Write();
        oyshen.Write();
        airic.stamina = 3;
        oyshen.intelligence = 10;
        airic.Write();
        oyshen.Write();


    }

}
