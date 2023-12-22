using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class counter : MonoBehaviour
{
    public TMP_Text textObject;
    int count = 10;
    private void OnCollisionEnter(Collision collider)
    {
        count--;
        textObject.text = "count = " + count.ToString();
    }
}
