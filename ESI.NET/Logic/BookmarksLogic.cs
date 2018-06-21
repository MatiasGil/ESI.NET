﻿using ESI.NET.Models.Bookmarks;
using ESI.NET.Models.SSO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static ESI.NET.ApiRequest;

namespace ESI.NET.Logic
{
    public class BookmarksLogic
    {
        private HttpClient _client;
        private ESIConfig _config;
        private AuthorizedCharacterData _data;
        private int corporation_id, character_id;

        public BookmarksLogic(HttpClient client, ESIConfig config, AuthorizedCharacterData data = null)
        {
            _client = client;
            _config = config;
            _data = data;

            if (data != null)
            {
                corporation_id = data.CorporationID;
                character_id = data.CharacterID;
            }
        }

        /// <summary>
        /// /characters/{character_id}/bookmarks/
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<Bookmark>>> ForCharacter(int page = 1)
            => await Execute<List<Bookmark>>(_client, _config, RequestSecurity.Authenticated, RequestMethod.GET, $"/characters/{character_id}/bookmarks/", new string[]
            {
                $"page={page}"
            }, token: _data.Token);

        /// <summary>
        /// /characters/{character_id}/bookmarks/folders/
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<Folder>>> FoldersForCharacter(int page = 1)
            => await Execute<List<Folder>>(_client, _config, RequestSecurity.Authenticated, RequestMethod.GET, $"/characters/{character_id}/bookmarks/folders/", new string[]
            {
                $"page={page}"
            }, token: _data.Token);

        /// <summary>
        /// /corporations/{corporation_id}/bookmarks/
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<Bookmark>>> ForCorporation(int page = 1)
            => await Execute<List<Bookmark>>(_client, _config, RequestSecurity.Authenticated, RequestMethod.GET, $"/corporations/{corporation_id}/bookmarks/", new string[]
            {
                $"page={page}"
            }, token: _data.Token);

        /// <summary>
        /// /corporations/{corporation_id}/bookmarks/folders/
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<Folder>>> FoldersForCorporation(int page = 1)
            => await Execute<List<Folder>>(_client, _config, RequestSecurity.Authenticated, RequestMethod.GET, $"/corporations/{corporation_id}/bookmarks/folders/", new string[]
            {
                $"page={page}"
            }, token: _data.Token);
    }
}