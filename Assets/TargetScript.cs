using System.Linq.Expressions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public int value = 1;

    public static List<GameObject> targets = new List<GameObject>();


    public static void resetTargets()
    {
        foreach(GameObject go in targets)
        {
            go.SetActive(true);
        }
    }
    bool added = false;
    // Start is called before the first frame update
    void Start()
    {
        if(!added)
        {
            added = true;
            targets.Add(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
