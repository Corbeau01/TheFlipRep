using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerer : MonoBehaviour
{
    bool isMapOpen = false;
    bool isStatsOpen = false;
    public GameObject Map;
    public GameObject stats;
    public GameObject DoorsFx;
    public GameObject DoorsButtons;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            
            OpenCloseMap();
        }

    }
    public void showDoors()
    {
        DoorsFx.SetActive(true);
        DoorsButtons.SetActive(true);
    }
    public void OpenCloseMap()
    {
        isMapOpen = !isMapOpen;
        if (isMapOpen)
        {
            Map.SetActive(true);
        }
        else
        {
            Map.SetActive(false);
        }
    }
    public void OpenCloseStats()
    {
        isStatsOpen = !isStatsOpen;
        if (isStatsOpen)
        {
            stats.SetActive(true);
        }
        else
        {
            stats.SetActive(false);
        }
    }
}
