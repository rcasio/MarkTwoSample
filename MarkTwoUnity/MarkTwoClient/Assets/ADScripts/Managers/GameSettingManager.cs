using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSettingManager : SingletonDestroyMonoBehaviour<GameSettingManager> {

    public DataManager dataManager;
    
	void Awake() {
        
        Screen.SetResolution(1280, 720, true);
    }
}
