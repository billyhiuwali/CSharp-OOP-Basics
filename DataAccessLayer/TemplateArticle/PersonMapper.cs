using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace TemplateArticle
{
    class PersonMapper: MapperBase<Person>
    {
        protected override Person Map(IDataRecord record)
        {
            try
            {
                Person p = new Person();

                p.Id = (DBNull.Value == record["PersonID"]) ?
                    0 : (int)record["PersonID"];

                p.FirstName = (DBNull.Value == record["FirstName"]) ?
                    string.Empty : (string)record["FirstName"];

                p.LastName = (DBNull.Value == record["LastName"]) ?
                    string.Empty : (string)record["LastName"];

                p.Email = (DBNull.Value == record["Email"]) ?
                    string.Empty : (string)record["Email"];

                return p;
            }
            catch
            {
                throw;

                // NOTE: 
                // consider handling exeption here instead of re-throwing
                // if graceful recovery can be accomplished
            }
        }
    }
}
