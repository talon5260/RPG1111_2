using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;
    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(11, new string[] { "...zzZ:0", "...zzZ?:0" });
        talkData.Add(12, new string[]{"Ah...?:1", "Ahchoo!!:0" });
        talkData.Add(101, new string[] { "Warning / Dungeon Trap" });

        portraitData.Add(11 +0, portraitArr[0]);
        portraitData.Add(12 +0, portraitArr[1]);
        portraitData.Add(12 +1, portraitArr[2]);
    }
    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
        {
            return null;
        }
        else 
        {
            return talkData[id][talkIndex];
        }      
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[id + portraitIndex];
    }
}
