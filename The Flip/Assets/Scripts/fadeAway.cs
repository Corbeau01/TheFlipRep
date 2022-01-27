using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fadeAway : MonoBehaviour
{
    float i = 1;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i -= 0.2f * Time.deltaTime;
        this.GetComponent<Text>().color = new Color(1,0.8f,0,i);
        t += Time.deltaTime;
        if(t>3)
        {
            this.gameObject.SetActive(false);
        }
    }
}
