using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
   void Update()
    {
        int escena_actual = SceneManager.GetActiveScene().buildIndex; //0,1,2,3 

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (escena_actual == 0)
            {
                cambioDeEscena(1);
            }
            else if (escena_actual == 1)
            {
                cambioDeEscena(2);
            }
            else if (escena_actual == 2)
            {
                cambioDeEscena(3);
            }
            else if (escena_actual == 3)
            {
                cambioDeEscena(4);
            }
            else if (escena_actual == 4)
            {
                cambioDeEscena(5);
            }
            else if(escena_actual ==5){
                cambioDeEscena(6);
            }
            else {
                cambioDeEscena(0);
            }

            
        }
    }

    public void cambioDeEscena(int index_escena_ir)
    {
        SceneManager.LoadScene(index_escena_ir);
    }
}
