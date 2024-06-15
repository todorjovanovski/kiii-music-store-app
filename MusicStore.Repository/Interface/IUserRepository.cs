﻿using MusicStore.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<MusicStoreUser> GetAll();
        MusicStoreUser Get(string id);
        void Insert(MusicStoreUser entity);
        void Update(MusicStoreUser entity);
        void Delete(MusicStoreUser entity);
    }
}