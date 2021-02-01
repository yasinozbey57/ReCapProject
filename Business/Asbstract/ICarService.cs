using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Asbstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

    }
}
