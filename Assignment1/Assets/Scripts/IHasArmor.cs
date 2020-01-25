using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Warren Guiles
* IHasArmor.cs
* Assignment 1

* This is one of the interfaces my classes implement. It 
is meant for enemies that have armor and has two methods: one
for the armor to weaken and one for the armor to break.
*/
namespace assignment1
{
    public interface IHasArmor 
    {
    void WeakenArmor();
    void BreakArmor();
    }
}

