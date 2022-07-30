using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botata : MonoBehaviour
{
    // hero is a nerd and needs specifications
        string heroName = "nerd";
        int heroHeight = 150;
        int heroAge = 420;
        string heroSuperPower = "super bad at math";

    // villain is super cool and kills jews ( we dont like jews)
        string villainName = "HITLER";
        int villainHeight = 156 ;
        int villainAge = 69420 ;
        string villainSuperPower = "INSANELY GOOD AT UR MUM HAH (AND MATH)" ;
    // age pepperoni or smting

    int ageDifference = 69420 - 420;
    
   

    void Start()
    {
        print ("hi im " + heroName + " im " + heroAge + "years old" + "my superpower is" + heroSuperPower + " ALSOOOOO im " + heroHeight + "cm");

        print (" HOI IM " + villainName + " OIM " + villainAge + "years old" + " MOY SUBERBOWER IZ " + villainSuperPower + " AND OIM " + villainHeight + "cm");

        print (" the age difference is " + ageDifference);

        print(" nerd's height is now " + 150 + 5 + "cm");

        print(" HITLER'S superpower is now None ");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}