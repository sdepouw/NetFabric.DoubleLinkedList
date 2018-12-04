using System;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("NetFabric.DoubleLinkedList.Tests")]

namespace NetFabric
{
    public static class DoubleLinkedList
    {
        public static DoubleLinkedList<T> Append<T>(DoubleLinkedList<T> left, DoubleLinkedList<T> right) 
        {
            var result = new DoubleLinkedList<T>();
            result.AddLast(left);
            result.AddLast(right);
            return result;
        }
    }
}
