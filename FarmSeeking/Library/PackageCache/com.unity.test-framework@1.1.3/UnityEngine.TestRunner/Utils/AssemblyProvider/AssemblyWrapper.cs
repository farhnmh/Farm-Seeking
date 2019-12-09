<<<<<<< HEAD
using System;
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyWrapper : IAssemblyWrapper
    {
        public AssemblyWrapper(Assembly assembly)
        {
            Assembly = assembly;
        }

        public Assembly Assembly { get; }

        public virtual string Location
        {
            get
            {
                //Some platforms dont support this
                throw new NotImplementedException();
            }
        }

        public virtual AssemblyName[] GetReferencedAssemblies()
        {
            //Some platforms dont support this
            throw new NotImplementedException();
        }
    }
}
=======
using System;
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyWrapper : IAssemblyWrapper
    {
        public AssemblyWrapper(Assembly assembly)
        {
            Assembly = assembly;
        }

        public Assembly Assembly { get; }

        public virtual string Location
        {
            get
            {
                //Some platforms dont support this
                throw new NotImplementedException();
            }
        }

        public virtual AssemblyName[] GetReferencedAssemblies()
        {
            //Some platforms dont support this
            throw new NotImplementedException();
        }
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
