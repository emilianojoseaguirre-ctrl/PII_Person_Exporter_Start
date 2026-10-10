using System.Collections.Generic;


namespace Ucu.Poo.PersonExporter
{
    public interface IExporter
    {
        void Export(IList<Person> people, string outputPath);
    }
}