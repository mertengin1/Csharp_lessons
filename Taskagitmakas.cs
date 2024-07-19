using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Taskagitmakas : Monobehaviour

{
    public string oyuncu1, oyuncu2;

    void start()
    {
        if (oyuncu1 == "taş" && oyuncu2 "kağıt")
        {
            Debug.Log("Oyuncu2 kağıt yaparak kazandı!");
        }
        else if (oyuncu1 == "taş" && oyuncu2 "makas")
        {
            Debug.Log("Oyuncu1 taş yaparak kazandı!");
        }
        else if (oyuncu1 == "kağıt" && oyuncu2 "taş")
        {
            Debug.Log("Oyuncu1 Kağıt yaparak kazandı!");
        }
        else if (oyuncu1 == "kağıt" && oyuncu2 "makas")
        {
            Debug.Log("Oyuncu2 makas yaparak kazandı!");
        }
        else if (oyuncu1 == "makas" && oyuncu2 "taş")
        {
            Debug.Log("Oyuncu2 taş yaparak kazandı!");
        }
        else if (oyuncu1 == "makas" && oyuncu2 "kağıt")
        {
            Debug.Log("Oyuncu1 makas yaparak kazandı!");
        }
        else ()
        {
            Debug.Log("Berabere");
        }
    }


    /*
        taş kağıt
        taş makas
        kağıt taş
        kağıt makas
        makas taş
        makas kağıt
    */
}