﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    //public Text loadingText;
   // public Image progressBar;
    private int curProgressValue = 0;

    void FixedUpdate()
    {
        int progressValue = 100;

        if (curProgressValue < progressValue)
        {
            curProgressValue++;
        }

       /* loadingText.text = "夏目正在努力加载哦..." + curProgressValue + "%";//实时更新进度百分比的文本显示  

        progressBar.fillAmount = curProgressValue / 100f;//实时更新滑动进度图片的fillAmount值  

        if (curProgressValue == 100)
        {
            loadingText.text = "OK";//文本显示完成OK
            SceneManager.LoadScene("Menu");
        }*/
    }
}

