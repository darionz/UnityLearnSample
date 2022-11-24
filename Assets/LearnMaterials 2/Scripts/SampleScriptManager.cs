using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScriptManager : MonoBehaviour
{
    [SerializeField]
    List<SampleScript> sampleScripts;

    [ContextMenu("Запустить Use() у каждого наследника")]
    public void UseScripts()
    {
        foreach(var item in sampleScripts)
        {
            item.Use();
        }
    }

}
