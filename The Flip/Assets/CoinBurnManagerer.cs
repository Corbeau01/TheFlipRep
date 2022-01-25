using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBurnManagerer : MonoBehaviour
{
    //on prend 4 coins au hazard dans coins list et on les mets devant
    public GameObject[] coinsPositions;
    public GameObject PiecePrefab;
    public GameObject BurnFX;
    private void Start()
    {
        if(PlayerStats.PiecesList.Count>4)
        {
            
            int i = Random.Range(0, PlayerStats.PiecesList.Count);
            int j = Random.Range(0, PlayerStats.PiecesList.Count);
            int k = Random.Range(0, PlayerStats.PiecesList.Count);
            int l = Random.Range(0, PlayerStats.PiecesList.Count);
            while(i==j)
            {
                j = Random.Range(0, PlayerStats.PiecesList.Count);
            }
            while(i==k||j==k)
            {
                k = Random.Range(0, PlayerStats.PiecesList.Count);
            }
            while (i == l || j == l||k==l)
            {
                l = Random.Range(0, PlayerStats.PiecesList.Count);
            }
            GameObject go = Instantiate(PiecePrefab, coinsPositions[0].transform.position, Quaternion.identity);
            go.GetComponent<CoinBehavior>().ID = PlayerStats.PiecesList[i].ID;
            go.GetComponent<CoinBehavior>().assingMat();
            go = Instantiate(PiecePrefab, coinsPositions[1].transform.position, Quaternion.identity);
            go.GetComponent<CoinBehavior>().ID = PlayerStats.PiecesList[j].ID;
            go.GetComponent<CoinBehavior>().assingMat();
            go = Instantiate(PiecePrefab, coinsPositions[2].transform.position, Quaternion.identity);
            go.GetComponent<CoinBehavior>().ID = PlayerStats.PiecesList[k].ID;
            go.GetComponent<CoinBehavior>().assingMat();
            go = Instantiate(PiecePrefab, coinsPositions[3].transform.position, Quaternion.identity);
            go.GetComponent<CoinBehavior>().ID = PlayerStats.PiecesList[l].ID;
            go.GetComponent<CoinBehavior>().assingMat();
        }
        else
        {
            for (int i = 0; i < PlayerStats.PiecesList.Count; i++)
            {
                GameObject go = Instantiate(PiecePrefab, coinsPositions[i].transform.position, Quaternion.identity);
                go.GetComponent<CoinBehavior>().ID = PlayerStats.PiecesList[i].ID;
                go.GetComponent<CoinBehavior>().assingMat();
            }
        }
        PlayerStats.IsAtCHauldron = true;
    }
}
