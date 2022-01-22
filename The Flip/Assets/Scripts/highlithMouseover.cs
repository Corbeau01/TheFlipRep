using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class highlithMouseover : MonoBehaviour
{
    private void OnMouseOver()
    {
        this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.35f);
    }
    private void OnMouseExit()
    {
        this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
    }
}
