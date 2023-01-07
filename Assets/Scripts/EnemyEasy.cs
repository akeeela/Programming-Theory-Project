using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class EnemyEasy : Enemy
{
   //POLYMORPHISM
   protected override void Move()
   {
      transform.Translate(Vector3.back * Time.deltaTime * speed);  
   }

   private void Start()
   {
      speed = 2;
   }

   void Update()
   {
      Move();
   }
}
