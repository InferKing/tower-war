using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foo
{
    IBar bar;
    public Foo(IBar bar) 
    { 
        this.bar = bar;
        Debug.Log(this.bar.ToString());
    }
}
public interface IBar { }
public class Bar : IBar { }
