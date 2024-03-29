﻿using System.Collections.Generic;
using MoviesApp.Services.DTO;

namespace MoviesApp.Services;

public interface IMovieService
{
    MovieDto GetMovie(int id);
    IEnumerable<MovieDto> GetAllMovies();
    MovieDto UpdateMovie(MovieDto movieDto);
    MovieDto AddMovie(MovieDto movieDto);
    MovieDto DeleteMovie(int id);
}