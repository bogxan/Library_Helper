using AutoMapper;
using LibraryHelperBLL.DTO;
using LibraryHelperDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHelperBLL.AutoMapper.Profiles
{
    public class MapingProfile: Profile
    {
        public MapingProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<BookDto, Book>();
            CreateMap<LendBook, LendBookDto>();
            CreateMap<LendBookDto, LendBook>();
            CreateMap<Reader, ReaderDto>();
            CreateMap<ReaderDto, Reader>();
        }
    }
}
