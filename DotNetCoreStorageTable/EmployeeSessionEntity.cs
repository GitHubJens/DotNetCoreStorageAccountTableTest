﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace DotNetCoreStorageTable
{
    public class EmployeeSessionEntity : TableEntity
    {
        public EmployeeSessionEntity()
        {
        }
        public EmployeeSessionEntity(int id, string name, double sal)
        {
            Id = id;
            Name = name;
            Salaray = sal;
            PartitionKey = id.ToString();
            RowKey = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salaray { get; set; }
    }
}