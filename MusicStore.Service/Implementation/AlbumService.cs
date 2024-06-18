﻿using MusicStore.Domain.DomainModels;
using MusicStore.Repository.Interface;
using MusicStore.Service.Interface;


namespace MusicStore.Service.Implementation
{
    public class AlbumService : IAlbumService
    {

        private readonly IAlbumRepository _albumRepository;

        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public void CreateNewAlbum(Album a)
        {
            _albumRepository.Insert(a);
        }

        public void DeleteAlbum(Guid id)
        {
            var album = _albumRepository.Get(id);
            _albumRepository.Delete(album);
        }

        public List<Album> GetAllAlbums()
        {
            return _albumRepository.GetAll().ToList();
        }

        public Album GetDetailsForAlbum(Guid id)
        {
            return _albumRepository.Get(id);
        }

        public void UpdateExistingAlbum(Album a)
        {
            _albumRepository.Update(a);
        }
    }
}
