using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendor : Functions {

 /* **************************************************************
 * ***************************************************************
 * ***************** Classname: Vendor           *****************
 * ***************** Project:   Modern Times     ***************** 
 * ***************** Author:    Kuraikari        *****************
 * ***************************************************************
 * *************************************************************** */

    public Vendor(int index, string special)
    {
        setID(index);
        setSpeciality(special);
    }

    public Vendor()
    {
        id = -1;
    }


}
