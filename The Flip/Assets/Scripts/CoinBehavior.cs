using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinBehavior : MonoBehaviour
{
    //              0 1 2    3        4         5      6      7     8       9      10     11     12     13     14     15      16      17     18
    public enum id {a,b,c,BerserkA,BerserkB,RangerA,RangerB,MedicA,MedicB,MedicC,MedicD,MedicE, MedicF, BlockA,BlockB,BlockC, BlockD, ThiefA,ThiefB};
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
        }
        if(ID==id.BerserkB)
        {
            Facemat.material = Mats[2];
            Pilemat.material = Mats[3];
            HelpText.sprite = helptextes[1];
            MyHelpText = helptextes[1];
        }
        if(ID==id.RangerA)
        {
            Facemat.material = Mats[4];
            Pilemat.material = Mats[5];
            HelpText.sprite = helptextes[2];
            MyHelpText = helptextes[2];
        }
        if (ID == id.RangerB)
        {
            Facemat.material = Mats[6];
            Pilemat.material = Mats[7];
            HelpText.sprite = helptextes[3];
            MyHelpText = helptextes[3];
        }
        if (ID == id.MedicA)
        {
            Facemat.material = Mats[8];
            Pilemat.material = Mats[9];
            HelpText.sprite = helptextes[4];
            MyHelpText = helptextes[4];
        }
        if (ID == id.MedicB)
        {
            Facemat.material = Mats[10];
            Pilemat.material = Mats[11];
            HelpText.sprite = helptextes[5];
            MyHelpText = helptextes[5];
        }
        if (ID == id.MedicC)
        {
            Facemat.material = Mats[12];
            Pilemat.material = Mats[13];
            HelpText.sprite = helptextes[6];
            MyHelpText = helptextes[6];
        }
        if (ID == id.MedicD)
        {
            Facemat.material = Mats[14];
            Pilemat.material = Mats[15];
            HelpText.sprite = helptextes[7];
            MyHelpText = helptextes[7];
        }

        if (ID == id.BlockA)
        {
            Facemat.material = Mats[16];
            Pilemat.material = Mats[17];
            HelpText.sprite = helptextes[8];
            MyHelpText = helptextes[8];
        }
        if (ID == id.BlockB)
        {
            Facemat.material = Mats[16];
            Pilemat.material = Mats[17];
            HelpText.sprite = helptextes[9];
            MyHelpText = helptextes[9];
        }
        if (ID == id.BlockC)
        {
            Facemat.material = Mats[18];
            Pilemat.material = Mats[19];
            HelpText.sprite = helptextes[10];
            MyHelpText = helptextes[10];
        }
        if (ID == id.ThiefA)
        {
            Facemat.material = Mats[20];
            Pilemat.material = Mats[21];
            HelpText.sprite = helptextes[11];
            MyHelpText = helptextes[11];
        }
        if (ID == id.ThiefB)
        {
            Facemat.material = Mats[22];
            Pilemat.material = Mats[20];
            HelpText.sprite = helptextes[12];
            MyHelpText = helptextes[12];
        }
        if (ID == id.BlockD)
        {
            Facemat.material = Mats[23];
            Pilemat.material = Mats[16];
            HelpText.sprite = helptextes[13];
            MyHelpText = helptextes[13];
        }
        if (ID == id.MedicE)
        {
            Facemat.material = Mats[24];
            Pilemat.material = Mats[25];
            HelpText.sprite = helptextes[14];
            MyHelpText = helptextes[14];
        }
        if (ID == id.MedicF)
        {
            Facemat.material = Mats[26];
            Pilemat.material = Mats[27];
            HelpText.sprite = helptextes[15];
            MyHelpText = helptextes[15];
        }
    }
    
    private void OnMouseUp()
    {
        if(PlayerStats.IsPlayerTurn)
        {
            Flip();
            //print("flip");
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
            this.transform.GetChild(0).Rotate(new Vector3(FlipRotation,FlipRotation,FlipRotation)*Time.deltaTime);
            

        }
        if(flipTimer>2)
        {
            flipping = false;
            this.transform.GetChild(0).transform.localPosition = (new Vector3(0.00f, 0.00f, 0.00f));
            
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
        rb.AddForce(transform.up*FlipForce);
        
    }
    void DrawPiece()
    {
        FindObjectOfType<PlayerController>().DrawPiece();
    }
    bool CheckIfUp()
    {
        if(this.transform.GetChild(1).GetComponent<CheckFace>().IsFaceUp==true)
        {
            return true;
        }
        else
        {
            return false;
        }
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
        }
        if(ID==id.BerserkB)
        {
            BerserkB();
        }
        if(ID==id.RangerA)
        {
            RangerA();
        }
        if(ID==id.RangerB)
        {
            RangerB();
        }
        if (ID == id.MedicA)
        {
            BuffA();
        }
        if (ID == id.MedicB)
        {
            BuffB();
        }
        if (ID == id.MedicC)
        {
            BuffC();
        }
        if (ID == id.MedicD)
        {
            BuffD();
        }
        if (ID == id.MedicE)
        {
            BuffE();
        }
        if (ID == id.BlockA)
        {
            BlockA();
        }
        if (ID == id.BlockB)
        {
            BlockB();
        }
        if (ID == id.BlockC)
        {
            BlockC();
        }
        if (ID == id.BlockD)
        {
            BlockD();
        }
        if (ID == id.ThiefA)
        {
            ThiefA();
        }
        if (ID == id.ThiefB)
        {
            ThiefB();
        }
        if (ID == id.MedicF)
        {
            ScaleA();
        }
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
            PlayerStats.health += 10;
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
            PlayerStats.health += 10;
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
            PlayerStats.selectedEnemy.TakeDamage(5);
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
        }
        else
        {
            PlayerStats.shieldMulti *= 2;
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
}
