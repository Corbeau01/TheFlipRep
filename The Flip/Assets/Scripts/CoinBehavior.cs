using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinBehavior : MonoBehaviour
{
    //              0 1 2    3        4         5      6          7     8       9      10     11     12     13     14      15      16      17       18     19     20       21      22     23
    public enum id {a,b,c,BerserkA,BerserkB,BerserkC,BerserkD,BerserkE,RangerA,RangerB,RangerC,MedicA,MedicB,MedicC,MedicD,MedicE, MedicF,MedicFF, BlockA,BlockB,BlockC, BlockD, ThiefA,ThiefB};
    public id ID;
    bool flipping = false;
    Rigidbody rb;
    float flipTimer = 0;
    float FlipRotation = 180;
    bool IsAttacking = false;
    float AttackTimer = 0;
    public Material[] Mats;
    public Sprite[] helptextes;
    float MouseOverTimer = 0;
    Sprite MyHelpText;
    private void Start()
    {
        rb = transform.GetChild(0).GetComponent<Rigidbody>();
        assingMat();
        this.transform.GetChild(2).transform.GetChild(0).transform.position = new Vector3(10.5f, 3, 12);
    }
    public void assingMat()
    {
        MeshRenderer Facemat = this.transform.GetChild(0).transform.GetChild(0).GetComponent<MeshRenderer>();
        MeshRenderer Pilemat = this.transform.GetChild(0).GetComponent<MeshRenderer>();
        SpriteRenderer HelpText = this.transform.GetChild(2).transform.GetChild(0).GetComponent<SpriteRenderer>();
        if (ID==id.BerserkA)
        {
            Facemat.material = Mats[0];
            Pilemat.material = Mats[1];
            HelpText.sprite = helptextes[0];
            MyHelpText = helptextes[0];
            return;
        }
        if(ID==id.BerserkB)
        {
            Facemat.material = Mats[2];
            Pilemat.material = Mats[3];
            HelpText.sprite = helptextes[1];
            MyHelpText = helptextes[1];
            return;
        }
        if(ID==id.RangerA)
        {
            Facemat.material = Mats[4];
            Pilemat.material = Mats[5];
            HelpText.sprite = helptextes[2];
            MyHelpText = helptextes[2];
            return;
        }
        if (ID == id.RangerB)
        {
            Facemat.material = Mats[6];
            Pilemat.material = Mats[7];
            HelpText.sprite = helptextes[3];
            MyHelpText = helptextes[3];
            return;
        }
        if (ID == id.MedicA)
        {
            Facemat.material = Mats[8];
            Pilemat.material = Mats[9];
            HelpText.sprite = helptextes[4];
            MyHelpText = helptextes[4];
            return;
        }
        if (ID == id.MedicB)
        {
            Facemat.material = Mats[10];
            Pilemat.material = Mats[11];
            HelpText.sprite = helptextes[5];
            MyHelpText = helptextes[5];
            return;
        }
        if (ID == id.MedicC)
        {
            Facemat.material = Mats[12];
            Pilemat.material = Mats[13];
            HelpText.sprite = helptextes[6];
            MyHelpText = helptextes[6];
            return;
        }
        if (ID == id.MedicD)
        {
            Facemat.material = Mats[14];
            Pilemat.material = Mats[15];
            HelpText.sprite = helptextes[7];
            MyHelpText = helptextes[7];
            return;
        }

        if (ID == id.BlockA)
        {
            Facemat.material = Mats[16];
            Pilemat.material = Mats[17];
            HelpText.sprite = helptextes[8];
            MyHelpText = helptextes[8];
            return;
        }
        if (ID == id.BlockB)
        {
            Facemat.material = Mats[16];
            Pilemat.material = Mats[17];
            HelpText.sprite = helptextes[9];
            MyHelpText = helptextes[9];
            return;
        }
        if (ID == id.BlockC)
        {
            Facemat.material = Mats[18];
            Pilemat.material = Mats[19];
            HelpText.sprite = helptextes[10];
            MyHelpText = helptextes[10];
            return;
        }
        if (ID == id.ThiefA)
        {
            Facemat.material = Mats[20];
            Pilemat.material = Mats[21];
            HelpText.sprite = helptextes[11];
            MyHelpText = helptextes[11];
            return;
        }
        if (ID == id.ThiefB)
        {
            Facemat.material = Mats[22];
            Pilemat.material = Mats[20];
            HelpText.sprite = helptextes[12];
            MyHelpText = helptextes[12];
            return;
        }
        if (ID == id.BlockD)
        {
            Facemat.material = Mats[23];
            Pilemat.material = Mats[16];
            HelpText.sprite = helptextes[13];
            MyHelpText = helptextes[13];
            return;
        }
        if (ID == id.MedicE)
        {
            Facemat.material = Mats[24];
            Pilemat.material = Mats[25];
            HelpText.sprite = helptextes[14];
            MyHelpText = helptextes[14];
            return;
        }
        if (ID == id.MedicF)
        {
            Facemat.material = Mats[26];
            Pilemat.material = Mats[27];
            HelpText.sprite = helptextes[15];
            MyHelpText = helptextes[15];
            return;
        }
        CoinsClass CC=null;
        if (ID==id.BerserkC)
        {
           CC = FindObjectOfType<BerserkC>();
            
        }
        if (ID == id.BerserkD)
        {
            CC = FindObjectOfType<BerserkD>();

        }
        if (ID == id.BerserkD)
        {
            CC = FindObjectOfType<BerserkE>();

        }
        if (ID == id.RangerC)
        {
            CC = FindObjectOfType<RangerC>();

        }
        if (ID == id.MedicFF)
        {
            CC = FindObjectOfType<MedicFF>();

        }
        if (ID == id.BlockD)
        {
            CC = FindObjectOfType<BlockD>();

        }
        if(CC!=null)
        {
            Facemat.material = CC.FaceMat;
            Pilemat.material = CC.PileMat;
            HelpText.sprite = CC.HelpText;
            MyHelpText = CC.HelpText;
            CA = CC.CoinAction;
        }
        
    }
    delegate void CoinAction();
    CoinAction CA;
    private void OnMouseUp()
    {
        if(PlayerStats.IsPlayerTurn)
        {
            Flip();
            this.transform.GetChild(0).gameObject.GetComponent<location_coin>().flip();
            //print("flip");
        }
        if(PlayerStats.IsAtCHauldron)
        {
            BurnPiece(ID);
        }
    }
    private void OnMouseOver()
    {
        MouseOverTimer += Time.deltaTime;
        if(MouseOverTimer>2)
        {
            FindObjectOfType<PlayerController>().HelpText.sprite = MyHelpText;
            FindObjectOfType<PlayerController>().HelpText.gameObject.SetActive(true);
        }
    }
    private void OnMouseExit()
    {
        MouseOverTimer = 0;
        this.transform.GetChild(2).gameObject.SetActive(false);
        FindObjectOfType<PlayerController>().HelpText.gameObject.SetActive(false);
    }
    private void Update()
    {
       if(flipping)
        {
            flipTimer += Time.deltaTime;
            //this.transform.GetChild(0).Rotate(new Vector3(FlipRotation,FlipRotation,FlipRotation)*Time.deltaTime);
            

        }
        if(flipTimer>2)
        {
            flipping = false;
          //  this.transform.GetChild(0).transform.localPosition = (new Vector3(0.00f, 0.00f, 0.00f));
            
            IsAttacking = true;
            flipTimer = 0;
            
        }
        if(IsAttacking)
        {
            AttackTimer += Time.deltaTime;
            if(AttackTimer>1)
            {
                DoCoinAction();
                DrawPiece();
                PlayerStats.IsEnemyTurn = true;
                IsAttacking = false;
                AttackTimer = 0;

            }
            
        }
        /*if(flipping==false)
        {
            if (this.transform.GetChild(0).localPosition.x != 0|| this.transform.GetChild(0).localPosition.z != 0)
            {
                this.transform.GetChild(0).localPosition = new Vector3(0, 0, 0);
                this.transform.GetChild(0).localRotation = Quaternion.Euler(0,0,0);
            }
        }*/
    }
    void Flip()
    {
        PlayerStats.IsPlayerTurn = false;
        float FlipForce = Random.Range(300, 800);
        //print("flippin");
        FlipRotation = Random.Range(-360f,360f);
        flipping = true;
        //rb.AddForce(transform.up*FlipForce);
        
    }
    void DrawPiece()
    {
        FindObjectOfType<PlayerController>().DrawPiece();
    }
    bool CheckIfUp()
    {
        return this.transform.GetChild(0).gameObject.GetComponent<location_coin>().ISFace;
    }
    void DoDamage(int dmg)
    {
        int dmgg = (dmg + PlayerStats.selectedEnemy.BonusDamageTaken)*PlayerStats.dmgmulti;
        PlayerStats.selectedEnemy.health -= dmgg;
        PlayerStats.dmgmulti = 1;
    }
    void DoCoinAction()
    {
        
        if (ID == id.BerserkA)
        {
            BerserkA();
            return;
        }
        if(ID==id.BerserkB)
        {
            BerserkB();
            return;
        }
        if (ID == id.BerserkC)
        {
            BerserkerC();
            return;
        }
        if (ID == id.BerserkD)
        {
            BerserkerD();
            return;
        }
        if (ID == id.BerserkE)
        {
            BerserkerE();
            return;
        }
        if (ID==id.RangerA)
        {
            RangerA();
            return;
        }
        if(ID==id.RangerB)
        {
            RangerB();
            return;
        }
        if (ID == id.RangerC)
        {
            RangerC();
            return;
        }
        if (ID == id.MedicA)
        {
            BuffA();
            return;
        }
        if (ID == id.MedicB)
        {
            BuffB();
            return;
        }
        if (ID == id.MedicC)
        {
            BuffC();
            return;
        }
        if (ID == id.MedicD)
        {
            BuffD();
            return;
        }
        if (ID == id.MedicE)
        {
            BuffE();
            return;
        }
        if (ID == id.BlockA)
        {
            BlockA();
            return;
        }
        if (ID == id.BlockB)
        {
            BlockB();
            return;
        }
        if (ID == id.BlockC)
        {
            BlockC();
            return;
        }
        if (ID == id.BlockD)
        {
            BlockD();
            return;
        }
        if (ID == id.ThiefA)
        {
            ThiefA();
            return;
        }
        if (ID == id.ThiefB)
        {
            ThiefB();
            return;
        }
        if (ID == id.MedicF)
        {
            ScaleA();
            return;
        }
        if (ID == id.MedicFF)
        {
            BuffF();
            return;
        }
        CA();
    }
   void BerserkA()
    {
        if(CheckIfUp())
        {
            PlayerStats.health -= 10;
            DoDamage(15);
        }
        else
        {
            DoDamage(15);
        }
        
    }
    void BerserkB()
    {
        if(CheckIfUp())
        {
            if(PlayerStats.health<50)
            {
                DoDamage(20);
            }
        }
        else
        {
            DoDamage(10);
        }
    }
    void RangerA()
    {
        if(CheckIfUp())
        {
            int dmg = Random.Range(10,20);
            DoDamage(dmg);
        }
        else
        {

        }
    }
    void RangerB()
    {
        if (CheckIfUp())
        {
            DoDamage(10);
        }
        else
        {
            if(PlayerStats.selectedEnemy.IsRange)
            {
                DoDamage(20);
            }
        }
    }
    void BuffA()
    {
        if (CheckIfUp())
        {
            PlayerStats.heal(10);
        }
        else
        {
            PlayerStats.health -= 5;
        }
    }
    void BuffB()
    {
        if (CheckIfUp())
        {
            PlayerStats.heal(10);
        }
        else
        {
            int healvalue = Random.Range(1, 10);
            PlayerStats.selectedEnemy.health += healvalue;
        }
    }
    void BuffC()
    {
        if (CheckIfUp())
        {
            PlayerStats.selectedEnemy.BonusDamageTaken += 5;
        }
        else
        {
            PlayerStats.selectedEnemy.BonusDamage += 1;
        }
    }
    void BuffD()
    {
        if (CheckIfUp())
        {

        }
        else
        {

        }
    }
    void BuffE()
    {
        if (CheckIfUp())
        {
            DoDamage(1);
        }
        else
        {
            PlayerStats.selectedEnemy.BonusDamageTaken += 1;
        }
    }
    void BlockA()
    {
        if (CheckIfUp())
        {
            PlayerStats.GainShield(10);
        }
        else
        {

        }
    }
    void BlockB()
    {
        if (CheckIfUp())
        {
            int shield = Random.Range(1, 20);
            PlayerStats.GainShield(shield);
        }
        else
        {

        }
    }
    void BlockC()
    {
        if (CheckIfUp())
        {
            PlayerStats.GainShield(PlayerStats.Shield);
        }
        else
        {
            DoDamage(PlayerStats.Shield);
            PlayerStats.Shield = 0;
        }
    }
    void BlockD()
    {
        if (CheckIfUp())
        {
            PlayerStats.GainShield(5);
            DoDamage(5);
        }
        else
        {
            PlayerStats.GainShield(3);
        }
    }
    void ThiefA()
    {
        if (CheckIfUp())
        {
            int gold = Random.Range(1, 4);
            PlayerStats.gold += gold;
        }
        else
        {
            int dmg = Random.Range(1, 10);
            PlayerStats.health -= dmg;
        }
    }
    void ThiefB()
    {
        if (CheckIfUp())
        {
            DoDamage(5);
        }
        else
        {
            PlayerStats.gold += 1;
        }
    }
    void ScaleA()
    {
        if (CheckIfUp())
        {
            PlayerStats.dmgmulti *= 5;
            PlayerStats.health -= 5;
        }
        else
        {
            PlayerStats.shieldMulti *= 2;
        }
    }
    void BerserkerC()
    {
        if (CheckIfUp())
        {
            PlayerStats.dmgmulti *= 2;
        }
        else
        {
            DoDamage(10);
            PlayerStats.health -= 5;
        }
    }
    void BerserkerD()
    {
        if (CheckIfUp())
        {
            PlayerStats.dmgmulti *= 2;
        }
        else
        {

            PlayerStats.health -= 10;
        }
    }
    void BuffF()
    {
        int i = Random.Range(1, 20);
        if (CheckIfUp())
        {
            PlayerStats.heal(i);
        }
        else
        {
            PlayerStats.healMulti *= 2;
        }
        
    }
    void RangerC()
    {
        if (CheckIfUp())
        {
            int i = Random.Range(1, 30);
            DoDamage(i);
        }
        else
        {
            
        }
    }
    void BerserkerE()
    {
        int i = Random.Range(1, 20);
        if (CheckIfUp())
        {
            DoDamage(i);
            PlayerStats.heal(i);
        }
        else
        {

            DoDamage(i);
        }
    }
    void BlockE()
    {
        if (CheckIfUp())
        {

        }
        else
        {

        }
    }
    public void BurnPiece(CoinBehavior.id ID)
    {
        for (int i = 0; i < PlayerStats.PiecesList.Count; i++)
        {
            if(PlayerStats.PiecesList[i].ID==ID)
            {
                PlayerStats.PiecesList.RemoveAt(i);
                break;
            }
        }
        GameObject fx = FindObjectOfType<CoinBurnManagerer>().BurnFX;
        Instantiate(fx, this.transform.position+new Vector3(0,-1.5f,0), Quaternion.identity);
        PlayerStats.IsAtCHauldron = false;
    }
}
