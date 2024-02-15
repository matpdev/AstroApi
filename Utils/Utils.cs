using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace AstroApi.Utils
{
    public class Utils
    {
        public static async Task<
            List<Dictionary<string, dynamic>>
        > ConvertDataReaderToDictionaryList(NpgsqlDataReader reader)
        {
            List<Dictionary<string, dynamic>> resultList = new List<Dictionary<string, dynamic>>();

            Dictionary<string, dynamic> row = new Dictionary<string, dynamic>();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                string columnName = reader.GetName(i);
                dynamic columnValue = reader[i];

                row[columnName] = columnValue;
            }

            resultList.Add(row);

            return resultList;
        }
    }
}
