using System.Numerics;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActivateSecondMenu : MonoBehaviour
{
    [SerializeField] private Canvas mainMenu;
    [SerializeField] private GameObject firstselectedMenu2;
    [SerializeField] private GameObject firstselectedMenu1;

    void Start()
    {
        mainMenu.transform.GetChild(2).gameObject.SetActive(false);
    }

    private void Update()
    {
        
    }

    public void Activate()
    {
        mainMenu.transform.GetChild(1).gameObject.SetActive(false);
        mainMenu.transform.GetChild(2).gameObject.SetActive(true);
        FindObjectOfType<EventSystem>().GetComponent<EventSystem>().SetSelectedGameObject(firstselectedMenu2);
    }

    public void DeActivate()
    {
        mainMenu.transform.GetChild(2).gameObject.SetActive(false);
        mainMenu.transform.GetChild(1).gameObject.SetActive(true);
        FindObjectOfType<EventSystem>().GetComponent<EventSystem>().SetSelectedGameObject(firstselectedMenu1);
        
    }
}

