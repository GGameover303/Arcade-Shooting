using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLevel : MonoBehaviour
{
    [SerializeField] int levelGun;
    [SerializeField] List<GameObject> gunPoint;
                     bool addLevel;

    
    void Update()
    {
        if (addLevel)
        {
            addGun();
            addLevel = false;
        }
    }

    public void levelUp(int up)
    {
        levelGun += up;
        if(levelGun > gunPoint.Count)
        {
            levelGun = gunPoint.Count;
        }
        addLevel = true;
    }

    void addGun()
    {
        gunPoint[levelGun].SetActive(true);
        gunPoint[levelGun - 1].SetActive(false);
    }
}
