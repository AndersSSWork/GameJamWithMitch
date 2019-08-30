using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject Main;
    [SerializeField] GameObject Settings;
    [SerializeField] GameObject Credits;

    private OpenMenu openMenu = OpenMenu.main;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            openMenu = OpenMenu.main;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            openMenu = OpenMenu.settings;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            openMenu = OpenMenu.credits;
        }

        if (Input.GetKeyDown(KeyCode.P) && openMenu == OpenMenu.main)
        {
            OnPlay();
        }

        Main.SetActive(false);
        Settings.SetActive(false);
        Credits.SetActive(false);

        switch (openMenu)
        {
            case OpenMenu.main:
                Main.SetActive(true);
                break;
            case OpenMenu.settings:
                Settings.SetActive(true);
                break;
            case OpenMenu.credits:
                Credits.SetActive(true);
                break;
            default:
                break;
        }
    }

    public void onChangeMenu(int menu)
    {
        openMenu = (OpenMenu)menu;
    }

    public void OnPlay()
    {
        SceneManager.LoadScene("Map");
    }

    public void OnExit()
    {
        // QUIT
    }
}

public enum OpenMenu
{
    main,
    settings,
    credits
}
