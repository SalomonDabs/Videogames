using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject kirby;
    public GameObject kirby2;

    public void hide(){
        kirby.SetActive(false);
        kirby2.SetActive(false);
    }

    public void show(){
        kirby.SetActive(true);
        kirby2.SetActive(true);
    }
}
