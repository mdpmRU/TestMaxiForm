﻿using Create;
using TestData;
//"административная" программа для добавления данных
var dbName = "TestMaxiForm2";
SqlCommands sql = new(dbName);
sql.DropDataBase();
sql.CreateDataBase();
sql.CreateTables();
sql.CreateTestValues(Stubs.Employees, Stubs.Positions, Stubs.Departments);

