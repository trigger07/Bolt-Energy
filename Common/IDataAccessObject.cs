#region imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace Common
{
    public interface IDataAccessObject<T> where T : IDataTransferObject, new()
    {
        #region Method
        /// <summary>
        /// Saves the Entity to the database
        /// </summary>
        /// <param name="entityDto">Entity to save</param>
        void Save(T entityDto);
        /// <summary>
        /// Agrego esto
        /// </summary>
        /// <param name="entityDto"></param>
        /// <returns></returns>
        #endregion
    }
}
