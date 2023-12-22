using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactivate : MonoBehaviour
{
    public GameObject obj;
    int switcher = 0;
    public void activate()
    {
        if (switcher == 0)
        {
            obj.SetActive(false);
            switcher = 1;
        }
        else
        {
            obj.SetActive(true);
            switcher = 0;
        }
    }
}
