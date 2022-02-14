﻿using System;
using System.Collections.Generic;

//source https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0

//Simple business object. A PartId is used to identify the
//type of part but the part name can change
public class Part : IEquatable<Part>
{
    public string PartName {get; set;}
    public int PartId {get; set;}
    public override string ToString()
    {
        return "ID: " + PartId + "   Name:  " + PartName;
        }
    public override bool Equals(object obj)//Equals method definition requirement
    {
        if (obj == null) return false;
        Part objAsPart = obj as Part; //as operator is used to perform conversion between compatible reference types
        if (objAsPart == null) return false;
        else return Equals(ObjAsPart);
    }

    public override int GetHashCode()
    {
        return PartId;
    }

    public bool Equals(Part other)
    {
        if (other == null) return false;
        return (this.PartId.Equals(other.PartId));
    }
}

public class Example
{
    public static void Main()
    {
        //Create a list of parts.
        List<Part> parts = new List<Part>();
        
        //add parts to the list
    }
}