using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject topBun;
    public GameObject bottomBun;
    public GameObject patty;

    public GameObject addon1;
    public GameObject addon2;
    public GameObject addon3;

    public GameObject cheese1;
    public GameObject cheese2;
    public GameObject cheese3;
    public GameObject lettuce1;
    public GameObject lettuce2;
    public GameObject lettuce3;
    public GameObject tomato1;
    public GameObject tomato2;
    public GameObject tomato3;
    public GameObject pickles1;
    public GameObject pickles2;
    public GameObject pickles3;
    public GameObject sauce1;
    public GameObject sauce2;
    public GameObject sauce3;

    public Dropdown addon1Drop;
    public Dropdown addon2Drop;
    public Dropdown addon3Drop;

    public void Create()
    {
        topBun.SetActive(true);
        bottomBun.SetActive(true);
        patty.SetActive(true);
        switch(addon1Drop.value)
        {
            case 1:
                cheese1.SetActive(true);
                break;
            case 2:
                lettuce1.SetActive(true);
                break;
            case 3:
                tomato1.SetActive(true);
                break;
            case 4:
                pickles1.SetActive(true);
                break;
            case 5:
                sauce1.SetActive(true);
                break;
        }
        switch (addon2Drop.value)
        {
            case 1:
                cheese2.SetActive(true);
                break;
            case 2:
                lettuce2.SetActive(true);
                break;
            case 3:
                tomato2.SetActive(true);
                break;
            case 4:
                pickles2.SetActive(true);
                break;
            case 5:
                sauce2.SetActive(true);
                break;
        }
        switch (addon3Drop.value)
        {
            case 1:
                cheese3.SetActive(true);
                break;
            case 2:
                lettuce3.SetActive(true);
                break;
            case 3:
                tomato3.SetActive(true);
                break;
            case 4:
                pickles3.SetActive(true);
                break;
            case 5:
                sauce3.SetActive(true);
                break;
        }
    }

    public void Reset()
    {
        topBun.SetActive(false);
        bottomBun.SetActive(false);
        patty.SetActive(false);
        cheese1.SetActive(false);
        lettuce1.SetActive(false);
        tomato1.SetActive(false);
        pickles1.SetActive(false);
        sauce1.SetActive(false);
        cheese2.SetActive(false);
        lettuce2.SetActive(false);
        tomato2.SetActive(false);
        pickles2.SetActive(false);
        sauce2.SetActive(false);
        cheese3.SetActive(false);
        lettuce3.SetActive(false);
        tomato3.SetActive(false);
        pickles3.SetActive(false);
        sauce3.SetActive(false);
    }
}
