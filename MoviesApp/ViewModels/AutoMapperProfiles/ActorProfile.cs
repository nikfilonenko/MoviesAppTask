﻿using AutoMapper;
using MoviesApp.Models;
using MoviesApp.ViewModels;

namespace MoviesApp.ViewModels;

public class ActorProfile : Profile
{
    public ActorProfile()
    {
        CreateMap<Actors, InputActorViewModel>().ReverseMap();
        CreateMap<Actors, DeleteActorViewModel>();
        CreateMap<Actors, EditActorViewModel>().ReverseMap();
        CreateMap<Actors, ActorViewModel>();
    }
}