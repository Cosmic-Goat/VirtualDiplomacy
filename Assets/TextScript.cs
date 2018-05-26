using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TextScript : MonoBehaviour {

    public Slider slider;
    public Text yearsss;
    string[] data = new string[10];
    
    List<string> years = new List<string>();
    // Use this for initialization
    void Start () {
       slider.onValueChanged.AddListener(delegate { TextUpdate(); });

        yearsss = GetComponent<Text>();
        for(int i = 0; i < data.Length; i++)
        {
            years.Add("Year: " + data[i]);
        }
	}
	
	// Update is called once per frame
	public void TextUpdate ()
    {
        Debug.Log((int)slider.value);
        yearsss.text = years[(int)slider.value];
    }
}
