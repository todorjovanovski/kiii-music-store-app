﻿using MusicStore.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interface
{
    public interface IArtistService
    {
        List<Artist> GetAllArtists();
        Artist GetDetailsForArtist(Guid id);
        void CreateNewArtist(Artist a);
        void UpdateExistingArtist(Artist a);
        void DeleteArtist(Guid id);
    }
}
