using Back_end_API.Models;
using System.Collections.Generic;
using System;
using Back_end_API.Dtos;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Back_end_API.Data
{
    // Thêm sử dụng MongoDb
    // Thay vì dùng Linq to entity thì dùng MongoDb 
    // Xử Lý Q(trong CQRS) => nếu dùng SQL thì nên dùng dapper
    public class DemoDataAccess : IDataAccess
    {
        //Thêm Chuỗi kết nối MongoDb

        private const string DataBaseName = "AddressBook";
        private const string CollectionName = "User";

        // Cơ sở dữ liệu trên mongodb tương ứng với trên
        private readonly IMongoCollection<PresonModel> people;

        private readonly FilterDefinitionBuilder<PresonModel> definitionBuilder = Builders<PresonModel>.Filter;

        // Cách dùng mới của .Net5- C#9

        public DemoDataAccess(IMongoClient mongoClient){
            IMongoDatabase database = mongoClient.GetDatabase(DataBaseName);
            
            people = database.GetCollection<PresonModel>(CollectionName);

        }
        // Truy cập dữ liệu
        public List<PresonModel> peoples(){
            return people.Find(new BsonDocument()).ToList();
        }
        public PresonModel CreatePresion(string FirstName, string LastName){
            PresonModel people_New = new(){
                Id = Guid.NewGuid(),
                FirstName = FirstName,
                LastName = LastName
            };
            people.InsertOne(people_New);
            return people_New;
        }

        public PresonModel UpdatePresion(PresonModel preson, PresonUpdateDto presonDto)
        {
            preson.FirstName = presonDto.FirstName;
            preson.LastName = presonDto.LastName;
            
            return preson;
        }
        public PresonModel DeletePresion(PresonModel preson)
        {
            FilterDefinition<PresonModel> filter = definitionBuilder.Eq(p => p.Id,preson.Id);

            people.DeleteOne(filter);            
            return preson;
        }

        public PresonModel GetPresonModelById(Guid Id)
        {
            var filter = definitionBuilder.Eq(p => p.Id,Id);
            PresonModel preson_Find = people.Find(filter).SingleOrDefault();
            return preson_Find;
        }
    }
}
