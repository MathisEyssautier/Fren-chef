using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIngredients : MonoBehaviour
{
    public GameObject boutsViande1;
    public GameObject boutsViande2;
    public GameObject boutsViande3;
    public GameObject boutsViande4;
    public GameObject boutsViande5;
    public GameObject boutsOnion1;
    public GameObject boutsOnion2;
    public GameObject boutsOnion3;
    public GameObject boutsOnion4;
    public GameObject boutsOnion5;
    public GameObject boutsMush1;
    public GameObject boutsMush2;
    public GameObject boutsMush3;
    public GameObject boutsMush4;
    public GameObject BoeufBourg;
    public bool isCooked = false;
    public Material mat1;
    private int cpt = 0;

    void OnTriggerEnter(Collider col)
    {
        if(col.name == "Meat bit1" || col.name == "Meat bit2" || col.name == "Meat bit3" || col.name == "Meat bit4" || col.name == "Meat bit5" || col.name == "OnionBit1" || col.name == "OnionBit2" || col.name == "OnionBit3" || col.name == "OnionBit4" || col.name == "OnionBit5" || col.name == "MushBit1" || col.name == "MushBit2" || col.name == "MushBit3" || col.name == "MushBit4")
        {
            cpt += 1;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.name == "Meat bit1" || col.name == "Meat bit2" || col.name == "Meat bit3" || col.name == "Meat bit4" || col.name == "Meat bit5" || col.name == "OnionBit1" || col.name == "OnionBit2" || col.name == "OnionBit3" || col.name == "OnionBit4" || col.name == "OnionBit5" || col.name == "MushBit1" || col.name == "MushBit2" || col.name == "MushBit3" || col.name == "MushBit4")
        {
            cpt -= 1;
        }
    }

    public void Cook()
    {
        if(cpt == 14)
        {
            boutsViande1.SetActive(false);
            boutsViande2.SetActive(false);
            boutsViande3.SetActive(false);
            boutsViande4.SetActive(false);
            boutsViande5.SetActive(false);
            boutsOnion1.SetActive(false);
            boutsOnion2.SetActive(false);
            boutsOnion3.SetActive(false);
            boutsOnion4.SetActive(false);
            boutsOnion5.SetActive(false);
            boutsMush1.SetActive(false);
            boutsMush2.SetActive(false);
            boutsMush3.SetActive(false);
            boutsMush4.SetActive(false);
            BoeufBourg.SetActive(true);
            isCooked = true;
        }
    }
}
