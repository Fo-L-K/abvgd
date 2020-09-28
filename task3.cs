using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task3 : MonoBehaviour
{
    Fighter fighter = new Fighter(5, 25);
    Fighter fighter1 = new Fighter(1, 20);
    Fighter fighter2 = new Fighter(10, 30);
    Fighter[] fighters = new Fighter[3];

    public class Fighter
    {
        public int damage;
        private int hp;


        public Fighter(int damage = 10, int hp = 100)
        {
            this.damage = damage;
            this.hp = hp;
        }

        public void CouseDamage(Fighter enemy)
        {
            enemy.hp -= damage;
        }
        public void TakeDamage(Fighter enemy)
        {
            hp -= enemy.damage;
        }

        public int live()
        {
            return hp;
        }


    }
   

    void Start()
    {
        fighters[0] = fighter;
        fighters[1] = fighter1;
        fighters[2] = fighter2;


        
    }
    void Update()
    {
        for (int i = 0; i < fighters.Length; i++)
        {
            int j = Random.Range(0, 3);

            if (fighters[i].live() > 0)
            {
                if (fighters[i] != fighters[j] && fighters[j].live() > 0)
                {
                    fighters[i].CouseDamage(fighters[j]);
                }
                else
                {
                    continue;
                }
            }
        }
        int die = 0;

        for (int i = 0; i < fighters.Length; i++)
        {
            if (fighters[i].live() <= 0)
            {
                die++;
            }
        }
        if (die == 2)
        {
            for (int i = 0; i < fighters.Length; i++)
            {
                if (fighters[i].live() > 0)
                {
                    Debug.Log("win " + (i + 1) + "hp " + fighters[i].live());
                }
            }
        }
        else
        {
            for (int i = 0; i < fighters.Length; i++)
            {
                Debug.Log((i + 1) + " " + fighters[i].live());
            }
        }
    }


}

