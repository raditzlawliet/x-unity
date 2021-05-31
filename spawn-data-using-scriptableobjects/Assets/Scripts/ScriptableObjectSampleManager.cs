using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TheFlavare.Basic.Data;

public class ScriptableObjectSampleManager : MonoBehaviour
{
    public PositionData positionA, positionB;
    public string addictiveSceneA, addictiveSceneB;
    public bool isIncludeLoadAddictiveScene;
    public GameObject mainPoint;
    public Toggle toggle;

    public void Reset()
    {
        SceneManager.UnloadSceneAsync(addictiveSceneA);
        SceneManager.UnloadSceneAsync(addictiveSceneB);
        move("");
    }
    public void Move(string to)
    {
        if (isIncludeLoadAddictiveScene)
        {
            string sceneName = addictiveSceneA;
            if (to.ToLower() == "b") sceneName = addictiveSceneB;

            if (SceneManager.GetSceneByName(sceneName).isLoaded) {
                move(to);
                return;
            }

            AsyncOperation async = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
            async.completed += (iasync) =>
            {
                move(to);
            };
        }
        else
        {
            move(to);
        }
    }

    void move(string to)
    {
        switch (to.ToLower())
        {
            case "a":
                mainPoint.transform.position = positionA.position;
                break;
            case "b":
                mainPoint.transform.position = positionB.position;
                break;
            default:
                mainPoint.transform.position = Vector3.zero;
                break;
        }
    }

    public void SetIncludeLoadAddictiveScene()
    {
        isIncludeLoadAddictiveScene = toggle.isOn;
    }
}
