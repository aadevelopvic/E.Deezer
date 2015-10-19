﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E.Deezer.Api
{
    public interface IEditorial
    {
        uint Id { get; set; }
        string Name { get; set; }
        int Genre { get; set; }
        string Picture { get; set; }

        ISearchResult<IAlbum> GetSelection();
        ISearchResult<IAlbum> GetReleases();
    }

    internal class Editorial : IEditorial
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public int Genre { get; set; }
        public string Picture { get; set; }

        public ISearchResult<IAlbum> GetSelection()
        {
            return null;
        }

        public ISearchResult<IAlbum> GetReleases()
        {
            return null;
        }


        public override string ToString()
        {
            return Name;
        }

    }
}