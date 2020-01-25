using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Warren Guiles
* IPoolerObject.cs
* Assignment 1

* This is one of the interfaces my classes implement. It 
is meant for objects that would be spawned from an object pooler.
*/
namespace assignment1
{
    public interface IPoolerObject
    {
    void SpawnFromPool();
    }
}

