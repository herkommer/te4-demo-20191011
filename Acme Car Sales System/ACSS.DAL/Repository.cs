using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACSS.Business;

namespace ACSS.DAL
{
    public class Repository
    {
        //Börja med det önskade beteendet, dvs metoderna
        //CRUD
        //Testar med en privat List<Car>
        private List<Car> _cars = new List<Car>();

        public Repository()
        {
            _cars.Add(new Car() { Make = "Volvo", Model = "V70" });
            _cars.Add(new Car() { Make = "Volvo", Model = "V60" });
        }

        //C-Create: INSERT INTO
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        //R-Read: SELECT
        public List<Car> Get()
        {
            return _cars;
        }
        public List<Car> GetById(Car car)
        {
            //OBS: gör en sökning baserat på bilens id
            return _cars;
        }

        //U-Update: UPDATE
        public void Update(Car car)
        {

        }

        //D-Delete: DELETE
        public void Remove(Car car)
        {
            _cars.Remove(car);
        }
    }
}
