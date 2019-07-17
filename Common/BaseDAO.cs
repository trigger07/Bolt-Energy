#region imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
#endregion

namespace Common
{
    public abstract class BaseDAO<T> : IDataAccessObject<T> where T : BaseDTO, new()
    {
        #region ConnectionEntLib
        protected Database db;
        public BaseDAO()
        {
            db = DatabaseFactory.CreateDatabase();
        }
        public BaseDAO(string connection)
        {
            db = DatabaseFactory.CreateDatabase(connection);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Creates a new record on the DB
        /// </summary>
        /// <param name="entityDto">Entity to be saved</param>
        protected abstract void SaveNew(T entityDto);
        /// <summary>
        /// Saves an Existing Record to the DB
        /// </summary>
        /// <param name="entityDto">Entity to be Modified</param>
        protected abstract void SaveExisting(T entityDto);
        /// <summary>
        /// Deletes a record from a Database
        /// </summary>
        /// <param name="entityDto">Entity to be Deleted</param>
        protected abstract void Delete(T entityDto);
        #endregion

        #region IDataAccessObject<T> Members
        /// <summary>
        /// Save entity  in to the Database 
        /// </summary>
        public void Save(T entityDto)
        {
            switch (entityDto.Method)
            {
                case ObjectMethod.New:
                    SaveNew(entityDto);
                    break;
                case ObjectMethod.Modify:
                    SaveExisting(entityDto);
                    break;
                case ObjectMethod.Delete:
                    Delete(entityDto);
                    break;
            }
        }
        #endregion
    }
}
