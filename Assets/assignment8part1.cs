using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment8part1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var random = new System.Random();
        for(int i=0;i<20;i++){
            int num = random.Next(1,21);
            if(num==15) break;
            if(num==5) continue;
            Debug.Log(num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
