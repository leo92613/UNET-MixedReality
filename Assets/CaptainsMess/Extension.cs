using System.Collections;
using System.Collections.Generic;


public static class Extension{
    public static int Hash(this string str)
    {
        int hash = 0;
        foreach(char c in str)
        {
            hash += (int)c;
        }
        return hash;
    }
}
