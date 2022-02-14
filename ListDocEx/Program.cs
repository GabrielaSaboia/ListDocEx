using System;
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
        
        //add parts to the list.
        parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
        parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
        parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
        parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
        parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
        parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });
        
        //Write out the parts in the list. This will call the overridden
        //ToString method in the Part class
        Console.WriteLine();
        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }
        
        //Check the list for part #1734. This calls the IEquatable. Equals method
        // of the Part class, which checks the PartId for equality.
        Console.WriteLine("\nContains(\"1734\"): {0}",
            parts.Contains(new Part {PartId = 1734, PartName = "" }));
        
        //insert a new item at position 2.
        Console.WriteLine("\nInsert(2, \"1834)\")");
        parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });
        
        //Console.WriteLine();
        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }
        
        Console.WriteLine("\nParts[3]: {0}", parts[3]);
        Console.WriteLine("\nRemove(\"1534\")");
        
    }
}
