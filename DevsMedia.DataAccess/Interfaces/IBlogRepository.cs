﻿using DevsMedia.Models;

namespace DevsMedia.DataAccess.Interfaces
{
    public interface IBlogRepository
    {
        Task Update(Blog blog);
    }
}