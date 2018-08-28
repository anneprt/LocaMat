using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat.DAL
{
    public static class Extensions
    {
        /// <summary>
        /// Méthode d'extension pour gérer les champs nulls de type date
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="indexColonne"></param>
        /// <returns></returns>
        public static DateTime? GetNullableDateTime(this IDataReader reader, int indexColonne)
        {
            return reader.IsDBNull(indexColonne)
                           ? (DateTime?)null
                           : reader.GetDateTime(indexColonne);
        }

        /// <summary>
        /// Méthode d'extension pour gérer les champs nulls de type string
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="indexColonne"></param>
        /// <returns></returns>
        public static string GetNullableString(this IDataReader reader, int indexColonne)
        {
            return reader.IsDBNull(indexColonne)
                           ? (string)null
                           : reader.GetString(indexColonne);
        }

        /// <summary>
        /// Méthode d'extension qui renvoie DBNull quand la valeur
        /// fournie est nulle ou vide.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object NullIfNotSet(this string value)
        {
            return string.IsNullOrEmpty(value)
                ? DBNull.Value
                : (object)value;
        }

        /// <summary>
        /// Méthode d'extension qui renvoie DBNull quand la valeur
        /// fournie est nulle.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object NullIfNotSet(this DateTime? value)
        {
            return value == null
                ? DBNull.Value
                : (object)value;
        }
    }
}
