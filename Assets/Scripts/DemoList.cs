using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class DemoList : MonoBehaviour
{
    NativeList<int> list;

    // public UnsafeList<NativeString32> namelist;

    // Start is called before the first frame update
    void Start()
    {
        list = new NativeList<int>(10, Allocator.TempJob);
        list.Add(10);
        list.Add(20);
        for (int i = 0; i < list.Length; i++)
        {
            Debug.Log("i = " + list[i]);
        }
        list.Dispose(); // hủy danh sách

        //namelist = new UnsafeList<NativeString32>(10, AllocatorManager.TempJob);
        //namelist.Add("Dan");
        //namelist.Add("John");
        //for (int i = 0; i < namelist.length; i++)
        //{
        //    Debug.Log("i = " + namelist[i]);
        //}
        //namelist.Dispose();
    }
}
