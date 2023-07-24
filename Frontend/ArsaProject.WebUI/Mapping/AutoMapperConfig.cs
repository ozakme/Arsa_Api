using ArsaProject.EntityLayer.Concrete;
using ArsaProject.WebUI.Dtos.AboutDto;
using ArsaProject.WebUI.Dtos.BookingDto;
using ArsaProject.WebUI.Dtos.GuestDto;
using ArsaProject.WebUI.Dtos.LoginDto;
using ArsaProject.WebUI.Dtos.RegisterDto;
using ArsaProject.WebUI.Dtos.ServiceDto;
using ArsaProject.WebUI.Dtos.ShowProductDto;
using ArsaProject.WebUI.Dtos.StaffDto;
using ArsaProject.WebUI.Dtos.SubscribeDto;
using ArsaProject.WebUI.Dtos.TestimonialDto;
using AutoMapper;

namespace ArsaProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();

            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();

            CreateMap<ResultShowProductDto, Product>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();

           


        }
    }
}
