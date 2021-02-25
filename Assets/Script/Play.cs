using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    int i;
    Animator anim,textnim;
    GameObject gameObject;
    Scrollbar scrollbar;

     void Start()
    {
        gameObject = GameObject.Find("Scrollbar Vertical");
    }
    public void playsteb()
    {
        anim = GetComponent<Animator>();
        scrollbar = gameObject.GetComponent<Scrollbar>();
        if (i <= 13)
        {
            ++i;
            if(i == 1)
            {
                anim.Play("Text1");
            }
            else if(i == 2)
            {
                anim.Play("Text2");
            }
            else if(i == 3)
            {
                anim.Play("Text3");
            }
            else if (i == 4)
            {
                anim.Play("Text4");
            }
            else if(i == 5)
            {
                anim.Play("Text5");
            }
            else if (i == 6)
            {
                anim.Play("Text6");
            }
            else if(i == 7)
            {
                anim.Play("Text7");
                
            }
            else if (i == 8)
            {
                anim.Play("Text8");
                
                scrollbar.value = 0;
            }
            else if(i == 9)
            {
                anim.Play("Text9");
            }
            else if (i == 10)
            {
                anim.Play("Text10");
            }
            else if(i == 11)
            {
                anim.Play("Text11");
            }
            else if (i == 12)
            {
                anim.Play("Text12");
            }
            else if (i == 13)
            {
                anim.Play("Text13");
            }
            else if (i == 14)
            {
                anim.Play("Text14");
            }
        }
    }
    public void backsteb()
    {
        anim = GetComponent<Animator>();
        scrollbar = gameObject.GetComponent<Scrollbar>();
        if (i == 2)
            {
                anim.Play("Text1");
                --i;
            }
            else if (i == 3)
            {
                anim.Play("Text2");
                --i;
            }
        else if (i == 4)
        {
            anim.Play("Text3");
            --i;
        }
        else if (i == 5)
        {
            anim.Play("Text4");
            --i;
        }
        else if (i == 6)
        {
            anim.Play("Text5");
            --i;
        }
        else if (i == 7)
        {
            anim.Play("Text6");
            --i;
        }
        else if (i == 8)
        {
            anim.Play("Text7");
            scrollbar.value = 1;
            --i;
        }
        else if (i == 9)
        {
            anim.Play("Text8");
            --i;
        }
        else if (i == 10)
        {
            anim.Play("Text9");
            --i;
        }
        else if (i == 11)
        {
            anim.Play("Text10");
            --i;
        }
        else if (i == 12)
        {
            anim.Play("Text11");
            --i;
        }
        else if (i == 13)
        {
            anim.Play("Text12");
            --i;
        }
        else if (i == 14)
        {
            anim.Play("Text13");
            --i;
        }

    }
    public void explode()
    {
        anim = GetComponent<Animator>();
        anim.Play("modelanim");
    }
    public void back()
    {
        anim = GetComponent<Animator>();
        anim.Play("Back");
    }
    public void stebbysteb(int j)
    {
        i = j;
        playsteb();
    }
}
