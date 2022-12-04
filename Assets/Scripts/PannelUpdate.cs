using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PannelUpdate : MonoBehaviour
{
    isOnBoard plancheChecker;
    MeatKnife meatOnionChecker;
    CheckIngredients cookedChecker;
    public GameObject planche;
    public GameObject couteau;
    public GameObject casserole;
    public GameObject texte;
    public GameObject texte2;
    public GameObject texte3;
    public GameObject texte4;
    public GameObject texte5;
    
    private int cpt = 0;

    void Awake()
    {
        plancheChecker = planche.GetComponent<isOnBoard>();
        meatOnionChecker = couteau.GetComponent<MeatKnife>();
        cookedChecker = casserole.GetComponent<CheckIngredients>();
    }

    void Update()
    {
        if(plancheChecker.isOn == true && cpt == 0)
        {
            texte.SetActive(false);
            texte2.SetActive(true);
            cpt += 1;
        }

        if(meatOnionChecker.meatCut == true && cpt == 1)
        {
            texte2.SetActive(false);
            texte3.SetActive(true);
            cpt += 1;
        }

        if(meatOnionChecker.onionCut == true && meatOnionChecker.mushCut == true && cpt == 2)
        {
            texte3.SetActive(false);
            texte4.SetActive(true);
            cpt += 1;
        }

        if(cookedChecker.isCooked == true && cpt == 3)
        {
            texte4.SetActive(false);
            texte5.SetActive(true);
            cpt += 1;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(cpt==4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
