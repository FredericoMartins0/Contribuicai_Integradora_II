using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerController : MonoBehaviour
{
    public static int click = 0;
    public Text text_box;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        text_box.text = string.Format("{0}", click);
    }

    public void Clique()
    {
            click += 1;
    }

    public void ResetClique()
    {
        click = 0;
        text_box.text = string.Format("{0}", click);
    }
}
