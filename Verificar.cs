
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Verificar : MonoBehaviour {
    public Block painel;
    public void run()
    {
        Debug.Log("Call run");
        foreach (Block block in painel.blocks)
        {
            debugBlock("Principal panel ", block);
            Transform conteiner = block.transform.Find("conteiner");
            if (conteiner != null)
            {
                Debug.Log("Temos conteiner");
                Transform panel = conteiner.transform.Find("Panel");
                if (panel != null)
                {
                    Debug.Log("Temos Panel " + panel.childCount);
                    if(panel.childCount >= 0)
                    {
                        for (int i = 0; i > panel.childCount; i++)
                        {
                            Debug.Log(panel.GetChild(i).ToString());
                        }
                    }
                }
                else
                {
                    Debug.Log("Não Temos conteiner");
                }
            }
        }
    }

    void debugBlock(string s ,Block block)
    {
        Debug.Log("Block: "+ s + block.ToString());
    }
    
}
