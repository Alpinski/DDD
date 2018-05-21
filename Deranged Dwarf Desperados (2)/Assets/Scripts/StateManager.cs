using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StateManager : MonoBehaviour {

    private Scene mainScene;
    private Scene menuScene;

    private List<Scene> scenes;

    private float counter;
	// Use this for initialization
	void Start () {
        //    scenes.Add(mainScene);
        //   scenes.Add(menuScene);

    }
	
	// Update is called once per frame
	void Update () {
        counter += Time.deltaTime;
          
	}

    public void switchScenes(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Main");

        while(!asyncLoad.isDone && counter < 6)
        {
            if (counter > 5)
            {
                yield return null;
            }
        }
    }
}
