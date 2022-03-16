using Back_end_API.Models;
using System.Collections.Generic;
using System;
using Back_end_API.Dtos;
public interface IDataAccess
{
    List<PresonModel> peoples();
    PresonModel CreatePresion(string FirstName, string LastName);
    PresonModel UpdatePresion(PresonModel preson,PresonUpdateDto presonDto);
    PresonModel DeletePresion(PresonModel preson);
    PresonModel GetPresonModelById(Guid Id);
}