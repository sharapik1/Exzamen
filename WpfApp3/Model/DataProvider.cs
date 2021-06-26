using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class DataProvider : IDataProvider
    {
        private List<Pokupateli> PokupateliList = new List<Pokupateli>();
        public DataProvider(String fileName)
        {
            using (TextFieldParser parser = new TextFieldParser(fileName))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                while (!parser.EndOfData)
                {
                    //метод ReadFields разбивает исходную строку на массив строк
                    string[] fields = parser.ReadFields();
                    PokupateliList.Add(
                        new Pokupateli
                        {
                            Name = fields[0],
                            Age = int.Parse(fields[1]),
                            Summapokupok = Double.Parse(fields[2]),
                            Data = DateTime.Parse(fields[3]),
                            City = fields[4],
                            Magazin = fields[5]
                        }
                        );

                }
            }


        }

        public IEnumerable<City> GetCities()
        {
            return new City[]
            {
                new City { Title="Йошкар-Ола"},
                new City { Title="Москва"},
                new City { Title="Уфа"}
            };
        }

        public IEnumerable<Pokupateli> GetPokupatelis()
        {
            return PokupateliList;
        }
    }
}
