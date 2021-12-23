﻿using Data;
using Domain;
using Infra.Common;
using System.Collections.Generic;

namespace Infra
{
    public class MoviesRepo : BaseRepo<Movie, MovieData>
    {
        private readonly List<CategoryData> _categories;
        public MoviesRepo() : this(null) { }
        public MoviesRepo(MoviesList movies) : base(movies?.movies) 
        {
            _categories = movies?.categories;
        }

        protected internal override Movie ToEntity(MovieData d)
            => new Movie(d, _categories);
    }
}