﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomItemPlacer : MonoBehaviour {

    public GameObject[] items;
    public GameObject health;

    public void PlaceItem(Transform parent)
    {
        int rnd;
        do rnd = Random.Range(0, items.Length);
        while (CheckIfSpawnedItem(items[rnd]));
        GameObject item = Instantiate(items[rnd], parent);
        GameManager.instance.spawnedItems.Add(item);
    }

    public void PlaceHealth(Transform parent)
    {
        Vector3 spawnPos = parent.position;
        if (parent.childCount > 0)
        {
            spawnPos = parent.position + Vector3.right * parent.childCount * 2f;
        }

        Instantiate<GameObject>(health, spawnPos, Quaternion.identity, parent);
    }

    bool CheckIfSpawnedItem(GameObject item)
    {
        bool check = false;
        int i = 0;
        List<GameObject> spawnedItems = GameManager.instance.spawnedItems;

        while(i < spawnedItems.Count && !check)
        {
            if (spawnedItems.Contains(item)) check = true;
            i++;
        }

        return check;
    }
}
