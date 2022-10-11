using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_changing : MonoBehaviour
{
    public void scene1(string scenename)
    {
        scenename = "Scene_1";
        SceneManager.LoadScene(scenename);
    }
    public void scene2(string scenename)
    {
        scenename = "Scene_2";
        SceneManager.LoadScene(scenename);
    }
    public void scene3(string scenename)
    {
        scenename = "Scene_3";
        SceneManager.LoadScene(scenename);
    }

    public void Master(string scenename)
    {
        scenename = "Master";
        SceneManager.LoadScene(scenename);
    }
}
