#region imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace Common
{
    #region Method
    /// <summary>
    /// An enumeration that tells each object what process should follow.
    /// </summary>
    public enum ObjectMethod
    {
         /// <summary>
        /// Create New Object
        /// </summary>
        New,
        /// <summary>
        /// Modify Existing Object
        /// </summary>
        Modify,
        /// <summary>
        /// Delete Existing Object
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// Agrego esto
        /// </summary>
    }
    #endregion
}
