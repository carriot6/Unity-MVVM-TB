using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using UnityMVVM.ViewModel;

namespace UnityMVVM.Samples
{
    public class B
    {
        public string c = "mmm";
    }

    public class A: B
    {

    }

    public class AssemblyViewModel : ViewModelBase
    {
        public string AssemblyName => Assembly.GetExecutingAssembly().FullName;
        public A a { get; set; }
    }
} 