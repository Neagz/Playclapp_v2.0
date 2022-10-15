using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public Text textNew;
    public Text textOld;

    void Update()
    {
        textNew.text = textOld.text;
    }
}
