using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Operatörler : Monobehaviour

{
    int a = 1, b = 2;
    void start()
    {
        if (a < b)
        {
            Debug.Log("a b den küçükmüş")
        }
        else if (a < b || a == b)
        {
            Debug.Log("A b den küçük veya a b eşit")
        }
        else (b < a)
        {

        }
    }

    /* 
            Karşşılaştırma operatörleri
        < küçükse
        > büyükse
        <= küçük veya eşitse
        >= büyük veya eşitse
        == eşitse
        != eşit değilse
            Mantıksal operatörler
        ! not : Taşıdığı operatörün tam tersi anlamı
        && ve
        || veya
        
    */
}