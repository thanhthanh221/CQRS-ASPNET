using Back_end_API.Models;
using System.Collections.Generic;
using System;
public interface IDataAccess
{
    List<PresonModel> peoples();
    PresonModel CreatePresion(string FirstName, string LastName);
}