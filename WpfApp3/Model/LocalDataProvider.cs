using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Pokupateli> GetPokupatelis()
        {
            return new Pokupateli[] {
            new Pokupateli {Name="Шарапова Екатерина", Age=20, Summapokupok=680.20, Data=new DateTime(2021,05,21), City="Йошкар-Ола", Magazin="Пятёрочка"},
            new Pokupateli {Name="Шарапова Александра", Age=30, Summapokupok=1236.90, Data=new DateTime(2020,12,21), City="Москва", Magazin="Магнит"},
            new Pokupateli {Name="Смирнов Михаил", Age=25, Summapokupok=5909.10, Data=new DateTime(2019,12,12), City="Орел", Magazin="Плёс"}};
        }
        public IEnumerable<City> GetCities()
        {
            return new City[]
            {
                new City { Title="Йошкар-Ола"},
                new City { Title="Москва"},
                new City { Title="Орел"},
            };

        }

    }
}
