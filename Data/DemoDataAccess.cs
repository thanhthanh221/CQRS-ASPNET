using Back_end_API.Models;
using System.Collections.Generic;
using System;

namespace Back_end_API.Data
{
    public class DemoDataAccess : IDataAccess
    {
        public List<PresonModel> people = new();

        // Cách dùng mới của .Net5- C#9

        public DemoDataAccess(){
            people.Add(new PresonModel(){ Id = Guid.NewGuid(), FirstName = "Bùi", LastName = "Quang"});
            people.Add(new PresonModel(){ Id = Guid.NewGuid(), FirstName = "Tạ", LastName = "Yến"});

        }
        // Truy cập dữ liệu
        public List<PresonModel> peoples(){
            return people;
        }
        public PresonModel CreatePresion(string FirstName, string LastName){
            PresonModel people_New = new(){
                Id = Guid.NewGuid(),
                FirstName = FirstName,
                LastName = LastName
            };
            people.Add(people_New);
            return people_New;
        }

    }
}
