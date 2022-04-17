using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Extentions  
{
     public static float TrySingle(this string self)
    {
        if (Single.TryParse(self, out var result))
            {
             return result;
            }
             return 0;
    }

    public static int TryInt(this string self)
    {
      if (Int32.TryParse(self, out var result))
        {
            return result;
        }
        return 0;
    }


}
