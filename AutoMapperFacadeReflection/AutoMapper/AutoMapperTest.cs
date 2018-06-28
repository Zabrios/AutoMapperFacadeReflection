using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperFacadeReflection
{
    public class AutoMapperTest
    {
        public void MappingTest()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PersonModel, StudentModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new PersonModel { Name = "test", Lastname = "testLastname", Height = 180, Age = 21 };
            var dest = mapper.Map<PersonModel, StudentModel>(source);

            Console.WriteLine(string.Format(@"Name: {0}, Lastname: {1}, Age: {2}, Is Graduated: {3}", dest.Name, dest.Lastname, dest.Age, dest.IsGraduated));
            //Mapper.CreateMap<StudentModel, PersonModel>();

        }
    }
}
