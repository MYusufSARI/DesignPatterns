using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int pointsPerLevel = 200;
    int experincePoints;


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
        experincePoints += points;
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
