﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands
{
    public class UpdateMovieCommand
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        //yayin yili
        public DateTime ReleaseDate { get; set; }
        //cekilme tarihi
        public string CreatedYear { get; set; }
        public bool Status { get; set; }
    }
}
