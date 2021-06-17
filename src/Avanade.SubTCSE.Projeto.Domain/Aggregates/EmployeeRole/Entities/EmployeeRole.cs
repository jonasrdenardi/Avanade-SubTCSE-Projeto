﻿namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public class EmployeeRole
    {
        public string Id { get; private set; }
        public string RoleName { get; private set; }

        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public void AddRole(string roleName)
        {
            RoleName = roleName;
        }
    }
}