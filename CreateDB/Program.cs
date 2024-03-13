using Create;
using TestData;
//"административная" программа для добавления данных и хранимой процедуры
var dbName = "EmployeeManagement";
SqlCommands sql = new(dbName);
sql.DropDataBase();
sql.CreateDataBase();
sql.CreateTables();
sql.CreateTestValues(Stubs.Employees, Stubs.Positions, Stubs.Departments);
sql.CreateStoreProcedure();