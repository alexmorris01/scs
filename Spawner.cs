using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
public GameObject[] objectospawn;
public  int max = 12;
public  int min = 12;
public int minusnumber = 1;
public int count;
public void NewSpawn()
{
//makes the random not random at all. this will make the array spawn each object one after the other, when requested
min = min  -  minusnumber;
max = max -  minusnumber;
print("new email");
            GameObject obj1 = Instantiate(objectospawn[Random.Range(min, max)]) as GameObject;
            obj1.transform.parent = gameObject.transform;
         }
     }