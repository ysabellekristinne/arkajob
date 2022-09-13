using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEffect : MonoBehaviour
{
    string press = "Pressione ENTER para começar";

    char[] ctr;

    public Text viewer;

    // Start is called before the first frame update
    void Start()
    {
        ctr = press.ToCharArray();
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        int count = 0;
        while (count < ctr.Length)
        {
            yield return new WaitForSeconds(0.1f);
            viewer.text += ctr[count];

            count++;
        }
    }
}
