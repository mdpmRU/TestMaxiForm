using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace RepositoriesSQL
{
    public class EmployeeRepository: IPositionRepository
    {
        public IEnumerable<Position> GetAll()
        {
            yield break;
        }

        public Position GetById(int id)
        {
            return null;
        }

        public void Insert(Position entity)
        {
        }

        public void Update(Position entity)
        {
        }

        public void DeleteById(int id)
        {
        }
    }
}
