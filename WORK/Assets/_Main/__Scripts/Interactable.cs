using UnityEngine;
using UnityEngine.SceneManagement;

///Summary:
/// This script gets placed on 
public class Interactable : MonoBehaviour
{
    public string Loc = "";

    public void Pressed()
    {
        SceneManager.LoadScene(Loc);
    }
}