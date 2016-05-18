using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreReference.Models;
using System.IO;
using Newtonsoft.Json;
using Nest;

namespace SitecoreReference.Dal
{
    public class ElasticsearchRepository :  IRepository
    {
        const string INDEX_NAME = "sitecore_reference_index";

        static Uri _node;
        static ConnectionSettings _settings;
        static ElasticClient _client;
        IData _data;
        
        public ElasticsearchRepository(IData data)
        {
            _data = data;
            _node = new Uri("http://localhost:9200");
            _settings = new ConnectionSettings(_node, defaultIndex: INDEX_NAME);
            _client = new ElasticClient(_settings);

            Init();
        }
        
        public IQueryable<ClientComment> GetAllClientComments()
        {
            
            var matchAllResult =
                _client.Search<ClientComment>(s => s
                .Query(p => p.MatchAll(null, null)));
            
            return matchAllResult.Documents.AsQueryable();
        }

        public IQueryable<Location> GetAllLocations()
        {
            var matchAllResult =
               _client.Search<Location>(s => s
               .Query(p => p.MatchAll(null, null)));

            return matchAllResult.Documents.AsQueryable();
        }

        public IQueryable<RecentWork> GetAllRecentWork()
        {
            var matchAllResult =
            _client.Search<RecentWork>(s => s
            .Query(p => p.MatchAll(null, null)));

            return matchAllResult.Documents.AsQueryable();
        }

        public IQueryable<Service> GetAllServices()
        {
            var matchAllResult =
            _client.Search<Service>(s => s
            .Query(p => p.MatchAll(null, null)));

            return matchAllResult.Documents.AsQueryable();
        }

        public IQueryable<TeamMemberProfile> GetAllTeamMemberProfiles()
        {
            var matchAllResult =
            _client.Search<TeamMemberProfile>(s => s
            .Query(p => p.MatchAll(null, null)));

            return matchAllResult.Documents.AsQueryable();
        }

        private void Init()
        {
            if (!_client.IndexExists(INDEX_NAME).Exists)
            {
                if (CreateIndex().Acknowledged)
                {
                    SeedIndex();
                }
            }
        }

        private IIndicesOperationResponse CreateIndex()
        {
            var indexSettings = new IndexSettings();
            indexSettings.NumberOfReplicas = 1;
            indexSettings.NumberOfShards = 1;

            return _client.CreateIndex(c => c
                .Index(INDEX_NAME)
                .InitializeUsing(indexSettings)
                .AddMapping<ClientComment>(m => m.MapFromAttributes())
                .AddMapping<Location>(m => m.MapFromAttributes())
                .AddMapping<Service>(m => m.MapFromAttributes())
                .AddMapping<RecentWork>(m => m.MapFromAttributes())
                .AddMapping<TeamMemberProfile>(m => m.MapFromAttributes()));
        }

        private void SeedIndex()
        {
            _data.ClientComments().ToList().ForEach((m => _client.Index(m)));
            _data.Locations().ToList().ForEach((m => _client.Index(m)));
            _data.RecentWorks().ToList().ForEach((m => _client.Index(m)));
            _data.Services().ToList().ForEach((m => _client.Index(m)));
            _data.TeamMemberProfiles().ToList().ForEach((m => _client.Index(m)));
        }
        
        private void SearchByTerm()
        {
            var termQueryResult =
                _client.Search<ClientComment>(s => s
                .Query(p => p.Term(q => q.Comment, "lorem")));
        }

        private void RawSearch()
        {
            var rawQueryResult =
                _client.Search<ClientComment>(s => s
                .Type("clientcomment")
                .QueryRaw(
                @"{
                    ""match_all"": { }
                }"));
        }
    }
}