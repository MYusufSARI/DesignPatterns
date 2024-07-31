using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int pointsPerLevel = 200;
    int experincePoints;

    public static Action onLevelUp;


    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);

            GainExperience(10);
        }
    }


    public void GainExperience(int points)
    {
        int level = GetLevel();

        experincePoints += points;

        if (GetLevel() > level)
            onLevelUp?.Invoke();
            
    }


    public int GetExperience()
    {
        return experincePoints;
    }


    public int GetLevel()
    {
        return experincePoints / pointsPerLevel;
    }
}
