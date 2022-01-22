using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFace : MonoBehaviour
{
    public bool IsFaceUp;
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        if(other.gameObject.name=="Face")
        {
            IsFaceUp = true;
        }
        else
        {
            IsFaceUp = false;
        }
    }
}
