using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats
{
    public static int health = 100;
    public static int Maxhealth = 100;
    public static enemy selectedEnemy;
    public static bool IsPlayerTurn = true;
    public static bool IsEnemyTurn = false;
    public static int Shield = 10;
    public static int MaxShield = 10;
    public static int gold = 0;
    public static int numberOfPieces = 0;
    public static List<GameObject> Pieces = new List<GameObject>();
    public static List<PiecesLib> PiecesList = new List<PiecesLib>();
    public static int dmgmulti=1;
    public static int shieldMulti = 1;
    public static void TakeDamage(int dmg)
    {
        if(Shield>0)
        {
            if(Shield>=dmg)
            {
                Shield -= dmg;
            }
            else
            {
                
                int dmgg = dmg - Shield;
                Shield = 0;
                health -= dmgg;
            }
        }
        else
        {
            health -= dmg;
        }
    }
    public static void GainShield(int shieldGain)
    {
        int shieldGainn = shieldGain * shieldMulti;
        if(Shield+shieldGainn>=MaxShield)
        {
            Shield = MaxShield;
        }
        else
        {
            Shield += shieldGainn;
        }
        shieldMulti = 1;
    }
    public static void NewPiece(CoinBehavior.id id)
    {
        PiecesLib p = new PiecesLib();
        p.ID = id;
        PiecesList.Add(p);
    }
}
