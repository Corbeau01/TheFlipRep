using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public Slider HealthSlider;
    public Text HealthText;
    public Slider ShieldSlider;
    public Text ShieldText;
    int turnCounter = 0;
    public enemy SelectedEnemie;
    public Transform[] PiecePoss;
    public Transform OutPieces;
    List<GameObject> PiecesEnjeu = new List<GameObject>();
    List<GameObject> PiecesOut = new List<GameObject>();
    public Image HelpText;
    public GameObject PiecePrefab;
    public Text SkillsLeft;
    public Text MaxHealthSkill;
    public Text MaxShieldSkill;
    private void Start()
    {
        
        SelectedEnemie = FindObjectOfType<enemy>();
        PlayerStats.selectedEnemy = SelectedEnemie;
        CoinBehavior[] piecesIngame = FindObjectsOfType<CoinBehavior>();
        foreach (CoinBehavior c in piecesIngame)
        {
            PlayerStats.numberOfPieces++;
            PlayerStats.Pieces.Add(c.gameObject);
            PiecesOut.Add(c.gameObject);
        }
        foreach (PiecesLib p in PlayerStats.PiecesList)
        {
            GameObject go = Instantiate(PiecePrefab, OutPieces.position, Quaternion.identity);
            go.GetComponent<CoinBehavior>().ID = p.ID;
            go.GetComponent<CoinBehavior>().assingMat();
            PiecesOut.Add(go);
            PlayerStats.numberOfPieces++;
            PlayerStats.Pieces.Add(go);


        }
        DrawPiece();
    }
    void Update()
    {
        HealthSlider.value = PlayerStats.health;
        HealthSlider.maxValue = PlayerStats.Maxhealth;
        HealthText.text = PlayerStats.health.ToString() + "=" + PlayerStats.Maxhealth.ToString();
        ShieldSlider.value = PlayerStats.Shield;
        ShieldSlider.maxValue = PlayerStats.MaxShield;
        ShieldText.text = PlayerStats.Shield.ToString() + "=" + PlayerStats.MaxShield.ToString();
        MaxHealthSkill.text = PlayerStats.Maxhealth.ToString();
        MaxShieldSkill.text = PlayerStats.MaxShield.ToString();
        SkillsLeft.text = PlayerStats.skillsPoints.ToString();
    }

    public void DrawPiece()
    {
        if(PlayerStats.selectedEnemy==null)
        {
            return;
        }
        if(PiecesOut.Count<1)
        {
            return;
        }
        int i = Random.Range(0, PiecesOut.Count);
        print(turnCounter);
        if(turnCounter<4)
        {
            PiecesOut[i].transform.position = PiecePoss[turnCounter].position;
            PiecesOut[i].transform.GetChild(0).transform.localPosition = (new Vector3(0.00f, 0.00f, 0.00f));
            PiecesEnjeu.Add(PiecesOut[i]);
            PiecesOut.RemoveAt(i);
        }
        else
        {
            print("reset");
            turnCounter = 0;
            foreach (GameObject go in PiecesEnjeu)
            {
                print("reset "+go.name);
                go.transform.position = OutPieces.position;
                PiecesOut.Add(go);
            }
            i = Random.Range(0, PiecesOut.Count);
            PiecesEnjeu.Clear();
            PiecesOut[i].transform.position = PiecePoss[turnCounter].position;
            PiecesOut[i].transform.GetChild(0).transform.localPosition = (new Vector3(0.00f, 0.00f, 0.00f));
            PiecesEnjeu.Add(PiecesOut[i]);
            PiecesOut.RemoveAt(i);
        }
        turnCounter++;
    }
}
