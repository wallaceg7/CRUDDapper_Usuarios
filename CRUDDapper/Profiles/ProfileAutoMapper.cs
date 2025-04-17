﻿using AutoMapper;
using CRUDDapper.Dto;
using CRUDDapper.Models;

namespace CRUDDapper.Profiles
{
    public class ProfileAutoMapper : Profile
    {
        public ProfileAutoMapper()
        {
            CreateMap<Usuario, UsuarioListarDto>();
        }
    }
}
