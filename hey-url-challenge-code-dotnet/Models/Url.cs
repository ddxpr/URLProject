﻿using System;
namespace hey_url_challenge_code_dotnet.Models
{
    public class Url
    {
        public Guid Id { get; set; }

        public string ShortUrl { get; set; }

        public string OriginalUrl { get; set; }

        public string Created { get; set; }

        public int Count { get; set; }
    }
}
