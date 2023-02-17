using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье
   public int health = 5;
    //Уровень
   public int level = 1;
    //Скорость
   public float speed = 1.2f;
    void Start()
    {
        health = health + level;
        print("жизни:"+ health);
    }

    
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z +=
speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
