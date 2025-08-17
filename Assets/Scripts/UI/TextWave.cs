using UnityEngine;
using TMPro;

public class TextWave : MonoBehaviour
{
    public TMP_Text text;
    public GameManager gameManager;

    void Update()
    {
        if(gameManager.numWave <= 0)
        {
            text.text = "Wave : Incoming";
        }
        else if(gameManager.numWave > 0 && gameManager.numWave <= 9)
        {
            text.text = "Wave : " + gameManager.numWave;
        }
        else if (gameManager.numWave > 9){
            text.text = "Wave : Final";
        }
    }
}
