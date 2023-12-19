using Auto_Mapper.Entities;
using Auto_Mapper.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Auto_Mapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapperController : ControllerBase
    {
        private readonly IMapper _mapper;
        public MapperController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("GetForMember")]
        public EmployeeModel GetForMember()
        {
            var employee = new Employee();
            return _mapper.Map<EmployeeModel>(employee);
        }

        [HttpGet("GetIgnore")]
        public EmployeeModel GetIgnore()
        {
            var employee = new Employee();
            return _mapper.Map<EmployeeModel>(employee);
        }

        [HttpGet("GetInclude<obj1,obj2>")]
        public EmployeeModel GetInclude()
        {
            var employee = new Engineer();
            return _mapper.Map<EngineerModel>(employee);
        }

        [HttpGet("GetIncludeAllDerived")]
        public EmployeeModel GetIncludeAllDerived()
        {
            var employee = new Doctor();
            return _mapper.Map<DoctorModel>(employee);
        }

        [HttpGet("GetIncludeBase")]
        public EmployeeModel GetIncludeBase()
        {

            var employee = new Engineer();
            return _mapper.Map<EngineerModel>(employee);

            //var employee = new Doctor();
            //return _mapper.Map<DoctorModel>(employee);
        }

        [HttpGet("GetIncludeMember")]
        public TeacherModel GetIncludeMember()
        {
            var employee = new Employee();
            return _mapper.Map<TeacherModel>(employee);
        }

        [HttpGet("GetCondition")]
        public TeacherModel GetCondition()
        {
            var employee = new Employee();
            return _mapper.Map<TeacherModel>(employee);
        }


        [HttpGet("GetPasskeyValueToMapper")]
        public TeacherModel GetPasskeyValueToMapper()
        {
            var employee = new Employee();
            return _mapper.Map<TeacherModel>(employee, opt => opt.Items["Name"] = "Mike");
        }

    }
}
