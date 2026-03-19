using System.Runtime.InteropServices;
using UnityEngine;

public class scripts1 : MonoBehaviour
{
    public string firstVariable;
    public string secomdVarible ="¹w³]­È";

    private string privateVar;
    protected string proectedVar;

    public float playerSpeed = 1.0f;

   public void PrintVariable()
    {
        print(playerSpeed);

        Instantiate(this.gameObject);
    }
}
