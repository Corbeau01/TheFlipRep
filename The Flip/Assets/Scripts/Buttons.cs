using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public GameObject ChooseReward;
   public void BerserkChoice()
    {
        int i = Random.Range(3, 5);
        CoinBehavior.id id = CoinBehavior.id.BerserkA;
        PlayerStats.NewPiece(id);
    }
    public void BerserkRanChoice()
    {
        int i = Random.Range(3, 5);
        CoinBehavior.id id = (CoinBehavior.id)i;
        PlayerStats.NewPiece(id);
    }
    public void RangerChoice()
    {
        int i = Random.Range(5, 7);
        CoinBehavior.id id = CoinBehavior.id.RangerA;
        PlayerStats.NewPiece(id);
    }
    public void RangerRanChoice()
    {
        int i = Random.Range(5, 7);
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
        int i = Random.Range(17, 19);
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
        int i = Random.Range(13, 17);
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
        int i = Random.Range(7, 13);
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
}
