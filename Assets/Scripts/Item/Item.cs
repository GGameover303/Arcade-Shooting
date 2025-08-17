using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] List<GameObject> items;
                     float rateDrop;
                     int itemRandom;

    public void itemDrop(Transform enemyPos)
    {
        rateDrop = Random.Range(0, 100);
        
        if(rateDrop <= 20)
        {
            itemRandom = Random.Range(0, items.Count);
            GameObject tmpItem = Instantiate(items[itemRandom],enemyPos.position,Quaternion.identity);
        }
    }
}
