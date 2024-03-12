using Contracts;
using Entities;
using System.Collections.Generic;
using System.Data;

namespace RepositoriesSQL
{
    public class PositionRepository : BaseRepository, IPositionRepository
    {
        public IEnumerable<Position> GetAll()
        {
            string command = $"SELECT * FROM {TableNamePositions};";
            var result = ExecuteQueryWithData(command).Rows;
            var list = new List<Position>();
            foreach (DataRow row in result)
            {
                list.Add(ParsePosition(row));
            }
            return list;
        }

        public Position GetById(int id)
        {
            string command = $"SELECT * FROM {TableNamePositions} WHERE ID = {id};";
            var result = ExecuteQueryWithData(command).Rows[0];
            return ParsePosition(result);
        }

        public void Insert(Position entity)
        {
            string command = $"INSERT {TableNamePositions} VALUES ('{entity.Name}')";
            Execute(command);
        }

        public void Update(Position entity)
        {
            string command = $"""
                              UPDATE {TableNamePositions}
                              SET DepartmentName = '{entity.Name}' WHERE ID = {entity.Id}
                              """;
            Execute(command);
        }

        public void DeleteById(int id)
        {
            string command = $"DELETE FROM {TableNamePositions} WHERE ID = {id}";
            Execute(command);
        }

        private Position ParsePosition(DataRow result)
        {
            return new Position() { Id = Int32.Parse(result[0].ToString()), Name = result[1].ToString() };
        }
    }
}
