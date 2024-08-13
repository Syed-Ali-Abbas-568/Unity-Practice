using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillSliderBar : MonoBehaviour
{

    public Slider _slider;

    public float health=2f;

    // Start is called before the first frame update
    void Start()
    {
        _slider.value=0f;

    }

    public void UpdateHealth(){

        _slider.value=1/health;
        if(_slider.value>=1)
        {
            Destroy(gameObject);
        }
    }
}
