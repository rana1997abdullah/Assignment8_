using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       string [] arr = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
       int i = 0;
       string str = "";
       while(i<7){
        int num = Random.Range(0,arr.Length);
        str+=" "+arr[num];
        i++;
       }
       Debug.Log("My Funny Sentence is "+str);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
