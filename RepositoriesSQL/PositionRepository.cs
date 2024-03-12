using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace RepositoriesSQL
{
    public class PositionRepository : BaseRepository, IPositionRepository
    {
        public IEnumerable<Position> GetAll()
        {
            string command = $"SELECT * FROM {TableNamePositions} WHERE ID = {id};";
        }

        public Position GetById(int id)
        {
            string command = $"SELECT * FROM {TableNamePositions} WHERE ID = {id};";
            ExecuteQueriWithData(command);
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
