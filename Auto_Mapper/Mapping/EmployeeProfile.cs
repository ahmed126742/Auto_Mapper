using System.Dynamic;
using Auto_Mapper.Entities;
using Auto_Mapper.Models;
using AutoMapper;

namespace Auto_Mapper.Mapping
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            // GetForMember();

            // GetIgnore();

            //GetInclude();

            // GetIncludeAllDerived();

            // GetIncludeBase();

            // GetIncludeMember();

            //GetCondition();

             GetPasskeyValueTOMapper();
        }

        #region GetForMember

        private void GetForMember()
        {

            CreateMap<Employee, EmployeeModel>()
                .ForMember(dst => dst.Address, opt => opt.MapFrom(
                    src => new AddressModel
                    {
                        City = src.Address.City,
                        Region = src.Address.Region,
                        Country = src.Address.Country,
                        Id = src.Address.Id,
                        PostalCode = src.Address.PostalCode,
                        Street = src.Address.Street
                    }));

        }

        //private void GetForMember() // enhanced
        //{
        //    CreateMap<Employee, EmployeeModel>()
        //          .ForPath(dst => dst.Address.Id, opt => opt.MapFrom(src => src.Address.Id))
        //          .ForPath(dst => dst.Address.City, opt => opt.MapFrom(src => src.Address.City))
        //          .ForPath(dst => dst.Address.Region, opt => opt.MapFrom(src => src.Address.Region))
        //          .ForPath(dst => dst.Address.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
        //          .ForPath(dst => dst.Address.Country, opt => opt.MapFrom(src => src.Address.Country))
        //          .ForPath(dst => dst.Address.Street, opt => opt.MapFrom(src => src.Address.Street));
        //}

        //private void GetForMember()
        //{
        //    CreateMap<Employee, EmployeeModel>();

        //    CreateMap<Address, AddressModel>();
        //}

        #endregion

        #region GetIgnore

            private void GetIgnore()
            {
                CreateMap<Employee, EmployeeModel>()
                    .ForMember(dst => dst.Id, opt => opt.Ignore())
                    .ForMember(dst => dst.Address, opt => opt.Ignore());
            }

        #endregion

        #region GetInclude<obj1, obj2>
            private void GetInclude()
            {
                CreateMap<Employee, EmployeeModel>()
                     .Include<Engineer,EngineerModel>()
                     .ForMember(dst => dst.Address, opt => opt.Ignore());

                CreateMap<Engineer, EngineerModel>();
            }

        #endregion

        #region GetIncludeAllDerived
      
            private void GetIncludeAllDerived()
            {
                CreateMap<Employee, EmployeeModel>()
                     .IncludeAllDerived()
                     .ForMember(dst => dst.Address, opt => opt.Ignore());

                CreateMap<Engineer, EngineerModel>();

                CreateMap<Doctor, DoctorModel>();
            }

        #endregion

        #region GetIncludeBase

            private void GetIncludeBase()
            {
                CreateMap<Employee, EmployeeModel>()
                     .ForMember(dst => dst.Address, opt => opt.Ignore());

                CreateMap<Engineer, EngineerModel>()
                    .IncludeBase<Employee, EmployeeModel>();

            // without include base
                CreateMap<Doctor, DoctorModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom( src => "Shehab"));

                CreateMap<Address, AddressModel>();
            }

        #endregion

        #region GetIncludeMember

            private void GetIncludeMember()
            {
                CreateMap<Employee, TeacherModel>()
                     .IncludeMembers(src => src.Address);

                CreateMap<Address, TeacherModel>();
            }

        #endregion

        #region GetCondition
        
            private void GetCondition()
            {
                CreateMap<Employee, TeacherModel>()
                     .IncludeMembers(src => src.Address)
                     .ForMember(dst => dst.Id, opt => opt.Condition(src => src.Id < 3));

                CreateMap<Address, TeacherModel>();
            }

        #endregion

        private void GetPasskeyValueTOMapper()
        {
            CreateMap<Employee, TeacherModel>()
                        .IncludeMembers(src => src.Address)
                        .ForMember(dst => dst.Name, opt => opt.MapFrom((src, dst, x, context) => context.Items["Name"]));

            CreateMap<Address, TeacherModel>();
        }
    }
}
