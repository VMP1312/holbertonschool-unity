using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject InfoCard;
    private bool InfoStatus; 
    // Start is called before the first frame update
    void Start()
    {
        InfoCard.SetActive(false);
        InfoStatus = false; 
    }
    private void Show()
    {
        InfoCard.SetActive(true);
        InfoStatus = true;
    }
    private void Hide()
    {
        InfoCard.SetActive(false);
        InfoStatus = false;
    }
    public void Changer()
    {
        if(InfoStatus == false)
            Show();
        else
            Hide();
    }
}
