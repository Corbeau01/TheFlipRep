using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public GameObject ChooseReward;
   public void BerserkChoice()
    {
        int i = Random.Range(3, 8);
        CoinBehavior.id id = CoinBehavior.id.BerserkA;
        PlayerStats.NewPiece(id);
    }
    public void BerserkRanChoice()
    {
        int i = Random.Range(3, 8);
        CoinBehavior.id id = (CoinBehavior.id)i;
        PlayerStats.NewPiece(id);
    }
    public void RangerChoice()
    {
        int i = Random.Range(8, 11);
        CoinBehavior.id id = CoinBehavior.id.RangerA;
        PlayerStats.NewPiece(id);
    }
    public void RangerRanChoice()
    {
        int i = Random.Range(8, 11);
        CoinBehavior.id id = (CoinBehavior.id)i;
        PlayerStats.NewPiece(id);
    }
    public void TheifChoice()
    {
        CoinBehavior.id id = CoinBehavior.id.ThiefB;
        PlayerStats.NewPiece(id);
    }
    public void TheifRanChoice()
    {
        int i = Random.Range(22, 24);
        CoinBehavior.id id = (CoinBehavior.id)i;
        PlayerStats.NewPiece(id);
    }
    public void BlockChoice()
    {
        CoinBehavior.id id = CoinBehavior.id.BlockD;
        PlayerStats.NewPiece(id);
    }
    public void BlockRanChoice()
    {
        int i = Random.Range(18, 22);
        CoinBehavior.id id = (CoinBehavior.id)i;
        PlayerStats.NewPiece(id);
    }
    public void MedicChoice()
    {
        CoinBehavior.id id = CoinBehavior.id.MedicE;
        PlayerStats.NewPiece(id);
    }
    public void MedicRanChoice()
    {
        int i = Random.Range(11, 18);
        CoinBehavior.id id = (CoinBehavior.id)i;
        PlayerStats.NewPiece(id);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
    public void ChooseRewardSetActiveFalse()
    {
        ChooseReward.SetActive(false);
    }
    public void plusHealth()
    {
        if(PlayerStats.skillsPoints>0)
        {
            PlayerStats.skillsPoints--;
            PlayerStats.Maxhealth++;
        }
    }
    public void PlusHield()
    {
        if(PlayerStats.skillsPoints > 0)
        {
            PlayerStats.skillsPoints--;
            PlayerStats.MaxShield++;
        }
    }
    public void GoLeft()
    {
        PlayerStats.CurrentRoom = PlayerStats.LeftRoom;
        IndexRooms();
        SceneManager.LoadScene(PlayerStats.CurrentRoom);
    }
    public void GoRight()
    {
        PlayerStats.CurrentRoom = PlayerStats.rightRoom;
        IndexRooms();
        SceneManager.LoadScene(PlayerStats.CurrentRoom);
    }
    public void KillParent()
    {
       
        //this.transform.parent.gameObject.SetActive(false);
    }
    void IndexRooms()
    {
        if (PlayerStats.CurrentRoom == 1)
        {
            PlayerStats.LeftRoom = 2;
            PlayerStats.rightRoom = 3;
        }
        if (PlayerStats.CurrentRoom == 2)
        {
            PlayerStats.LeftRoom = 4;
            PlayerStats.rightRoom = 5;
        }
        if (PlayerStats.CurrentRoom == 3)
        {
            PlayerStats.LeftRoom = 5;
            PlayerStats.rightRoom = 6;
        }
        if (PlayerStats.CurrentRoom == 4)
        {
            PlayerStats.LeftRoom = 7;
            PlayerStats.rightRoom = 7;
        }
        if (PlayerStats.CurrentRoom == 5)
        {
            PlayerStats.LeftRoom = 7;
            PlayerStats.rightRoom = 8;
        }
        if (PlayerStats.CurrentRoom == 6)
        {
            PlayerStats.LeftRoom = 8;
            PlayerStats.rightRoom = 8;
        }
        if (PlayerStats.CurrentRoom == 7)
        {
            PlayerStats.LeftRoom = 9;
            PlayerStats.rightRoom = 9;
        }
        if (PlayerStats.CurrentRoom == 8)
        {
            PlayerStats.LeftRoom = 9;
            PlayerStats.rightRoom = 9;
        }
        if (PlayerStats.CurrentRoom == 9)
        {
            PlayerStats.LeftRoom = 10;
            PlayerStats.rightRoom = 10;
        }
        if (PlayerStats.CurrentRoom == 10)
        {
            PlayerStats.LeftRoom = 1;
            PlayerStats.rightRoom = 1;
            PlayerStats.ASC += 1;
        }
    }
}
