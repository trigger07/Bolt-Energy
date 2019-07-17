#region imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace Common
{
    [Serializable]
    public class BaseDTO : IDataTransferObject
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the Entity class.
        /// </summary>
        protected BaseDTO()
        {
            IsDirty = false;
            Method = ObjectMethod.None;
        }
        #endregion
        #region IDataTransferObject Members

        /// <summary>
        /// Indicates if the object has been modified from its original state.
        /// </summary>
        /// <remarks>True if object has been modified from its original state; otherwise False;</remarks>
        public bool IsDirty { get; set; }
        /// <summary>
        /// Indicates the process to follow.
        /// </summary>
        public ObjectMethod Method { get; set; }

        #endregion
    }
}
