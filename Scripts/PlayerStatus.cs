using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerStatus : MonoBehaviour
{
    public TMP_Text playerstatus;
    //public Text playerstatus;
    [SerializeField]
    private FloatSO statusSO;

    /*public void OnEnable()
    {
        statusSO.Value += UpdatePlayerStatus;
    }*/ //cannot attache scriptable object to game object. 
    //Must reference SO instance in another script

    private void OnEnable()
    {
        statusSO.myObject = gameObject;
        playerstatus = GetComponent<TextMeshProUGUI>();
    }


    public void UpdatePlayerStatus()
    {
        PlayerStatus playerStatus = new PlayerStatus();
        
        Debug.Log(playerstatus.text);


       if (statusSO.Value == 1)
        {
            playerstatus.text = "Underweight";
            //Debug.Log(playerstatus.text);
        }
        else if(statusSO.Value == 2)
        {
            playerstatus.text = "Healthy";
           // Debug.Log(playerstatus.text);
        }
        else if (statusSO.Value == 3)
        {
            playerstatus.text = "Overweight";
        }
        else if (statusSO.Value == 4)
        {
            playerstatus.text = "Obese";
        }
    }
   
}
