using UnityEngine;
using UnityEngine.UI;

public class ExitExecuter : MonoBehaviour
{
    public Button exitButton;

    void Start()
    {
        if (exitButton != null)
        {
            exitButton.onClick.AddListener(OnExitButtonClicked);
        }
        else
        {
            Debug.LogWarning("Exit button reference not set");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnExitButtonClicked()
    {
        Application.Quit();
    }
}
