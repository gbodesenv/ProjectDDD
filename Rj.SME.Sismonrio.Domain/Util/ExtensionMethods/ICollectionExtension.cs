﻿using System.Collections;

namespace Rj.SME.Sismonrio.Domain.Util.ExtensionMethods
{
    public static class ICollectionExtension
    {
        /// <summary>
        /// Verifica se a coleção está nula ou vazia
        /// </summary>
        /// <param name="obj">Objeto</param>
        /// <returns>true se null ou vazio</returns>
        public static bool IsNullOrEmpty(this ICollection obj)
        {
            return obj == null || obj.Count == 0;
        }
    }
}