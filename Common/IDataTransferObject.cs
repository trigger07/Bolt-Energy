#region imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace Common
{
    public interface IDataTransferObject
    {
        #region  Method
        /// <summary>
        ///	Indicates if the object has been modified from its original state.
        /// </summary>
        ///<value>True if object has been modified from its original state; otherwise False;</value>
        bool IsDirty { get; }

        /// <summary>
        ///	Indicates object's path to follow.
        /// </summary>
        ObjectMethod Method { get; set; }
        #endregion
    }
}
