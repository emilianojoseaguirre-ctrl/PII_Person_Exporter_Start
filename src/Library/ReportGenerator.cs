//------------------------------------------------------------------------------
// <copyright file="ReportGenerator.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------
using System.Collections.Generic;


namespace Ucu.Poo.PersonExporter
{
    /// <summary>
    /// Genera reportes de personas en distintos formatos: PDF y HTML.
    /// </summary>
    public class ReportGenerator
    {
        /// <summary>
        /// Genera un reporte de una lista de personas en el formato indicado.
        /// </summary>
        /// <param name="people">Lista de personas a incluir en el
        /// reporte.</param>
        /// <param name="format">Formato de salida del reporte. Valores
        /// esperados: "PDF" o "HTML".</param>
        /// <param name="outputPath">Ruta completa del archivo de salida que se
        /// va a generar.</param>
        /// <returns>Retorna <c>true</c> si los reportes fueron generados y
        /// <c>false</c> en caso contrario.</returns>
        public bool GenerateReport(IList<Person> people, IExporter exporter, string outputPath)
        {
            if (people == null)
            {
                return false;
            }

            if (exporter == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(outputPath))
            {
                return false;
            }

            exporter.Export(people, outputPath);
            return true;
        }
    }
}
