using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        int selectedcharater =
            int.Parse(EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.charIndex = selectedcharater;
        SceneManager.LoadScene(Constants.GAMEPLAY_TAG);
    }
}
