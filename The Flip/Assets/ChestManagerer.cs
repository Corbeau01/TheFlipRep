using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManagerer : MonoBehaviour
{
    public GameObject Chest;
    public GameObject ChestFX;
    bool startScene = true;
    public GameObject PlusSkillsPointsText;
    public GameObject DoorsButtons;

    private void Update()
    {
        if(Input.anyKey)
        {
            if(startScene)
            {
                Chest.SetActive(false);
                ChestFX.SetActive(true);
                PlusSkillsPointsText.SetActive(true);
                DoorsButtons.SetActive(true);
                int i = Random.Range(1, 3);
                if(i==1)
                {

                }
                else
                {

                }
                PlayerStats.skillsPoints += 10;
                startScene = false;
            }
            
        }
        
    }
}
