using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatKnife : MonoBehaviour
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
    public bool mushCut = false;
    public bool meatCut = false;
    public bool onionCut = false;

    void OnTriggerEnter(Collider col)
    {
        if(col.name == "Meat")
        {
            GameObject grosViande = GameObject.Find("Meat");
            grosViande.GetComponent<Renderer>().enabled = false;
            boutsViande1.SetActive(true);
            boutsViande2.SetActive(true);
            boutsViande3.SetActive(true);
            boutsViande4.SetActive(true);
            boutsViande5.SetActive(true);
            meatCut = true;
        }

        if (col.name == "Onion")
        {
            GameObject grosOnion = GameObject.Find("Onion");
            grosOnion.GetComponent<Renderer>().enabled = false;
            boutsOnion1.SetActive(true);
            boutsOnion2.SetActive(true);
            boutsOnion3.SetActive(true);
            boutsOnion4.SetActive(true);
            boutsOnion5.SetActive(true);
            onionCut = true;
        }

        if(col.name == "mushroom")
        {
            GameObject grosMush = GameObject.Find("mushroom");
            grosMush.GetComponent<Renderer>().enabled = false;
            boutsMush1.SetActive(true);
            boutsMush2.SetActive(true);
            boutsMush3.SetActive(true);
            boutsMush4.SetActive(true);
            mushCut = true;
        }
    }
}
